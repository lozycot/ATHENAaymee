/**
 * Ce fichier contient la classe TailleControle qui définit la taille des contrôles dans l'application.
 * Elle inclut des méthodes pour ajuster la taille des TextBox, Label, et Button.
 */

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CartesAcces2024
{
    /// <summary>
    /// Classe permettant de définir la taille des contrôles.
    /// </summary>
    public static class TailleControle
    {
        /// <summary>
        /// Cette fonction permet de définir la taille des contrôles de type TextBox.
        /// </summary>
        /// <param name="form">La fenêtre contenant les contrôles.</param>
        public static void SetTailleControleTexte(Form form)
        {
            var policeParDefault = new Font("Microsoft Sans Serif", 10);

            var controlsList = new List<Control>();
            foreach (Control controle in form.Controls) controlsList.Add(controle);
            foreach (var controle in controlsList.Where(x => x is TextBox))
            {
                var controle2 = controle as TextBox; // indique que ce contrôle est de type
                if (controle2 != null)
                {
                    controle2.MinimumSize = new Size(150, 20); // application des modifications sur le type choisi
                    controle2.Font = policeParDefault;
                }
            }
        }

        /// <summary>
        /// Cette fonction permet de définir la taille des contrôles de type Label.
        /// </summary>
        /// <param name="form">La fenêtre contenant les contrôles.</param>
        public static void SetTailleControleLabel(Form form)
        {
            var policeParDefault = new Font("Microsoft Sans Serif", 10);

            var controlsList = new List<Control>();
            foreach (Control controle in form.Controls) controlsList.Add(controle);
            foreach (var controle in controlsList.Where(x => x is Label))
            {
                var controle2 = controle as Label;
                if (controle2 != null) controle2.Font = policeParDefault;
            }
        }

        /// <summary>
        /// Cette fonction permet de définir la taille des contrôles de type Button.
        /// </summary>
        /// <param name="form">La fenêtre contenant les contrôles.</param>
        public static void SetTailleBouton(Form form)
        {
            var policeParDefault = new Font("Microsoft Sans Serif", 10);

            var controlsList = new List<Control>();
            foreach (Control controle in form.Controls) controlsList.Add(controle);
            foreach (var controle in controlsList.Where(x => x is Button))
            {
                var controle2 = controle as Button; // indique que ce contrôle est de type
                if (controle2 != null)
                {
                    controle2.Font = policeParDefault; // application des modifications sur le type choisi
                    controle2.Size = new Size(330, 29);
                    controle2.AutoSize = false;
                }
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
 */
 