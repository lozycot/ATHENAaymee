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

using System.IO;

namespace CartesAcces2024
{
    public static class Chemin
    {
        public static string DossierData { get; set; } =  Directory.GetCurrentDirectory() + "/data/";
        public static string DossierBdd { get; set; } = Directory.GetCurrentDirectory() + "/Database/";
        public static string CheminBdd { get; set; } = DossierBdd + "myDatabase.db";
        public static string CheminListeEleve { get; set; } = DossierData + "ImportListeEleve/ImportEleve.csv";
        public static string DossierListeEleve { get; set; } = DossierData + "ImportListeEleve/";
        public static string DossierPhotoEleve { get; set; } = DossierData + "photoEleve/";
        public static string DossierEdtClassique { get; set; } = DossierData + "FichierEdtClasse/";
        public static string CheminEdtVierge { get; set; } = DossierData + "emploi_du_temps_vierge.png";
        public static string DossierCartesFace { get; set; } = DossierData + "FichierCartesFace/";

        public static string CheminEdtPerso { get; set; } = "";

        public static string CheminEdt { get; set; } = "";

        public static string CheminFaceDefault { get; set; } = DossierData + "default.png";
        public static string CheminPhotoDefault { get; set; } = DossierData + "edition.jpg";
        public static string CheminLogo { get; set; } = DossierData + "logo.png";
        public static string DossierTrombi { get; set; } = DossierData + "planches/";
        public static string DossierTrombiNorm { get; set; } = DossierTrombi + "normales/";
        public static string DossierTrombiNA { get; set; } = DossierTrombi + "nouvelleAnnee/";
        public static string CheminTrombiTemplate { get; set; } = DossierTrombi + "template.png";
        public static string CheminTrombiTemplateA3 { get; set; } = DossierTrombi + "templateA3.png";
        public static string DossierNouvelleAnnee { get; set; } = DossierData + "NouvelleAnnee/";
    }
}