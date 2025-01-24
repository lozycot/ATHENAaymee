/**
 * Ce fichier contient la classe ImportCsv qui permet à l'utilisateur de sélectionner un fichier CSV à importer.
 * Elle implémente l'interface I_ImportService.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesAcces2024
{
    // -- Permet à l'utilisateur de donner le chemin du fichier CSV à importer --
    public class ImportCsv : I_ImportService
    {
        /// <summary>
        /// Ouvre un dialogue pour sélectionner un fichier CSV.
        /// </summary>
        /// <returns>Le chemin du fichier sélectionné ou "failed" en cas d'échec.</returns>
        string I_ImportService.setCheminImportation()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files Only | *.csv";
                ofd.Title = "Choose the File";
                if (ofd.ShowDialog() == DialogResult.OK) return ofd.FileName;
                return "failed";
            }
        }

        /// <summary>
        /// Ouvre un dialogue pour sélectionner un fichier CSV avec un titre personnalisé.
        /// </summary>
        /// <param name="title">Titre du dialogue d'ouverture de fichier.</param>
        /// <returns>Le chemin du fichier sélectionné ou "failed" en cas d'échec.</returns>
        string I_ImportService.setCheminImportation(string title)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files Only | *.csv";
                ofd.Title = title;
                if (ofd.ShowDialog() == DialogResult.OK) return ofd.FileName;
                return "failed";
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
