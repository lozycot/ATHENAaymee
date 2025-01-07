/**
 * Ce fichier contient la classe XTrie qui permet de rechercher des élèves dans une liste.
 * Elle inclut une méthode pour filtrer les élèves en fonction d'un critère de recherche.
 */

using System.Collections.Generic;
using System.Text.RegularExpressions;
using CartesAcces2024;

namespace CarteAcces2024
{
    public static class XTrie
    {
        /// <summary>
        /// Recherche un élève dans la liste des élèves en fonction d'un filtre.
        /// </summary>
        /// <param name="filtre">Le filtre de recherche.</param>
        /// <param name="eleves">La liste des élèves à filtrer.</param>
        /// <returns>Une liste de chaînes contenant les résultats de la recherche.</returns>
        public static List<string> Recherche(string filtre, List<Eleve> eleves)
        {
            var listeEleveResultat = new List<string>();
            var regex = new Regex(filtre.ToLower());
            foreach (var eleve in eleves)
            {
                var nomPrenom = eleve.NomEleve + " " + eleve.PrenomEleve;
                nomPrenom = nomPrenom.ToLower();
                var match = regex.Match(nomPrenom);
                if (match.Success)
                    listeEleveResultat.Add(eleve.NomEleve + " " + eleve.PrenomEleve + " " + eleve.ClasseEleve);
            }

            return listeEleveResultat;
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
 