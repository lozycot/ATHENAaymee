/**
 * Ce fichier contient la classe PdfGs qui permet de récupérer des images d'un PDF.
 * Elle inclut des méthodes pour importer des emplois du temps à partir de fichiers PDF.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using CartesAcces2024;
using System.Text;
using System.ComponentModel;

namespace CartesAcces2024
{
    /// <summary>
    /// Classe pour gérer l'importation d'images à partir de fichiers PDF.
    /// </summary>
    public static class PdfGs
    {
        //private static string _outputPath = Chemin.CheminEdtClassique;
        public static string trombiOutputPath = Chemin.DossierTrombi + "temp/";

        /// <summary>
        /// Récupère les images (emplois du temps) d'un PDF.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="classe"></param>
        public static void GetImageFromPdf(string path, int classe, BackgroundWorker worker)
        {
            string _outputPath = Chemin.DossierEdtClassique;

            if (!Directory.Exists(_outputPath + "/6eme/"))
                Directory.CreateDirectory(_outputPath + "/6eme/");
            if (!Directory.Exists(_outputPath + "/5eme/"))
                Directory.CreateDirectory(_outputPath + "/5eme/");
            if (!Directory.Exists(_outputPath + "/4eme/"))
                Directory.CreateDirectory(_outputPath + "/4eme/");
            if (!Directory.Exists(_outputPath + "/3eme/"))
                Directory.CreateDirectory(_outputPath + "/3eme/");
            if (!Directory.Exists(_outputPath + "/classes/"))
                Directory.CreateDirectory(_outputPath + "/classes/");
            if (!Directory.Exists(_outputPath + "/tous/"))
                Directory.CreateDirectory(_outputPath + "/tous/");

            switch (classe)
            {
                case 3:
                    _outputPath += "/3eme/";
                    break;
                case 4:
                    _outputPath += "/4eme/";
                    break;
                case 5:
                    _outputPath += "/5eme/";
                    break;
                case 6:
                    _outputPath += "/6eme/";
                    break;
                case 7:
                    _outputPath += "/classes/";
                    break;
                case 8:
                    _outputPath += "/tous/";
                    break;
            }
            Globale.outputPath = _outputPath;

            var outputPattern = _outputPath + "page%d.jpg";

            if (Directory.Exists(_outputPath))
            {
                foreach (var file in Directory.GetFiles(_outputPath))
                    File.Delete(file);
            }
            else
            {
                Directory.CreateDirectory(_outputPath);
            }
            var process = new Process();
            process.StartInfo.FileName =
                "./Ghostscript/gswin32c.exe"; // or the appropriate version of the executable for your system
            process.StartInfo.Arguments =
                $"-o \"{outputPattern}\" -I\"./font/a.ttg\" -sDEVICE=jpeg -dJPEGQ=85 -r150 -dPDFFitPage -c \"<< /Orientation 3 >> setpagedevice\" -dPrinted=false -dNOPAUSE -dBATCH \"{path}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            int i = 0;
            int nbPages = GetNbPagesPdf(path);
            StringBuilder outputBuilder = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate (object sender, DataReceivedEventArgs e)
                {
                    // append the new data to the data already read-in
                    outputBuilder.Append(e.Data);
                    double p = (double)i / (double)nbPages * 100.0;
                    if (p > 100)
                        p = 100.0;
                    worker.ReportProgress((int)p);
                    i++;
                }
            );

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.CancelOutputRead();

            // Renommage des fichiers image edt en "NOM Prénom.jpg" OU BIEN en "nomclasse.jpg"
            // On part du principe que les fichiers générés nommés page[numéro].jpg seront
            // dans le même ordre que les élèves de ListeEleve ou ListeClasses
            for(int j = 1; j <= nbPages; j++)
            {
                string nameOrig = _outputPath + "page" + j.ToString() + ".jpg";
                string newName = "";
                // si classe == toutes les classes sans élèves
                if (classe == 7)
                {
                    MessageBox.Show("GetImageFromPdf "+Globale.ListeClasses[j - 1]);//===========================
                    newName = _outputPath + Globale.ListeClasses[j - 1] + ".jpg";
                }
                else if(classe == 8)
                {
                    string pathTemp = Chemin.DossierEdtClassique;
                    // si un niveau est défini
                    if (Globale.ListeEleve[j - 1].NiveauEleve != "null")
                        newName = pathTemp + Globale.ListeEleve[j - 1].NiveauEleve + "eme/";
                    else
                        newName = _outputPath;
                    newName += Globale.ListeEleve[j - 1].NomEleve + " " +
                        Globale.ListeEleve[j - 1].PrenomEleve + ".jpg";
                    Globale.CheminEleve = newName;
                }
                else
                    newName = _outputPath + Globale.ListeEleve[j - 1].NomEleve + " " +
                        Globale.ListeEleve[j - 1].PrenomEleve + ".jpg";
                Globale.CheminEleve = newName;
                if (File.Exists(nameOrig))
                {
                    if (File.Exists(newName))
                        File.Delete(newName);
                    File.Move(nameOrig, newName);
                }
            }
            //MessageBox.Show("Images des emplois du temps générées dans le dossier :\n" + _outputPath);
        }


        /// <summary>
        /// Permet d'importer les emplois du temps PDF des classes, sans les noms des élèves.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="classe"></param>
        public static void GetImageTrombiFromPdf(string path, BackgroundWorker worker)
        {
            string _outputPath = trombiOutputPath;

            var outputPattern = _outputPath + "page%d.jpg";

            if (Directory.Exists(_outputPath))
                foreach (var file in Directory.GetFiles(_outputPath)) File.Delete(file);
            else
                Directory.CreateDirectory(_outputPath);

            var process = new Process();
            process.StartInfo.FileName =
                "./Ghostscript/gswin32c.exe"; // or the appropriate version of the executable for your system
            process.StartInfo.Arguments =
                $"-o \"{outputPattern}\" -I\"./font/a.ttg\" -sDEVICE=jpeg -dJPEGQ=85 -r150 -dPDFFitPage -c \"<< /Orientation 3 >> setpagedevice\" -dPrinted=false -dNOPAUSE -dBATCH \"{path}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            int i = 0;
            int nbPages = GetNbPagesPdf(path);
            StringBuilder outputBuilder = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate (object sender, DataReceivedEventArgs e)
                {
                    // append the new data to the data already read-in
                    outputBuilder.Append(e.Data);
                    double p = (double)i / (double)nbPages * 100.0;
                    if (p > 100)
                        p = 100.0;
                    worker.ReportProgress((int)p);
                    i++;
                }
            );

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.CancelOutputRead();

        }

        /// <summary>
        /// Retourne le nombre de pages d'un PDF, ou 0 si il n'a rien trouvé.
        /// Attention, ne fonctionne pas avec des chemins contenant des espaces (malgré les guillemets).
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int GetNbPagesPdf(string path)
        {
            path = path.Replace('\\', '/');
            var process = new Process();
            process.StartInfo.FileName = "./Ghostscript/gswin32c.exe";
            // commande pour récupérer le nb de pages
            process.StartInfo.Arguments =
                $"-q -dNODISPLAY -dNOSAFER --permit-file-read=\"{path}\" -c \"(\"{path}\") (r) file runpdfbegin pdfpagecount = quit\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            StringBuilder outputBuilder = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate (object sender, DataReceivedEventArgs e)
                {
                    // append the new data to the data already read-in
                    outputBuilder.Append(e.Data);
                }
            );

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.CancelOutputRead();

            string output = outputBuilder.ToString();
            // convertit le texte en nombre
            if (int.TryParse(output, out int nb))
                return nb;
            else
                return 0;
        }

        /// <summary>
        /// Cette fonction permet de récupérer le texte d'un pdf
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetTextePdf(string path)
        {
            var outputFile = "./output.txt";

            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            var fs = File.Create(outputFile);
            fs.Close();

            var process = new Process();
            process.StartInfo.FileName = "./Ghostscript/gswin32c.exe";
            process.StartInfo.Arguments =
                $"-o \"{outputFile}\" -dTextFormat=3 -sDEVICE=txtwrite -dNOPAUSE -dBATCH \"{path}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            process.WaitForExit();

            var file = "";
            using (var sr = new StreamReader(outputFile))
            {
                file = sr.ReadToEnd();
            }

            return file;
        }

        /// <summary>
        /// Cette fonction permet de récupérer le texte d'un pdf
        /// Version pour frmChargement avec le BackgroundWorker
        /// </summary>
        /// <param name="path"></param>
        /// <param name="worker"</param>
        /// <returns></returns>
        public static string GetTextePdf(string path, BackgroundWorker worker)
        {
            var outputFile = "./output.txt";

            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            var fs = File.Create(outputFile);
            fs.Close();

            var process = new Process();
            process.StartInfo.FileName = "./Ghostscript/gswin32c.exe";
            process.StartInfo.Arguments =
                $"-o \"{outputFile}\" -dTextFormat=3 -sDEVICE=txtwrite -dNOPAUSE -dBATCH \"{path}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            //permet de compter la page où on se situe
            int i = 0;
            //récupère le nombre total de pages pour calculer le pourcentage d'avancement
            int nbPages = GetNbPagesPdf(path);
            StringBuilder outputBuilder = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                /// Ghostscript écrit "Page 1" "Page 2" "Page 3" etc. dans la sortie standard
                /// lorsqu'il est en train de lire un fichier PDF. Lorsqu'on entre dans cette fonction 
                /// lambda, cela signifie, en principe, qu'une nouvelle page a été lue. On ne s'occupe
                /// pas de lire ce qui a été écrit dans la sortie standard, juste d'effectuer une itération
                /// sur i, calculer le pourcentage et envoyer l'information de la progression au worker, 
                /// pour la barre de progression.

                delegate (object sender, DataReceivedEventArgs e)
                {
                    // append the new data to the data already read-in
                    outputBuilder.Append(e.Data);
                    if(nbPages > 0)
                    {
                        double p = (double)i / (double)nbPages * 100.0;
                        if (p > 100)
                            p = 100.0;
                        worker.ReportProgress((int)p);
                    }
                    i++;
                }
            );

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.CancelOutputRead();

            var file = "";
            using (var sr = new StreamReader(outputFile))
            {
                file = sr.ReadToEnd();
            }

            return file;
        }

        /// <summary>
        /// Permet de lire la liste des classes depuis les emplois Index Education du temps et de la charger dans
        /// Globale.ListeClasses.
        /// </summary>
        /// <param name="pdftext"></param>
        public static void SetLesClassesIE(string pdftext)
        {
            // On vide la liste pour éviter tout conflit avec l'ordre des pages générées dans GetImageFromPdf
            Globale.ListeClasses.Clear();

            // exemple d'une ligne contenant le nom d'une classe, pour référence :
            //                               33  33  --  AAnnnnééee  CCoommppllèèttee        
            // !! Recherche des lignes qui nous interessent !!

            // -- On commence au premier caractère de la chaine --
            var posDepart = 0;
            // -- La ligne s'arrete lorsqu'il y a un saut --
            var posFin = pdftext.IndexOf(Environment.NewLine, StringComparison.Ordinal);
            // -- Tant qu'on a pas attein la fin de la variable --

            while (posFin != -1)
            {
                try
                {
                    var line = pdftext.Substring(posDepart, posFin - posDepart);
                    // Si la ligne contient la mention "AAnnnnééee  CCoommppllèèttee"
                    // (les lettres sont doublées dans le pdf)
                    if (line.Contains("AAnnnnééee  CCoommppllèèttee"))
                    {
                        int prefixeACouper = line.IndexOf("                         ");
                        if (prefixeACouper != -1)
                            line = line.Substring(prefixeACouper);
                        int posClasse = Array.FindIndex(line.ToCharArray(), x => !char.IsWhiteSpace(x));
                        if (posClasse != -1)
                            line = line.Substring(posClasse);
                        string s = "";

                        // enlève 1 caractère sur 2 car les caractères sont en double
                        for (int j = 0; j < line.Length; j += 2)
                        {
                            s += line[j];
                        }

                        line = s;

                        string classe = "";
                        // On cherche l'emplacement de "Classe "
                        int posAutres = line.IndexOf(" ");
                        // On supprime "Classe " et tout ce qu'il y avant
                        classe = line.Substring(0, posAutres);
                        Globale.ListeClasses.Add(classe);
                    }
                    // -- La position de départ se place au début de la ligne suivante --
                    posDepart = posFin + 1;
                    // -- La position de fin se place au saut de ligne de la ligne suivante --
                    posFin = pdftext.IndexOf("\r\n", posDepart + 1, StringComparison.Ordinal);
                    // -- Toujours vrai sauf si erreur --
                }
                catch (Exception err)
                {
                    MessageBox.Show(new Form { TopMost = true },
                        "Erreur lors de la lecture des données classes dans le fichier PDF : " + err.Message);
                    return;
                }

            }
        }

        /// <summary>
        /// Permet de lire la liste des classes depuis les emplois UDT du temps et de la charger dans
        /// Globale.ListeClasses.
        /// </summary>
        /// <param name="pdftext"></param>
        public static void SetLesClassesUDT(string pdftext)
        {
            // On vide la liste pour éviter tout conflit avec l'ordre des pages générées dans GetImageFromPdf
            Globale.ListeClasses.Clear();

            // exemple d'une ligne contenant le nom d'une classe, pour référence :
            //                     Classe 6HOCKEY\r\n 
            // !! Recherche des lignes qui nous interessent !!

            // -- On commence au premier caractère de la chaine --
            var posDepart = 0;
            // -- La ligne s'arrete lorsqu'il y a un saut --
            var posFin = pdftext.IndexOf(Environment.NewLine, StringComparison.Ordinal);
            // -- Tant qu'on a pas attein la fin de la variable --

            while (posFin != -1)
            {
                try
                {
                    var line = pdftext.Substring(posDepart, posFin - posDepart);
                    // -- Si la ligne contient la mention "Classe " .. -- 
                    if (line.Contains("Classe "))
                    {
                        // pour une chaine '                  Classe 6HERGE [6HERGE]        '
                        string classe = "";

                        // On cherche l'emplacement de "Classe "
                        int posClasse = line.IndexOf("Classe ");

                        // On supprime tout ce qui existe avant "Classe "    ----> '6HERGE [6HERGE]        '
                        string temp = line.Substring(posClasse + "Classe ".Length);

                        // On coupe la chaine pour récupérer le texte avant le prochain espace ---->  '6HERGE'
                        classe = temp.Split(' ')[0];

                        //int length = line.IndexOf(" ");
                        // On supprime "Classe " et tout ce qu'il y avant
                        //classe = line.Substring(posClasse + "Classe ".Length, length);

                        Globale.ListeClasses.Add(classe);
                    }
                    // -- La position de départ se place au début de la ligne suivante --
                    posDepart = posFin + 1;
                    // -- La position de fin se place au saut de ligne de la ligne suivante --
                    posFin = pdftext.IndexOf("\r\n", posDepart + 1, StringComparison.Ordinal);
                    // -- Toujours vrai sauf si erreur --
                }
                catch (Exception err)
                {
                    MessageBox.Show(new Form { TopMost = true },
                        "Erreur lors de la lecture des données classes dans le fichier PDF : " + err.Message + "\n"
                        + "Pile d'appel: " + err.StackTrace.ToString()
                        );
                    return;
                }

            }
        }

        /// <summary>
        /// Le nom / prénom de l'élève est en principe avec des lettres en doublons contrairement au
        /// nom de l'établissement. Cela permet de détecter le nom / prénom.
        /// </summary>
        /// <param name="line"></param>
        public static int TrouverDebutDoublons(string line)
        {
            int nbDoublons = 0; // Nombres de doublons qui s'enchaînent
            bool doublonTrouve = false; // Stocke si on est entré dans une suite de doublons
            int debutDoublon = -1; // Début de la séquence de doublons ou -1 si aucune trouvée
            for(int i = 1; i < line.Length; i++)
            {
                // Si deux caractères qui s'enchaînent sont identiques et pas des espaces
                if(line[i] == line[i - 1])
                {
                    if(doublonTrouve)
                    {
                        nbDoublons++;
                        /**
                         * On incrémente i car maintenant on veut regarder 2 caractères plus loin
                         * (exemple : dans "AABB" on veut tester si A == A puis si B == B, 
                         * et pas A == A puis A == B puis B == B)
                         */
                        i++;
                    }
                    // On ne peut pas commencer une séquence de doublons avec des espaces
                    else if(line[i] != ' ')
                    {
                        // On stocke la position du début de la séquence si elle vient de commencer
                        nbDoublons++;
                        doublonTrouve = true;
                        debutDoublon = i;
                        i++;
                    }

                    // à partir de 6 doublons qui s'enchaînent on peut considérer que c'est ok
                    if (nbDoublons >= 6)
                        return debutDoublon;
                }
                // Si pas / plus de doublon, on reset
                else
                {
                    doublonTrouve = false;
                    debutDoublon = -1;
                    nbDoublons = 0;
                }
            }
            return debutDoublon;
        }

        /// <summary>
        /// Récupère nom, prénom et classe depuis le texte d'un pdf Index Education.
        /// Méthode similaire à celle du même nom dans readCsv, mais 
        /// ici la récupération des données se fait non pas dans le CSV mais dans le PDF, logiquement.
        /// </summary>
        /// <param name="pdftext"></param>
        /// <returns></returns>
        //public static List<string> GetNomPrenomClassePdf(string pdftext)
        public static void SetLesElevesIE(string pdftext)
        {
            // On vide la liste pour éviter tout conflit avec l'ordre des pages générées dans GetImageFromPdf
            Globale.ListeEleve.Clear();

            // exemple d'une ligne contenant Elève, pour référence :
            //             Elève NOM Prénom   6HOCKEY - Externe - AGL1

            //var listeProvisoire = new List<Eleve>();

            var listeExtractPdf = new List<string>();

            // !! Recherche des lignes qui nous interessent !!

            // -- On commence au premier caractère de la chaine --
            var posDepart = 0;
            // -- La ligne s'arrete lorsqu'il y a un saut --
            var posFin = pdftext.IndexOf(Environment.NewLine, StringComparison.Ordinal);
            // -- Tant qu'on a pas attein la fin de la variable --

            int i = 0;
            while (posFin != -1)
            {
                try
                {
                    var line = pdftext.Substring(posDepart, posFin - posDepart);
                    string templine = line;
                    // Si la ligne contient la mention "AAuuttoorriissaattiioonn"
                    // (c'est un mot qui est contenu dans la ligne contenant le nom de l'élève sur les
                    // emplois du temps Index Education)
                    if (line.Contains("AAuuttoorriissaattiioonn"))
                    {
                        int prefixeACouper = TrouverDebutDoublons(line);
                        if(prefixeACouper != -1)
                            line = line.Substring(prefixeACouper);
                        string s = "";

                        // elève 1 caractère sur 2 car les caractères sont en double
                        for(int j = 0; j < line.Length; j += 2)
                        {
                            s += line[j];
                        }

                        line = s;

                        var unEleve = new Eleve();
                        unEleve.NumEleve = i;

                        int posClasse = line.IndexOf(" (");

                        // temp contient le NOM Prénom de l'élève 
                        string temp = line;
                        if(posClasse != -1)
                            temp = line.Substring(0, posClasse);
                        var tab = temp.Split(new string[] { " " }, StringSplitOptions.None);
                        // On sépare les NOMS et les Prénoms
                        foreach (var t in tab)
                        {
                            // Si tout le mot est en MAJUSCULE : c'est un nom
                            if (t.ToUpper() == t)
                            {
                                if (unEleve.NomEleve != "null")
                                    unEleve.NomEleve += " " + t;
                                else
                                    unEleve.NomEleve = t;
                            }
                            // Sinon c'est un prénom
                            else
                            {
                                if (unEleve.PrenomEleve != "null")
                                    unEleve.PrenomEleve += " " + t;
                                else
                                    unEleve.PrenomEleve = t;
                            }
                        }

                        if(posClasse != -1)
                            line = line.Substring(posClasse + " (".Length);

                        // Récupération de la classe
                        // le " - ' marque la fin du nom de la classe
                        int posAutres = line.IndexOf(")");
                        if (posAutres != -1)
                            unEleve.ClasseEleve = line.Substring(0, posAutres);
                        else // si la classe est vide
                            posAutres = posClasse + 1;

                        // on supprime le prénom de la ligne pour continuer
                        line = line.Substring(posAutres + 1);

                        if(unEleve.ClasseEleve != "")
                            unEleve.NiveauEleve = unEleve.ClasseEleve.Substring(0, 1);
                        else
                        {
                            unEleve.ClasseEleve = "null";
                            unEleve.NiveauEleve = "null";
                        }
                        //line = line.Replace("/", null);
                        //line = line.Replace(" - ", null);
                        //line = line.Replace(Environment.NewLine, null);
                        //line = line.Replace("Elève", null);
                        // -- .. Alors on affecte cette ligne a la liste --
                        //listeExtractPdf.Add(line);
                        i++;

                        //listeProvisoire.Add(unEleve);
                        Globale.ListeEleve.Add(unEleve);
                    }
                    int l = pdftext.Length;
                    // -- La position de départ se place au début de la ligne suivante --
                    posDepart = posFin + 1;
                    // -- La position de fin se place au saut de ligne de la ligne suivante --
                    posFin = pdftext.IndexOf("\r\n", posDepart + 1, StringComparison.Ordinal);
                    // -- Toujours vrai sauf si erreur --

                }
                catch (Exception err)
                {
                    MessageBox.Show(new Form { TopMost = true },
                        "Erreur lors de la lecture des données élèves dans le fichier PDF : " + err.Message);
                    return;
                }

            }
            //if (Globale.CheminPdf != "failed")
            //{
            //    MessageBox.Show("Données élèves importées depuis les emplois du temps !");
            //}

            //return listeExtractPdf;
        }


        /// <summary>
        /// Récupère nom, prénom et classe depuis le texte d'un pdf UnDeuxTEMPS (UDT).
        /// Méthode similaire à celle du même nom dans readCsv, mais 
        /// ici la récupération des données se fait non pas dans le CSV mais dans le PDF, logiquement.
        /// </summary>
        /// <param name="pdftext"></param>
        /// <returns></returns>
        //public static List<string> GetNomPrenomClassePdf(string pdftext)
        public static void SetLesElevesUDT(string pdftext)
        {
            // On vide la liste pour éviter tout conflit avec l'ordre des pages générées dans GetImageFromPdf
            Globale.ListeEleve.Clear();

            // exemple d'une ligne contenant Elève, pour référence :
            //             Elève NOM1 NOM2 Prénom   6HOCKEY - Externe - AGL1

            var listeProvisoire = new List<Eleve>();

            var listeExtractPdf = new List<string>();

            // !! Recherche des lignes qui nous interessent !!

            // -- On commence au premier caractère de la chaine --
            var posDepart = 0;
            // -- La ligne s'arrete lorsqu'il y a un saut --
            var posFin = pdftext.IndexOf(Environment.NewLine, StringComparison.Ordinal);
            // -- Tant qu'on a pas attein la fin de la variable --

            int i = 0;
            while (posFin != -1)
            {
                try
                {
                    var line = pdftext.Substring(posDepart, posFin - posDepart);
                    // -- Si la ligne contient la mention "Elève" .. -- 
                    if (line.Contains(" Elève "))
                    {
                        var unEleve = new Eleve();
                        unEleve.NumEleve = i;



                        // On cherche l'emplacement de "Elève"
                        int posEleve = line.IndexOf(" Elève ");
                        // On supprime " Elève " et tout ce qu'il y avant
                        line = line.Substring(posEleve + " Elève ".Length);
                        //line = line.Replace(" ", null);

                        int posClasse = line.IndexOf("   ");



                        // temp contient le NOM Prénom de l'élève 
                        string temp = line.Substring(0, posClasse);
                        var tab = temp.Split(new string[] { " " }, StringSplitOptions.None);
                        // On sépare les NOMS et les Prénoms
                        foreach (var t in tab)
                        {
                            // Si tout le mot est en MAJUSCULE : c'est un nom
                            if (t.ToUpper() == t)
                            {
                                if (unEleve.NomEleve != "null")
                                    unEleve.NomEleve += " " + t;
                                else
                                    unEleve.NomEleve = t;
                            }
                            // Sinon c'est un prénom
                            else
                            {
                                if (unEleve.PrenomEleve != "null")
                                    unEleve.PrenomEleve += " " + t;
                                else
                                    unEleve.PrenomEleve = t;
                            }
                        }

                        line = line.Substring(posClasse + 3);

                        // Récupération de la classe
                        // le " - ' marque la fin du nom de la classe
                        int posAutres = line.IndexOf(" ");
                        unEleve.ClasseEleve = line.Substring(0, posAutres);
                        // on supprime le prénom de la ligne pour continuer
                        line = line.Substring(posAutres + 1);

                        unEleve.NiveauEleve = unEleve.ClasseEleve.Substring(0, 1);
                        //line = line.Replace("/", null);
                        //line = line.Replace(" - ", null);
                        //line = line.Replace(Environment.NewLine, null);
                        //line = line.Replace("Elève", null);
                        // -- .. Alors on affecte cette ligne a la liste --
                        //listeExtractPdf.Add(line);
                        i++;

                        listeProvisoire.Add(unEleve);
                    }
                    // -- La position de départ se place au début de la ligne suivante --
                    posDepart = posFin + 1;
                    // -- La position de fin se place au saut de ligne de la ligne suivante --
                    posFin = pdftext.IndexOf("\r\n", posDepart + 1, StringComparison.Ordinal);
                    // -- Toujours vrai sauf si erreur --

                    Globale.ListeEleve = listeProvisoire;
                }
                catch (Exception err)
                {
                    MessageBox.Show(new Form { TopMost = true },
                        "Erreur lors de la lecture des données élèves dans le fichier PDF : " + err.Message);
                    return;
                }

            }
            //if (Globale.CheminPdf != "failed")
            //{
            //    MessageBox.Show("Données élèves importées depuis les emplois du temps !");
            //}

            //return listeExtractPdf;
        }

        /// <summary>
        /// Cette fonction permet de récupérer le nom et le prenom d'un eleve dans un pdf
        /// </summary>
        /// <param name="pdftext"></param>
        /// <returns></returns>
        public static List<string> GetNomPrenomPdf(string pdftext)
        {
            var listeExtractPdf = new List<string>();

            // !! Recherche des lignes qui nous interesse !!

            // -- On commence au premier caractère de la chaine --
            var posDepart = 0;
            // -- La ligne s'arrete lorsqu'il y a un saut --
            var posFin = pdftext.IndexOf(Environment.NewLine, StringComparison.Ordinal);
            // -- Tant qu'on a pas attein la fin de la variable --

            while (posFin != -1)
            {
                var line = pdftext.Substring(posDepart, posFin - posDepart);
                // -- Si la ligne contient la mention "Elève" .. -- 
                if (line.Contains(" Elève "))
                {
                    //line = line.Replace(" ", null);
                    line = line.Replace("/", null);
                    line = line.Replace("-", null);
                    line = line.Replace(Environment.NewLine, null);
                    line = line.Replace("Elève", null);
                    // -- .. Alors on affecte cette ligne a la liste --
                    listeExtractPdf.Add(line);
                }

                // -- La position de départ se place au début de la ligne suivante --
                posDepart = posFin + 1;
                // -- La position de fin se place au saut de ligne de la ligne suivante --
                posFin = pdftext.IndexOf("\r\n", posDepart + 1, StringComparison.Ordinal);
                // -- Toujours vrai sauf si erreur --
            }

            return listeExtractPdf;
        }

        /// <summary>
        /// Cette fonction permet de récupérer la classe d'un eleve dans un pdf
        /// </summary>
        /// <param name="pdftext"></param>
        /// <returns></returns>
        public static List<string> GetClassePdf(string pdftext)
        {
            var listeExtractPdf = new List<string>();

            // !! Recherche des lignes qui nous interesse !!

            // -- On commence au premier caractère de la chaine --
            var posDepart = 0;
            // -- La ligne s'arrete lorsqu'il y a un saut --
            var posFin = pdftext.IndexOf(Environment.NewLine, StringComparison.Ordinal);
            // -- Tant qu'on a pas attein la fin de la variable --

            while (posFin != -1)
            {
                var line = pdftext.Substring(posDepart, posFin - posDepart);
                // -- Si la ligne contient la mention "Classe" .. -- 
                if (line.Contains("Classe"))
                {
                    line = line.Replace(" ", null);
                    line = line.Replace("/", null);
                    line = line.Replace("-", null);
                    line = line.Replace(Environment.NewLine, null);
                    line = line.Replace("Classe", null);
                    // -- .. Alors on affecte cette ligne a la liste --
                    listeExtractPdf.Add(line);
                }

                // -- La position de départ se place au début de la ligne suivante --
                posDepart = posFin + 1;
                // -- La position de fin se place au saut de ligne de la ligne suivante --
                posFin = pdftext.IndexOf("\r\n", posDepart + 1, StringComparison.Ordinal);
                // -- Toujours vrai sauf si erreur --
            }

            return listeExtractPdf;
        }

        /// <summary>
        /// Cette fonction permet de renommer les edt
        /// </summary>
        /// <param name="pdf"></param>
        public static void RenameEdt(string pdf)
        {
            string _outputPath = Chemin.DossierEdtClassique;
            List<string> name;

            if (Globale.Classe == 7)
                name = GetClassePdf(GetTextePdf(pdf));
            else
                name = GetNomPrenomPdf(GetTextePdf(pdf));
            MessageBox.Show(new Form {TopMost = true}, name.Count
                                                       + " emplois de temps ont été importés");
            var d = new DirectoryInfo(_outputPath);
            var infos = d.GetFiles();

            for (var i = 0; i < infos.Length; i++)
            {
                var nameWithoutExt = infos[i].Name.Substring(0, infos[i].Name.Length - 4);
                var index = nameWithoutExt.Substring(4, nameWithoutExt.Length - 4);
                var indexInt = Convert.ToInt32(index);

                var oldName = nameWithoutExt;
                var newName = name[indexInt - 1].Trim();
                File.Move(infos[i].FullName, infos[i].FullName.Replace(oldName, newName));
            }
        }

        /// <summary>
        /// Cette fonction permet de récupérer la date de la dernière importation
        /// </summary>
        /// <returns></returns>
        public static string getDateFile()
        {
            string _outputPath = Chemin.DossierEdtClassique;
            var dateFile = "Aucune Importation";
            var dir = new DirectoryInfo(_outputPath);
            if (dir.Exists) dateFile = dir.CreationTime.ToString(CultureInfo.InvariantCulture);

            return dateFile;
        }


        /// <summary>
        /// Permet d'importer les emplois du temps d'un niveau (6ème, 5ème...), contenant les 
        /// emplois du temps individuels des élèves.
        /// </summary>
        public static void ImporterEdtUnNiveau()
        {
            // On utilise une liste de cas pour indiquer à frmChargement une suite d'actions à réaliser
            Globale.ListeCas.Clear();
            Globale.ListeCas.Add(Globale.CodeCas.extraitTextePdf);
            if (Globale.LogicielEdt == Globale.LogicielsEdt.UnDeuxTemps)
                Globale.ListeCas.Add(Globale.CodeCas.setLesElevesPdfUDT);
            else
                Globale.ListeCas.Add(Globale.CodeCas.setLesElevesPdfIE);
            Globale.ListeCas.Add(Globale.CodeCas.extraitImagesEdt);
            Globale.ListeCas.Add(Globale.CodeCas.insertElevesBdd);
            Globale.Cas = Globale.ListeCas[0];
            I_ImportService fileDialog = new ImportPdf();
            Globale.CheminPdf = fileDialog.setCheminImportation();

            string temp = Globale.CheminPdf;
            if (Globale.CheminPdf != "failed")
            {
                // On copie le fichier dans le répertoire local, car Ghostscript gère mal les 
                // chemins contenant des espaces
                File.Copy(Globale.CheminPdf, "file.pdf", true);
                Globale.CheminPdf = "file.pdf";
                frmChargement chg = new frmChargement();
                chg.StartPosition = FormStartPosition.CenterScreen;
                chg.ShowDialog();
                if (Globale.MessageFinFrmChargement != "")
                    MessageBox.Show(Globale.MessageFinFrmChargement);
                else
                    MessageBox.Show("Opération terminée !");
                File.Delete("file.pdf");
                Globale.CheminPdf = temp;
            }
        }

        /// <summary>
        /// Permet d'importer les emplois du temps pdf des classes, sans les noms des élèves.
        /// </summary>
        public static void ImporterEdtClassesUniquement()
        {
            // On utilise une liste de cas pour indiquer à frmChargement une suite d'actions à réaliser
            Globale.ListeCas.Clear();
            Globale.ListeCas.Add(Globale.CodeCas.extraitTextePdf);
            // on vérifie quel logiciell EdT est utilisé par l'utilisateur
            if(Globale.LogicielEdt == Globale.LogicielsEdt.UnDeuxTemps)
                Globale.ListeCas.Add(Globale.CodeCas.setLesClassesPdfUDT);
            else
                Globale.ListeCas.Add(Globale.CodeCas.setLesClassesPdfIE);
            Globale.ListeCas.Add(Globale.CodeCas.extraitImagesEdt);
            //Globale.ListeCas.Add(Globale.CodeCas.insertElevesBdd);
            Globale.Cas = Globale.ListeCas[0];
            I_ImportService fileDialog = new ImportPdf();
            Globale.CheminPdf = fileDialog.setCheminImportation();

            string temp = Globale.CheminPdf;
            if (Globale.CheminPdf != "failed")
            {
                // On copie le fichier dans le répertoire local, car Ghostscript gère mal les 
                // chemins contenant des espaces
                File.Copy(Globale.CheminPdf, "file.pdf", true);
                Globale.CheminPdf = "file.pdf";
                frmImport imp = new frmImport();
                frmChargement chg = new frmChargement();
                chg.StartPosition = FormStartPosition.CenterScreen;
                chg.ShowDialog();
                if (Globale.MessageFinFrmChargement != "")
                    MessageBox.Show(Globale.MessageFinFrmChargement);
                else
                    MessageBox.Show("Opération terminée !");
                File.Delete("file.pdf");
                Globale.CheminPdf = temp;
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
