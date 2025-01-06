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

namespace CartesAcces2024
{
    public partial class frmMonterNiveau : Form
    {
        public frmMonterNiveau()
        {
            InitializeComponent();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 6; i >= 3; i--)
                {
                    if (!Directory.Exists(Chemin.DossierPhotoEleve + i.ToString() + "eme/"))
                        Directory.CreateDirectory(Chemin.DossierPhotoEleve + i.ToString() + "eme/");
                }
                List<Eleve> listEl = OperationsDb.GetEleve();
                int compteur = 0;
                foreach(Eleve el in listEl)
                {
                    if(el.NiveauEleve.Length == 0)
                    {
                        el.NiveauEleve = el.ClasseEleve[0] + "eme";
                    }
                    int i = 6;
                    bool quit = false;
                    while(i >= 3 && !quit)
                    {
                        string orig = Chemin.DossierPhotoEleve + i.ToString() + "eme/" + el.NomEleve + " " + el.PrenomEleve + ".jpg";
                        if (i.ToString() != el.NiveauEleve.Substring(0, 1) && File.Exists(orig))
                        {
                            string dest = Chemin.DossierPhotoEleve + el.NiveauEleve.Substring(0, 1) + "eme/" + el.NomEleve + " " + el.PrenomEleve + ".jpg";
                            File.Move(orig, dest);
                            quit = true;
                            compteur++;
                        }
                        i--;
                    }
                }
                MessageBox.Show(compteur + " élèves ont été mis à jours !");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
