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
    public partial class frmSelectionNiveauEdt : Form
    {
        /// <summary>
        /// Utilisez les paramètres pour cacher certains radiobuttons.a
        /// </summary>
        /// <param name="sixiemeVisible"></param>
        /// <param name="cinqemeVisible"></param>
        /// <param name="quatriemeVisible"></param>
        /// <param name="troisiemeVisible"></param>
        /// <param name="classeUniquementVisible"></param>
        /// <param name="ttLesElevesVisible"></param>
        public frmSelectionNiveauEdt(bool sixiemeVisible = true, bool cinqemeVisible = true, bool quatriemeVisible = true, bool troisiemeVisible = true, bool classeUniquementVisible = true, bool ttLesElevesVisible = true)
        {
            InitializeComponent();
            rdb6eme.Visible = sixiemeVisible;
            rdb5eme.Visible = cinqemeVisible;
            rdb4eme.Visible = quatriemeVisible;
            rdb3eme.Visible = troisiemeVisible;
            rdbClasses.Visible = classeUniquementVisible;
            rdbTousEleves.Visible = ttLesElevesVisible;

            //bool temp = false;
            //int i = 0;
            //while (temp==false)
            //{
            //    if (this.Controls.OfType<RadioButton>().ToList<RadioButton>()[i].Visible == true)
            //    {
            //        temp = true;
            //        this.Controls.OfType<RadioButton>().ToList<RadioButton>()[i].Checked = true;
            //    }
            //    else
            //    {
            //        this.Controls.OfType<RadioButton>().ToList<RadioButton>()[i].Checked = false;
            //    }
            //    i++;
            //}
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool classeChecked = true;

            if (rdb3eme.Checked)
            {
                Globale.Classe = 3;
            }

            else if (rdb4eme.Checked)
            {
                Globale.Classe = 4;
            }

            else if (rdb5eme.Checked)
            {
                Globale.Classe = 5;
            }

            else if (rdb6eme.Checked)
            {
                Globale.Classe = 6;
            }

            else if (rdbClasses.Checked)
            {
                Globale.Classe = 7;
            }

            else if (rdbTousEleves.Checked)
            {
                Globale.Classe = 8;
            }

            else
            {
                classeChecked = false;
            }

            if(classeChecked)
            {
                if (Globale.Classe == 7)
                    PdfGs.ImporterEdtClassesUniquement();
                else
                    PdfGs.ImporterEdtUnNiveau();
                Close();
            }
            else
                MessageBox.Show("Veuillez selectionner une section");

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
