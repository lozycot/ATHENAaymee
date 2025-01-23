using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace CartesAcces2024
{

    public partial class frmImport : Form
    {
        string date = DateTime.Now.ToString();

        public frmImport()
        {
            
            InitializeComponent();

            lblImportEdt.Text = OperationsDb.GetDates("DateEDT");
            //lblImportEleve.Text = OperationsDb.GetDates("DateEleve");
            lblImportPhotos.Text = OperationsDb.GetDates("DatePhoto");
        }

        private void btnEtab_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmEtablissement();
            Text = "CARTE D'ACCES - CARTE ETABLISSEMENT";
            Globale.Accueil.Invoke(new MethodInvoker(delegate {frmAccueil.OpenChildForm(Globale.Actuelle); }));
        }

        //private void btnEleve_Click(object sender, EventArgs e)
        //{
        //    OperationsDb.ImportCsv();
        //    if (Globale.CheminCsv != "failed")
        //    {
        //        lblImportEleve.Text = date;
        //        OperationsDb.ImportDates("DateEleve", date);
        //    }
        //}

        private void btnEdt_Click(object sender, EventArgs e)
        {
            Globale.CheminPdf = "";
            var frmSelectSection = new frmSelectionNiveauEdt();
            frmSelectSection.StartPosition = FormStartPosition.CenterScreen;
            frmSelectSection.Show();
            if (Globale.CheminPdf != "failed")
            {
                lblImportEdt.Text = date;
                OperationsDb.ImportDates("DateEDT", date);
            }
        }

        private void btnPhotos_Click(object sender, EventArgs e) { 

            var frmSelectSection = new frmSelectionNiveauPhoto();
            frmSelectSection.StartPosition = FormStartPosition.CenterScreen;
            frmSelectSection.ShowDialog();
            if (Globale.CheminPhoto != "failed")
            {
                lblImportPhotos.Text = date;
                OperationsDb.ImportDates("DatePhoto", date);
            }

        }

        private void btnFaceCartes_Click(object sender, EventArgs e)
        {
            I_ImportService service = new ImportDossier();
            Globale.Cas = Globale.CodeCas.copierDossier;
            Globale.CheminPhoto = service.setCheminImportation();
            // Définir le chemin de destination
            // Debug.Assert(Directory.GetCreationTime(Chemin.DossierCartesFace) == Directory.GetCreationTime("./data/FichierCartesFace"));
            Globale.CheminDestination = Chemin.DossierCartesFace;
            var frmWait = new frmChargement();
            frmWait.StartPosition = FormStartPosition.CenterScreen;
            frmWait.TopMost = true;
            frmWait.ShowDialog();
            if (Globale.MessageFinFrmChargement != "")
                MessageBox.Show(Globale.MessageFinFrmChargement);
            else
                MessageBox.Show("Opération terminée !");
            
        }

        private void btnImportPlanches_Click(object sender, EventArgs e)
        {
            Globale.Actuelle = new frmImportPlanches();
            Globale.Accueil.Invoke(new MethodInvoker(delegate { frmAccueil.OpenChildForm(Globale.Actuelle); }));
        }

        private void lblImportEleve_Click(object sender, EventArgs e)
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
