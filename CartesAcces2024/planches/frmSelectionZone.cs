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
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CartesAcces2024
{
    /// <summary>
    /// Fenêtre permettant de recadrer le scan de trombinoscope effectué. Nécéssaire car on ne peut pas savoir 
    /// quelle sera la résolution de l'image, si les marges seront bien respectées, etc.
    /// </summary>
    public partial class frmSelectionZone : Form
    {
        private List<string> aTraiter = new List<string>();
        private RotateFlipType rotation = RotateFlipType.RotateNoneFlipNone;

        public static Brush pinceauRouge = new SolidBrush(Color.Red);
        public static Brush noirTransparent = new SolidBrush(Color.FromArgb(127, Color.Black));
        
        // Les positions des marges pour qu'on puisse les récupérer à la fermeture du formulaire
        public int margeH = 0;
        public int margeB = 0;
        public int margeG = 0;
        public int margeD = 0;
        public Rectangle rGrille = new Rectangle(0,0,0,0); // utilisé pour l'import de pages individuelles 
        
        // utilisé pour l'import d'un pdf avec plusieurs pages :
        public List<Rectangle> rGrilles = new List<Rectangle>();
        public List<string> classes = new List<string>();
        public List<int> numPages = new List<int>();
        public List<string> nomFichiers = new List<string>();

        // permet de savoir si on a cliqué sur annuler
        public bool annulation = false;

        public enum documentType
        {
            jpeg,
            pdf
        }

        public static documentType docType = documentType.jpeg;

        private void initMarges()
        {
            // Dimentionnement des picturebox en fct de l'image importée
            pbDoc.MaximumSize = pbDoc.Image.Size;
            pbDoc.Size = pbDoc.Image.Size;


            // nouvelle image transparente
            if (pbOver.Image != null)
                pbOver.Image.Dispose();
            pbOver.Image = new Bitmap(pbDoc.Image.Size.Width, pbDoc.Image.Size.Height, PixelFormat.Format32bppArgb);
            pbOver.MaximumSize = pbDoc.Image.Size;
            pbOver.Size = pbDoc.Image.Size;

            // marges par défaut, correspondent à un scan de 150ppp où les marges sont respectées
            if(margeH == 0 && margeB == 0 && margeG == 0 && margeD == 0)
            {
                margeH = 29;
                numH.Value = margeH;
                margeB = 36;
                numB.Value = margeB;
                margeG = 50;
                numG.Value = margeG;
                margeD = 59;
                numD.Value = margeD;
            }

            // dessine les traits des marges et actualise les valeurs
            drawlines();
            updateZoom();
        }

        private void initElements()
        {
            try
            {
                pbDoc.Image = new Bitmap(aTraiter[0]);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur : " + err.Message);
                annulation = true;
                Close();
                return;
            }

            rotate();
            initMarges();

            cbClasse.SelectedItem = "CLASSES";
            numPage.Value = 0;
            btnValider.Enabled = false;
        }

        private void initialisationPdf(frmImportPlanches.mode mode, string path)
        {
            List<string> ttClasses = null;
            switch (mode)
            {
                case frmImportPlanches.mode.classesNormales:
                    ttClasses = OperationsDb.GetClasses();
                    break;
                case frmImportPlanches.mode.classesNouvelleAnnee:
                    ttClasses = OperationsDb.GetClassesNouvelleAnnee();
                    break;
            }

            cbClasse.Items.Add("CLASSE");
            foreach (string cl in ttClasses)
            {
                cbClasse.Items.Add(cl);
            }

            cbClasse.SelectedItem = "CLASSE";

            btnValider.Enabled = false;

            pbDoc.Controls.Add(pbOver);
            pbOver.BackColor = Color.Transparent;

            string[] fichiers = Directory.GetFiles(path, "*.jpg");

            if (aTraiter.Count > 0)
            {
                aTraiter.Clear();
                aTraiter = new List<string>();
            }
            foreach (string f in fichiers)
            {
                aTraiter.Add(f);
                nomFichiers.Add(f);
            }

            if (aTraiter.Count > 0)
                initElements();
            else
                Close();

            // activé dans le mode plusieurs pages
            cbClasse.Enabled = true;
            cbClasse.Visible = true;
            numPage.Enabled = true;
            numPage.Visible = true;
        }

        private void initialisationJpeg(frmImportPlanches.mode mode, string path)
        {
            List<string> ttClasses = null;
            switch (mode)
            {
                case frmImportPlanches.mode.classesNormales:
                    ttClasses = OperationsDb.GetClasses();
                    break;
                case frmImportPlanches.mode.classesNouvelleAnnee:
                    ttClasses = OperationsDb.GetClassesNouvelleAnnee();
                    break;
            }

            cbClasse.Items.Add("CLASSE");
            foreach (string cl in ttClasses)
            {
                cbClasse.Items.Add(cl);
            }

            cbClasse.SelectedItem = "CLASSE";

            btnValider.Enabled = false;

            pbDoc.Controls.Add(pbOver);
            pbOver.BackColor = Color.Transparent;

            if (aTraiter.Count > 0)
            {
                aTraiter.Clear();
                aTraiter = new List<string>();
            }

            nomFichiers.Add(path);
            aTraiter.Add(path);

            if (aTraiter.Count > 0)
                initElements();
            else
                Close();

            cbClasse.Enabled = true;
            cbClasse.Visible = true;
            numPage.Enabled = true;
            numPage.Visible = true;
            btnSupprPage.Enabled = false;
        }

        public frmSelectionZone(string path, frmImportPlanches.mode mode, documentType doctype)
        {
            // pbDoc : l'image du document
            // pbOver : la picturebox contenant les traits rouges et rectangles semi transparents qui indiquent les marges

            InitializeComponent();

            annulation = false;
            docType = doctype;

            if(docType == documentType.pdf)
            {
                initialisationPdf(mode, path);
            }
            else
            {
                initialisationJpeg(mode, path);
            }
        }

        private void frmSelectionZone_FormClosed(object sender, FormClosedEventArgs e)
        {
            // libère les ressources
            if (null != pbDoc.Image)
                pbDoc.Image.Dispose();
            if (null != pbOver.Image)
                pbOver.Image.Dispose();
        }

        /// <summary>
        /// Calcule et dessine les marges. Met à jour les attributs publics et les valeurs limites des numericUpDown.
        /// </summary>
        private void drawlines()
        {
            int w = pbOver.MaximumSize.Width;
            int h = pbOver.MaximumSize.Height;

            // calcul et dessin des marges
            Pen p = new Pen(pinceauRouge, 2);
            using (Graphics graph = Graphics.FromImage(pbOver.Image))
            {
                graph.Clear(Color.Transparent);

                // haut
                graph.FillRectangle(noirTransparent, new Rectangle(0, 0, w, (int)numH.Value));
                graph.DrawLine(p, 0, (int)numH.Value, w, (int)numH.Value);

                // bas
                graph.FillRectangle(noirTransparent, new Rectangle(0, h - (int)numB.Value, w, (int)numB.Value));
                graph.DrawLine(p, 0, h - (int)numB.Value, w, h - (int)numB.Value);

                // gauche
                graph.FillRectangle(noirTransparent, new Rectangle(0, 0, (int)numG.Value, h));
                graph.DrawLine(p, (int)numG.Value, 0, (int)numG.Value, h);

                // droite
                graph.FillRectangle(noirTransparent, new Rectangle(w - (int)numD.Value, 0, (int)numD.Value, h));
                graph.DrawLine(p, w - (int)numD.Value, 0, w - (int)numD.Value, h);
            }
            pbOver.Refresh();
            rGrille = new Rectangle(margeG, margeH, w - margeG - margeD, h - margeH - margeB);

            // mise à jour des valeurs maximales pour éviter que des marges ne se dépassent ce qui crééerait des erreurs
            numH.Maximum = h - numB.Value;
            numB.Maximum = h - numH.Value;
            numG.Maximum = w - numD.Value;
            numD.Maximum = w - numG.Value;
        }

        private void numG_ValueChanged(object sender, EventArgs e)
        {
            margeG = (int)numG.Value;
            drawlines();
        }

        private void numH_ValueChanged(object sender, EventArgs e)
        {
            margeH = (int)numH.Value;
            drawlines();
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            margeB = (int)numB.Value;
            drawlines();
        }

        private void numD_ValueChanged(object sender, EventArgs e)
        {
            margeD = (int)numD.Value;
            drawlines();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            annulation = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //if(docType == documentType.pdf)
            //{
            rGrilles.Add(rGrille);
            classes.Add(cbClasse.SelectedItem.ToString());
            numPages.Add((int)numPage.Value);
            //}
            
            if (aTraiter.Count <= 1)
            {
                Close();
                return;
            }
            else
            {
                if (pbDoc.Image != null)
                    pbDoc.Image.Dispose();
                aTraiter.RemoveAt(0);
                initElements();
            }
        }

        private void btnHoraire_Click(object sender, EventArgs e)
        {
            RotateFlipType old = rotation;
            rotation = RotateFlipType.Rotate90FlipNone;
            rotate();
            initMarges();

            // appliquer la bonne rotation aux pages suivantes si
            // plusieurs rotations successives ont été effectuées
            switch(old)
            {
                case RotateFlipType.Rotate90FlipNone:
                    rotation = RotateFlipType.Rotate180FlipNone;
                    break;
                case RotateFlipType.Rotate180FlipNone:
                    rotation = RotateFlipType.Rotate270FlipNone;
                    break;
                case RotateFlipType.Rotate270FlipNone:
                    rotation = RotateFlipType.RotateNoneFlipNone;
                    break;
            }
        }

        private void btnAntihoraire_Click(object sender, EventArgs e)
        {
            RotateFlipType old = rotation;
            rotation = RotateFlipType.Rotate270FlipNone;
            rotate();
            initMarges();

            // appliquer la bonne rotation aux pages suivantes si
            // plusieurs rotations successives ont été effectuées
            switch (old)
            {
                case RotateFlipType.Rotate90FlipNone:
                    rotation = RotateFlipType.RotateNoneFlipNone;
                    break;
                case RotateFlipType.Rotate180FlipNone:
                    rotation = RotateFlipType.Rotate90FlipNone;
                    break;
                case RotateFlipType.Rotate270FlipNone:
                    rotation = RotateFlipType.Rotate180FlipNone;
                    break;
            }
        }

        private void rotate()
        {
            try
            {
                pbDoc.Image.RotateFlip(rotation);
                string tempName = aTraiter[0];
                // on enlève l'extension
                int index = tempName.LastIndexOf('.');
                if(index != -1)
                    tempName = tempName.Substring(0, index);
                tempName += "rotated.jpg";
                pbDoc.Image.Save(tempName, ImageFormat.Jpeg);
                if (pbDoc.Image != null)
                    pbDoc.Image.Dispose();
                File.Delete(aTraiter[0]);
                File.Move(tempName, aTraiter[0]);
                pbDoc.Image = new Bitmap(aTraiter[0]);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur : " + err.Message);
                Close();
                return;
            }
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClasse.SelectedItem.ToString() != "CLASSE" && numPage.Value != 0)
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void numPage_ValueChanged(object sender, EventArgs e)
        {
            if (cbClasse.SelectedItem.ToString() != "CLASSE" && numPage.Value != 0)
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void btnSupprPage_Click(object sender, EventArgs e)
        {
            if (pbDoc.Image != null)
                pbDoc.Image.Dispose();
            File.Delete(aTraiter[0]);
            nomFichiers.Remove(aTraiter[0]);
            if (aTraiter.Count <= 1)
            {
                Close();
                return;
            }
            else
            {
                aTraiter.RemoveAt(0);
                initElements();
            }
        }

        private void numZoom_ValueChanged(object sender, EventArgs e)
        {
            updateZoom();
        }

        private void updateZoom()
        {
            pbDoc.Size = new Size((int)(pbDoc.MaximumSize.Width * ((float)tkbZoom.Value / 100.0)),
                (int)(pbDoc.MaximumSize.Height * ((float)tkbZoom.Value / 100.0)));
            pbDoc.Refresh();
            pbOver.Size = new Size((int)(pbOver.MaximumSize.Width * ((float)tkbZoom.Value / 100.0)),
                (int)(pbOver.MaximumSize.Height * ((float)tkbZoom.Value / 100.0)));
            pbOver.Refresh();

        }

        private void tkbTaillePhoto_Scroll(object sender, EventArgs e)
        {
            updateZoom();
        }
    }
}
