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
