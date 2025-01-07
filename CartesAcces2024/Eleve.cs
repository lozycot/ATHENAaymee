/**
 * Ce fichier définit la classe Eleve qui représente un élève.
 * Elle contient des propriétés pour les informations de l'élève, y compris son nom, prénom, classe, et d'autres attributs.
 */

using System.Collections.Generic;
using System.IO;
using System.Linq;
using CartesAcces2024;

namespace CartesAcces2024
{
    /// <summary>
    /// Classe représentant un élève.
    /// </summary>
    public class Eleve
    {
        public enum profils
        {
            Defaut,
            Segpa,
            Allophone,
            Ulis,
            Bilingue
        }

        /// <summary>
        /// Constructeur par défaut pour initialiser un élève.
        /// </summary>
        public Eleve()
        {
            NumEleve = 0;
            NomEleve = "null";
            PrenomEleve = "null";
            ClasseEleve = "null";
            RegimeEleve = "null";
            OptionUnEleve = "null";
            OptionDeuxEleve = "null";
            OptionTroisEleve = "null";
            OptionQuatreEleve = "null";
            NiveauEleve = "null";
            MefEleve = "null";
            ProfilEleve = default;
            SansEdt = false;
        }

        public Eleve(string nom, string prenom)
        {
            NumEleve = 0;
            NomEleve = nom;
            PrenomEleve = prenom;
            ClasseEleve = "null";
            RegimeEleve = "null";
            OptionUnEleve = "null";
            OptionDeuxEleve = "null";
            OptionTroisEleve = "null";
            OptionQuatreEleve = "null";
            NiveauEleve = "null";
            MefEleve = "null";
            ProfilEleve = default;
            SansEdt = false;
        }

        public Eleve(string nom, string prenom, string classe, string niveau)
        {
            NumEleve = 0;
            NomEleve = nom;
            PrenomEleve = prenom;
            ClasseEleve = classe;
            RegimeEleve = "null";
            OptionUnEleve = "null";
            OptionDeuxEleve = "null";
            OptionTroisEleve = "null";
            OptionQuatreEleve = "null";
            NiveauEleve = niveau;
            MefEleve = "null";
            ProfilEleve = default;
            SansEdt = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public static List<string> ListeCleeEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        public profils ProfilEleve { get; set; }
        public int NumEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NomEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PrenomEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ClasseEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RegimeEleve { get; set; }

        public string NiveauEleve { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OptionUnEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OptionDeuxEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OptionTroisEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OptionQuatreEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MefEleve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool SansEdt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static void SetLesClasses()
        {
            foreach (var eleve in Globale.ListeEleve.Select(x => x.ClasseEleve))
            {
                var numClasse = eleve.Substring(0, 1);

                if (numClasse == "6" && !Globale.Classes6Eme.Contains(eleve))
                    Globale.Classes6Eme.Add(eleve);
                else if (numClasse == "5" && !Globale.Classes5Eme.Contains(eleve))
                    Globale.Classes5Eme.Add(eleve);
                else if (numClasse == "4" && !Globale.Classes4Eme.Contains(eleve))
                    Globale.Classes4Eme.Add(eleve);
                else if (numClasse == "3" && !Globale.Classes3Eme.Contains(eleve))
                    Globale.Classes3Eme.Add(eleve);
                else
                    Globale.ClassesInconnue.Add(eleve);
            }

            Globale.Classes3Eme.Sort();
            Globale.Classes4Eme.Sort();
            Globale.Classes5Eme.Sort();
            Globale.Classes6Eme.Sort();
        }

        /// <summary>
        /// Méthode pour créer une clé unique pour un élève.
        /// </summary>
        /// <param name="eleve">L'élève pour lequel créer la clé.</param>
        /// <returns>La clé unique sous forme de chaîne.</returns>
        public static string CreeCleEleve(Eleve eleve)
        {
            var cle = eleve.NomEleve + eleve.PrenomEleve + eleve.ClasseEleve;

            // Correction sur le régime
            if (eleve.RegimeEleve == "EXTERN")
                cle += "Externe";
            else if (eleve.RegimeEleve.Substring(0, 2) == "DP") cle += "12P";

            // Ajout des options
            cle += eleve.OptionUnEleve;
            if (eleve.OptionDeuxEleve != "") cle += eleve.OptionDeuxEleve;
            if (eleve.OptionTroisEleve != "") cle += eleve.OptionTroisEleve;
            if (eleve.OptionQuatreEleve != "") cle += eleve.OptionQuatreEleve;

            return cle;
        }

        /// <summary>
        /// Vérifie si les élèves possèdent un emploi du temps.
        /// </summary>
        /// <param name="listeEleve">Liste des élèves à vérifier.</param>
        public static void PossedeEdt(List<Eleve> listeEleve)
        {
            foreach (var eleve in listeEleve)
                if (!File.Exists(Chemin.DossierEdtClassique + eleve.NiveauEleve + "/" + eleve.NomEleve + " " + eleve.PrenomEleve + ".jpg"))
                    eleve.SansEdt = true;
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