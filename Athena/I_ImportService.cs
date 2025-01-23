/**
 * Ce fichier définit l'interface I_ImportService qui spécifie les méthodes pour gérer les importations de fichiers.
 * Elle inclut des méthodes pour définir le chemin d'importation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesAcces2024
{
    // Interface pour les Imports
    interface I_ImportService
    {
        /// <summary>
        /// Définit le chemin d'importation.
        /// </summary>
        /// <returns>Le chemin d'importation sous forme de chaîne.</returns>
        string setCheminImportation();

        /// <summary>
        /// Définit le chemin d'importation avec un titre personnalisé.
        /// </summary>
        /// <param name="title">Titre du dialogue d'ouverture de fichier.</param>
        /// <returns>Le chemin d'importation sous forme de chaîne.</returns>
        string setCheminImportation(string title);
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
