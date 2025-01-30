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
using System.Drawing;
using System.Windows.Forms;

namespace CartesAcces2024
{
    public static class Globale
    {
        
        public static string outputPath { get; set; } = "";
        public static bool wokerFinished { get; set; }
        public static string cheminImpressionFinal { get; set; }

        public const string nom6emeSansClasse = "6emeAZ";
        public static string CheminEleve { get; set; }
        public static LogicielsEdt LogicielEdt { get; set; } = LogicielsEdt.UnDeuxTemps;
        public static bool InfosCarte { get; set; } = true;
        public static string CheminCsv { get; set; }
        public static List<Classe> ListClasses { get; set; }
        public static bool EleveImpr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool TestBordure = true;

        /// <summary>
        /// 
        /// </summary>
        public static bool PositionPhotoClassique { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static readonly string Owner = "ValgulNecron"; // nom du propriétaire du dépôt GitHub
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Repo = "appStage"; // nom du dépôt GitHub
        /// <summary>
        /// 
        /// </summary>
        public static readonly string FileName = "Release.zip"; // nom du fichier de la dernière version


        /// <summary>
        /// 
        /// </summary>
        public static Label LblDate { get; set; }
        /// <summary>
        ///  Compteur pour suivre la progression des impression dans FichierWord.cs.
        /// </summary>
        public static Label LblCount { get; set; }
        /// <summary>
        /// Bar de progression pour suivre la progression des impression dans FichierWord.cs.
        /// </summary>
        public static ProgressBar pgbCount { get; set; }

        /// <summary>
        /// Utilisé pour frmChargement,
        /// sert à savoir quelle action d'importation on est en train de faire
        /// </summary>
        public static CodeCas Cas { get; set; } = 0;

        public enum CodeCas
        {
            insertElevesBdd,
            insertElevesNouvelleAnneeBdd,
            extraitImagesEdt,
            extraitImagesTrombiPdf,
            extraitTextePdf,
            copierImageRenommage,
            copierImage,
            copierDossier,
            copierImageDossier,
            enregistreCarte,
            setLesElevesPdfUDT,
            setLesClassesPdfUDT,
            setLesElevesPdfIE,
            setLesClassesPdfIE,
            ajoutEdt,
            sauvegarderPlanchesPdf,
            selectionZone,
            genererCodesBarres,
            sauvegarderCodesBarres
        };

        public static List<string> NomsFichiersPlanches { get; set; }

        public static string DossierPlanches { get; set; } = "";

        /// <summary>
        /// Permet de définir un enchaînement de Cas à réaliser
        /// </summary>
        public static List<CodeCas> ListeCas { get; set; } = new List<CodeCas>();

        /// <summary>
        /// 
        /// </summary>
        public static string txtPdf { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        public static int Classe { get; set; } = 6;

        /// <summary>
        /// 
        /// </summary>
        public static bool EstUnDossier { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        public static Form Connexion { get; set; }

        /// <summary>
        /// 
        /// </summary>

        // connexion
        /// <summary>
        /// 
        /// </summary>
        public static bool EstConnecte { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public static string NomUtilisateur { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        public static string NomEleve { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        public static string PrenomEleve { get; set; } = "";

        // Listes des classes 
        /// <summary>
        /// 
        /// </summary>
        public static List<string> Classes6Eme { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public static List<string> Classes5Eme { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public static List<string> Classes4Eme { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public static List<string> Classes3Eme { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public static List<string> ClassesInconnue { get; set; } = new List<string>();

        // Liste d'élèves
        /// <summary>
        /// 
        /// </summary>
        public static List<Eleve> ListeEleve { get; set; } = new List<Eleve>();

        public static List<string> ListeClasses { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public static List<Eleve> ListeEleveImpr { get; set; } = new List<Eleve>();
        /// <summary>
        /// 
        /// </summary>
        public static List<string> ListeEleveSansPhoto { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public static List<string> ListeElevesString { get; set; } = new List<string>();

        // theme 
        /// <summary>
        /// 
        /// </summary>
        public static bool EstEnModeSombre { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurDeFondClaire { get; } = new List<int> { 245, 252, 255 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurDuTexteclaire { get; } = new List<int> { 31, 33, 48 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurBandeauxClaire { get; } = new List<int> { 138, 138, 236 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurBoutonsClaire { get; } = new List<int> { 197, 210, 243 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurTextBoxClaire { get; } = new List<int> { 230, 232, 245 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurBoutonOffClaire { get; } = new List<int> { 140, 143, 161 };

        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurDeFondSombre { get; } = new List<int> { 108, 112, 134 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurDuTexteSombre { get; } = new List<int> { 205, 214, 244 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurBandeauxSombre { get; } = new List<int> { 53, 54, 58 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurBoutonsSombre { get; } = new List<int> { 88, 91, 112 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurTextBoxSombre { get; } = new List<int> { 127, 132, 156 };
        /// <summary>
        /// 
        /// </summary>
        public static List<int> CouleurBoutonOffSombre { get; } = new List<int> { 69, 71, 90 };


        // variable lier au forme utiliser pour garder une reference 
        /// <summary>
        /// 
        /// </summary>
        public static Form Actuelle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static Form Accueil { get; set; }

        // version
        /// <summary>
        /// 
        /// </summary>
        public static string Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static string VersionDate { get; set; }


        // variable lier au bar de progres
        /// <summary>
        /// 
        /// </summary>
        public static string CheminTexte { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static string CheminPdf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static string CheminPhoto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static string CheminEdtClassique { get; set; }
        /// <summary>
        ///     
        /// </summary>
        public static string CheminFaceCarte { get; set; }

        public static string CheminDestination { get; set; } = "";

        /// <summary>
        /// Si la GitPoule est activé
        /// </summary>
        public static bool GitPoule { get; set; } = true;

        // carte provisoire 
        /// <summary>
        ///    PictureBox
        /// </summary>
        public static PictureBox PbPhoto { get; set; }

        /// <summary>
        ///  tuple de sauvegarde provisoire
        /// </summary>
        public static Tuple<PictureBox, PictureBox, PictureBox, TextBox, TextBox> ListeSauvegardeProvisoire
        {
            get;
            set;
        }

        // liste d'eleve trier
        /// <summary>
        ///     Liste des élèves de la 6eme
        /// </summary>
        public static List<Eleve> ListeEleves6Eme { get; set; }
        /// <summary>
        ///   Liste des élèves de la 5eme
        /// </summary>
        public static List<Eleve> ListeEleves5Eme { get; set; }
        /// <summary>
        ///   Liste des élèves de la 4eme
        /// </summary>
        public static List<Eleve> ListeEleves4Eme { get; set; }
        /// <summary>
        ///    Liste des élèves de la 3eme
        /// </summary>
        public static List<Eleve> ListeEleves3Eme { get; set; }

        /// <summary>
        ///     Le mot de passe de chiffrement
        /// </summary>
        public static string MotsDePasseChifffrement { get; set; } = "";

        /// <summary>
        ///     Si le mot de passe doit etre changer
        /// </summary>
        public static bool ChangementMotDePasseChiffrement { get; set; } = false;

        /// <summary>
        ///     si la connection a la base de donnée est etablie
        /// </summary>
        public static bool ConnectionBdd { get; set; } = false;

        /// <summary>
        /// Pour empêcher deux tâches de s'exécuter en même temps (frmChargement)
        /// </summary>
        public static bool ActionEnCours { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        public enum LogicielsEdt
        {
            UnDeuxTemps,
            IndexEducation
        }

        public static string MessageFinFrmChargement { get; set; } = "";
        // indique si une opération a fonctionné correctement dans le frmChargement. Utilisé pour savoir si
        // on peut proposer à l'utilisateur d'ouvrir le dossier d'importation ou pas.
        public static bool OperationSuccess { get; set; } = false;

        public static bool carteParListe { get; set; } = false;
        public static bool carteProvisoire { get; set; } = false;

        public static bool ImprNiveau { get; set; } = false;
        public static bool presetPath { get; set; } = false;

        public static string folderPath { get; set; }


        // variables pour la passiation de données entre frmSelectionneAjoutDansCarteAcces et frmMultipleCartesedition
        // (j'aurais bien passé les données via des variables publiques dans ces deux forms mais tout est déjà centralisé ici)

        public static FrmMultiplesCartesEdition formMultipleCartes;

        /// <summary>
        /// Les données des champs personnalisées ajoutés sur la face de la carte.
        /// Voir <see cref="FrmMultiplesCartesEdition.ajouteControlChampPersonnalisee(string, string, System.Drawing.Font)"/>
        /// Contient si ils existent: l'option (codeQR, codeBarre, Texte) ; l'image ; les coodronnées sur la carte face ;
        /// le texte ; la police du texte ; la pictureBox originel
        /// </summary>
        public static List<Tuple<string, Image, Point, string, Font, PictureBox>> donneesChampsPersonnalisee;

        /// <summary>
        /// Largeur physique minimum d'un code barre en millimètre.
        /// </summary>
        public static double codeBarreLongueurMinimum { get; } = 0.33;
        /// <summary>
        /// Longueur physique minimum d'un code barre en millimètre.
        /// </summary>
        public static double codeBarreLargeurMinimum { get; } = 13;
    }
}