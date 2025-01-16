using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CartesAcces2024
{
    public partial class frmChargement : Form
    {
        public frmChargement()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (Globale.ListeCas.Count > 0)
                Globale.Cas = Globale.ListeCas[0];
            updateLabel();
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Globale.MessageFinFrmChargement = "";
        }

        /// <summary>
        /// Permet de modifier le message en dehors de la classe
        /// </summary>
        /// <param name="s"></param>
        public void updateLabel(string s)
        {
            lblChargement.Text = s;
        }

        public void updateLabel()
        {
            switch (Globale.Cas)
            {
                case Globale.CodeCas.insertElevesBdd:
                case Globale.CodeCas.insertElevesNouvelleAnneeBdd:
                    lblChargement.Text = "Enregistrement des élèves, veuillez patienter...";
                    break;
                case Globale.CodeCas.extraitImagesEdt:
                    lblChargement.Text = "Extraction des emplois du temps, veuillez patienter...";
                    break;
                case Globale.CodeCas.enregistreCarte:
                    lblChargement.Text = "Enregistrement des cartes, veuillez patienter...";
                    break;
                case Globale.CodeCas.extraitTextePdf:
                    lblChargement.Text = "Extraction du texte depuis les emplois du temps, veuillez patienter...";
                    break;
                case Globale.CodeCas.copierImage:
                case Globale.CodeCas.copierImageRenommage:
                case Globale.CodeCas.copierImageDossier:
                case Globale.CodeCas.copierDossier:
                    lblChargement.Text = "Importation des images , veuillez patienter...";
                    break;
                case Globale.CodeCas.sauvegarderPlanchesPdf:
                    lblChargement.Text = "Enregistrement du fichier, veuillez patienter...";
                    break;
                case Globale.CodeCas.extraitImagesTrombiPdf:
                    lblChargement.Text = "Extraction des pages du trombinoscope, veuillez patienter...";
                    break;
            }
        }

        private void frmChargement_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
                StartPosition = FormStartPosition.CenterScreen;
                TopMost = true;
                Globale.ActionEnCours = true;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            switch(Globale.Cas)
            {
                case Globale.CodeCas.insertElevesBdd:
                    OperationsDb.InsertElevesDansBdd(worker);
                    Globale.ListeEleve = OperationsDb.GetEleve();
                    break;
                case Globale.CodeCas.insertElevesNouvelleAnneeBdd:
                    OperationsDb.InsertElevesNouvelleAnneeDansBdd(worker);
                    Globale.ListeEleve = OperationsDb.GetEleve();
                    break;
                case Globale.CodeCas.extraitTextePdf:
                    Globale.txtPdf = PdfGs.GetTextePdf(Globale.CheminPdf, worker);
                    break;
                case Globale.CodeCas.extraitImagesEdt:
                    PdfGs.GetImageFromPdf(Globale.CheminPdf, Globale.Classe, worker);
                    break;
                case Globale.CodeCas.extraitImagesTrombiPdf:
                    PdfGs.GetImageTrombiFromPdf(Globale.CheminPdf, worker);
                    break;
                //case Globale.CodeCas.enregistreCarte:
                //    break;
                case Globale.CodeCas.setLesElevesPdfUDT:
                    PdfGs.SetLesElevesUDT(Globale.txtPdf);
                    break;
                case Globale.CodeCas.setLesClassesPdfUDT:
                    PdfGs.SetLesClassesUDT(Globale.txtPdf);
                    break;
                case Globale.CodeCas.setLesElevesPdfIE:
                    PdfGs.SetLesElevesIE(Globale.txtPdf);
                    break;
                case Globale.CodeCas.setLesClassesPdfIE:
                    PdfGs.SetLesClassesIE(Globale.txtPdf);
                    break;
                case Globale.CodeCas.copierImageDossier:
                    // Appeler la fonction pour copier les images
                    CopieImage.CopierImagesDossier(Globale.CheminPhoto, Globale.CheminDestination, worker);
                    break;
                case Globale.CodeCas.copierDossier:
                    CopieImage.CopieDossier(Globale.CheminPhoto, Globale.CheminDestination, worker);
                    break;
                case Globale.CodeCas.copierImage:
                    // Appeler la fonction pour copier les images
                    CopieImage.CopierImage(Globale.CheminPhoto, Globale.CheminDestination, worker);
                    break;
                case Globale.CodeCas.copierImageRenommage:
                    // Appeler la fonction pour copier les images puis les renomme
                    CopieImage.CopierImage(Globale.CheminPhoto, Globale.CheminDestination, worker,Globale.NomEleve,Globale.PrenomEleve);
                    break;
                case Globale.CodeCas.sauvegarderPlanchesPdf:
                    FichierWord.SauvegarderPlanche(Globale.NomsFichiersPlanches, Globale.DossierPlanches, worker, frmPlanches.format);
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblPourcentage.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Globale.CheminPdf == "failed")
            {
                MessageBox.Show("Import annulé");
                Globale.ActionEnCours = false;
                Close();
                Globale.wokerFinished = false;
            }
            else
            {
                progressBar1.Value = 0;
                lblPourcentage.Text = "0%";
                //switch (Globale.Cas)
                //{
                //    case Globale.CodeCas.insertElevesBdd:
                //        break;
                //    case Globale.CodeCas.extraitImagesEdt:
                //        break;
                //    case Globale.CodeCas.enregistreCarte:
                //        break;
                //    case Globale.CodeCas.extraitTextePdf:
                //        break;
                //}
                if (Globale.ListeCas.Count > 1)
                {
                    Globale.ListeCas.RemoveAt(0);
                    Globale.Cas = Globale.ListeCas[0];
                    backgroundWorker1.RunWorkerAsync();
                    updateLabel();
                    Globale.wokerFinished = false;
                }
                else
                {
                    Globale.ActionEnCours = false;
                    Globale.ListeCas.Clear();
                    Close();
                    Globale.wokerFinished = true;
                }
            }
        }

        private void frmChargement_formClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

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
