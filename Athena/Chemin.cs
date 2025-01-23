/**
 * Ce fichier contient la classe Chemin qui gère les chemins d'accès aux différents dossiers et fichiers utilisés dans l'application.
 * Il définit des propriétés statiques pour les chemins de données, de base de données, d'importation, etc.
 */

using System.IO;

namespace CartesAcces2024
{
    public static class Chemin
    {
        // Chemin par défaut pour le dossier de données
        public static string DossierData { get; set; } =  Directory.GetCurrentDirectory() + "/data/";
        // Chemin par défaut pour le dossier de base de données
        public static string DossierBdd { get; set; } = Directory.GetCurrentDirectory() + "/Database/";
        // Chemin vers la base de données
        public static string CheminBdd { get; set; } = DossierBdd + "myDatabase.db";
        // Chemin vers la liste des élèves à importer
        public static string CheminListeEleve { get; set; } = DossierData + "ImportListeEleve/ImportEleve.csv";
        // Dossier pour les listes d'élèves
        public static string DossierListeEleve { get; set; } = DossierData + "ImportListeEleve/";
        // Dossier pour les photos des élèves
        public static string DossierPhotoEleve { get; set; } = DossierData + "photoEleve/";
        // Dossier pour les emplois du temps classiques
        public static string DossierEdtClassique { get; set; } = DossierData + "FichierEdtClasse/";
        // Chemin vers un emploi du temps vierge
        public static string CheminEdtVierge { get; set; } = DossierData + "emploi_du_temps_vierge.png";
        // Dossier pour les cartes face
        public static string DossierCartesFace { get; set; } = DossierData + "FichierCartesFace/";

        // Chemin pour un emploi du temps personnel
        public static string CheminEdtPerso { get; set; } = "";

        // Chemin pour un emploi du temps
        public static string CheminEdt { get; set; } = "";

        // Chemin vers une image par défaut pour les cartes
        public static string CheminFaceDefault { get; set; } = DossierData + "default.png";
        // Chemin vers une image par défaut pour les photos
        public static string CheminPhotoDefault { get; set; } = DossierData + "edition.jpg";
        // Chemin vers le logo
        public static string CheminLogo { get; set; } = DossierData + "logo.png";
        // Dossier pour les trombinoscopes
        public static string DossierTrombi { get; set; } = DossierData + "planches/";
        // Dossier pour les trombinoscopes normaux
        public static string DossierTrombiNorm { get; set; } = DossierTrombi + "normales/";
        // Dossier pour les trombinoscopes de la nouvelle année
        public static string DossierTrombiNA { get; set; } = DossierTrombi + "nouvelleAnnee/";
        // Chemin vers un modèle de trombinoscope
        public static string CheminTrombiTemplate { get; set; } = DossierTrombi + "template.png";
        // Chemin vers un modèle de trombinoscope A3
        public static string CheminTrombiTemplateA3 { get; set; } = DossierTrombi + "templateA3.png";
        // Dossier pour la nouvelle année
        public static string DossierNouvelleAnnee { get; set; } = DossierData + "NouvelleAnnee/";
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