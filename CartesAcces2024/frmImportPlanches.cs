/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CartesAcces2024
{
    public partial class frmImportPlanches : Form
    {
        /// <summary>
        /// Permet de savoir si on génère des planches sur les élèves de l'année en cours ou de l'année prochaine
        /// (dossiers et tables de la base de données séparées).
        /// </summary>
        public enum mode
        {
            classesNormales,
            classesNouvelleAnnee
        }

        public static string cheminPlanches { get; set; } = "";
        
        public frmImportPlanches()
        {
            InitializeComponent();
        }

        //private void btnDossImport_Click(object sender, EventArgs e)
        //{
        //    I_ImportService service = new ImportDossier();
        //    //Globale.Cas = Globale.CodeCas.copierDossier;
        //    cheminPlanches = service.setCheminImportation();
        //    if(cheminPlanches != "failed")
        //        LecturePlanches.CorrespondancePlanches(cheminPlanches, mode.classesNormales);
        //}

        //private void btnDossImportNA_Click(object sender, EventArgs e)
        //{
        //    I_ImportService service = new ImportDossier();
        //    //Globale.Cas = Globale.CodeCas.copierDossier;
        //    cheminPlanches = service.setCheminImportation();
        //    if (cheminPlanches != "failed")
        //        LecturePlanches.CorrespondancePlanches(cheminPlanches, mode.classesNouvelleAnnee);
        //}

        private void btnPdfNormal_Click(object sender, EventArgs e)
        {
            mode mode = mode.classesNormales;
            importerPdf(mode);
        }

        private void btnImporterPDFnA_Click(object sender, EventArgs e)
        {
            mode mode = mode.classesNouvelleAnnee;
            importerPdf(mode);
        }

        private void importerPdf(mode mode)
        {
            I_ImportService service = new ImportPdf();
            Globale.CheminPdf = service.setCheminImportation();
            Globale.ListeCas.Clear();
            Globale.ListeCas.Add(Globale.CodeCas.extraitImagesTrombiPdf);
            if (Globale.CheminPdf != "failed")
            {
                frmChargement ch = new frmChargement();
                ch.ShowDialog();
                if (Globale.MessageFinFrmChargement != "")
                    MessageBox.Show(Globale.MessageFinFrmChargement);
                else
                    MessageBox.Show("Opération terminée !");
                frmSelectionZone zo = new frmSelectionZone(PdfGs.trombiOutputPath, mode, frmSelectionZone.documentType.pdf);
                zo.ShowDialog();
                if (zo.annulation)
                    return;
                List<Rectangle> rGrilles = zo.rGrilles;
                List<string> classes = zo.classes;
                List<int> numPages = zo.numPages;
                List<string> nomsFichiers = zo.nomFichiers;
                try
                {
                    for (int i = 0; i < nomsFichiers.Count; i++)
                    {
                        LecturePlanches.decouperPlanche(nomsFichiers[i], classes[i], numPages[i], mode, rGrilles[i]);
                    }
                    DialogResult res = DialogResult.None;
                    res = MessageBox.Show("Les photos ont été importées dans " + Chemin.DossierPhotoEleve + ".\n" +
                        "Voulez-vous ouvrir le dossier ?", "Terminé", MessageBoxButtons.YesNo);
                    if(res == DialogResult.Yes)
                        Process.Start(Chemin.DossierPhotoEleve);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }
        }

        private void importerJpeg(mode mode)
        {
            I_ImportService service = new ImportImg();
            string chemin = service.setCheminImportation();
            if (chemin != "failed")
            {
                try
                {
                    frmSelectionZone zo = new frmSelectionZone(chemin, mode, frmSelectionZone.documentType.jpeg);
                    zo.ShowDialog();
                    if (zo.annulation)
                        return;
                    List<Rectangle> rGrilles = zo.rGrilles;
                    List<string> classes = zo.classes;
                    List<int> numPages = zo.numPages;
                    List<string> nomsFichiers = zo.nomFichiers;
                    for (int i = 0; i < nomsFichiers.Count; i++)
                    {
                        LecturePlanches.decouperPlanche(nomsFichiers[i], classes[i], numPages[i], mode, rGrilles[i]);
                    }
                    DialogResult res = DialogResult.None;
                    res = MessageBox.Show("Les photos ont été importées dans " + Chemin.DossierPhotoEleve + ".\n" +
                        "Voulez-vous ouvrir le dossier ?", "Terminé", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                        Process.Start(Chemin.DossierPhotoEleve);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }
        }

        private void btnJpeg_Click(object sender, EventArgs e)
        {
            importerJpeg(mode.classesNormales);
        }

        private void btnJpegNA_Click(object sender, EventArgs e)
        {
            importerJpeg(mode.classesNouvelleAnnee);
        }
    }
}
