using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CartesAcces2024
{
    public partial class frmEtablissement : Form
    {
        /// <summary>
        /// Sert à compter le nombre de champs personnalisés crées par l'utilisateur. Utilisé pou gérer leur coordonnées lors de leurs création.
        /// </summary>
        private int nbChampsPersonnalises;

        /// <summary>
        /// Contient en clé le Label d'un champ ajouté, et en valeur le TextBox associé.
        /// </summary>
        Dictionary<Label, TextBox> dictChampsPersonnalise = new Dictionary<Label, TextBox>();

        public frmEtablissement()
        {
            InitializeComponent();
            nbChampsPersonnalises = 0;

            string etabName = "SELECT nomEtablissement FROM Etablissement";
            string rueName = "SELECT nomRueEtablissement FROM Etablissement";
            string numRue = "SELECT numeroRueEtablissement FROM Etablissement";
            string codePost = "SELECT codePostalEtablissement FROM Etablissement";
            string ville = "SELECT villeEtablissement FROM Etablissement";
            string numTel = "SELECT numeroTelephoneEtablissement FROM Etablissement";
            string email = "SELECT emailEtablissement FROM Etablissement";
            string url = "SELECT urlEtablissement FROM Etablissement";
            string infos = "SELECT InfosCarte FROM Etablissement";
            string logiciel = "SELECT LogicielEdt FROM Etablissement";
            List<string> commands = new List<string> {etabName,rueName,numRue,codePost,ville,numTel,email,url,infos,logiciel};
            List<TextBox> textBoxes = new List<TextBox> {txtEtab, txtNomRue, txtNumRue, txtCodePostal, txtVille, txtNumTel, txtMail, txtUrl};

            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                for (int i = 0; i < 10; i++)
                { 
                    using (SQLiteCommand command = new SQLiteCommand(commands[i], connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (commands[i] == infos)
                                {
                                    infos = reader.GetString(0);
                                    switch (infos)
                                    {
                                        case "True":
                                            Globale.InfosCarte = true;
                                            rdbOui.Checked = true;
                                            break;
                                        case "False":
                                            Globale.InfosCarte = false;
                                            rdbNon.Checked = true;
                                            break;
                                    }
                                }
                                else if (commands[i] == logiciel)
                                {
                                    logiciel = reader.GetString(0);
                                    switch (logiciel)
                                    {
                                        case "UnDeuxTemps":
                                            Globale.LogicielEdt = Globale.LogicielsEdt.UnDeuxTemps;
                                            rdbUDT.Checked = true;
                                            break;
                                        case "IndexEducation":
                                            Globale.LogicielEdt = Globale.LogicielsEdt.IndexEducation;
                                            rdbEDT.Checked = true;
                                            break;
                                    }
                                }
                                else
                                {
                                    textBoxes[i].Text = reader.GetString(0);
                                }
                            }
                        }
                    }
                }
            }
        }
    

        private void btnValider_Click(object sender, EventArgs e)
        {

            if (validerChamps()==false)
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.");
            }
            else
            {
                // On nettoye la table des dsipositifs personnalisees.
                OperationsDb.supprimerDispositifsPersonnalisee();
                // On les récupères de la listbox.
                foreach (string item in lsbDispositifsPersonnalisee.Items)
                {
                    OperationsDb.ajouteDispositifPersonnalise(item);
                }

                // il faut re-créer la table Etablissement, pour détruire les champs personnalisés existants
                // pour éviter de les cumuler

                GetLogicielEdt();
                GetInfosCarte();
                string InfosCarte = "";
                if (Globale.InfosCarte == true)
                {
                    InfosCarte = "True";
                }
                else
                {
                    InfosCarte = "False";
                }

                OperationsDb.supprimerEtablissement();

                // On insère les nouvelles données dans établissement
                using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
                {
                    string insert = "INSERT INTO Etablissement (nomEtablissement,nomRueEtablissement,numeroRueEtablissement,codePostalEtablissement,villeEtablissement,numeroTelephoneEtablissement," +
                        "emailEtablissement,urlEtablissement,codeHexa6eme,codeHexa5eme,codeHexa4eme,codeHexa3eme,bordure,InfosCarte,LogicielEdt) VALUES ('" + txtEtab.Text + "','" + txtNomRue.Text + "','" + txtNumRue.Text + "','" + txtCodePostal.Text +
                        "','" + txtVille.Text + "','" + txtNumTel.Text + "','" + txtMail.Text + "','" + txtUrl.Text + "','" + GetCodeHexa6Eme() + "','" + GetCodeHexa5Eme() + "','" + GetCodeHexa4Eme() + "','" + GetCodeHexa3Eme() + "','" + cbBordure.Checked + "','" + InfosCarte + "','" + Convert.ToString(Globale.LogicielEdt) + "')";
                    using (SQLiteCommand insertSQL = new SQLiteCommand(insert, connection))
                    {
                        connection.Open();
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                    }

                }







                // pour chaque champ ajouté par l'utilisateur
                foreach (Label lbl in pnlChampsPersonnalises.Controls.OfType<Label>())
                {
                    try
                    {
                        // on formate la chaine entrée par l'utilisateur
                        string nomNouveauChamp = lbl.Text.Trim();
                        nomNouveauChamp = Regex.Replace(nomNouveauChamp, @"[^a-zA-Z0-9_]", "");
                        if (!Regex.IsMatch(nomNouveauChamp, @"^[a-zA-Z_]"))
                        {
                            nomNouveauChamp = "_" + nomNouveauChamp; // Ajoute un underscore en premier charactère en cas de premier charactèreinvalide pour le nom d'une table SQLite
                        }

                        //on récupère le texte entré par l'utilisateur dans la TextBox correspondant
                        string valeurNouveauChamp = dictChampsPersonnalise[lbl].Text;

                        // On ajoute le champs dans Etablissement
                        OperationsDb.ajouteChampDansTable("Etablissement", nomNouveauChamp);

                        //On ajoute la valeur dans le nouvaux champs
                        OperationsDb.insereValeurDansChampsPersonnaliseeEtablissement(nomNouveauChamp, valeurNouveauChamp);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement du champs " + lbl.Text + "\n"
                            + "Message d'erreur : " + exc.Message + "\n"
                            + "Stack trace : " + exc.StackTrace.ToString());
                    }
                }



                MessageBox.Show("Données enregistrées");
                //Close();
            }
        }

        /// <summary>
        /// Récupère le logiciel indiqué comme utilisé pour générer les emplois du temps.
        /// </summary>
        public void GetLogicielEdt()
        {
            foreach(var variable in gpbLogicielEdt.Controls)
            {
                if (variable is RadioButton)
                {
                    var rd = variable as RadioButton;
                    if (rd.Checked)
                    {
                        string text = rd.Text;
                        switch (text)
                        {
                            case "UnDeuxTemps (UDT)":
                                Globale.LogicielEdt = Globale.LogicielsEdt.UnDeuxTemps;
                                break;
                            case "EDT":
                                Globale.LogicielEdt = Globale.LogicielsEdt.IndexEducation;
                                break;
                        }
                    }
                }
            }
        }

        public void GetInfosCarte()
        {
            foreach (var variable in gpbInfosEtab.Controls)
            {
                if (variable is RadioButton)
                {
                    var rd = variable as RadioButton;
                    if (rd.Checked)
                    {
                        string text = rd.Text;
                        switch (text)
                        {
                            case "Oui":
                                Globale.InfosCarte = true;
                                break;
                            case "Non":
                                Globale.InfosCarte = false;
                                break;
                        }
                    }
                }
            }
        }
    

        private string GetCodeHexa6Eme()
        {
            var codeHexa6Eme = "";
            foreach (var variable in gb6eme.Controls)
                if (variable is RadioButton)
                {
                    var rd = variable as RadioButton;
                    if (rd.Checked)
                    {
                        var temp = rd.Text;
                        switch (temp)
                        {
                            case "Rouge":
                                codeHexa6Eme = "#FF0000";
                                break;
                            case "Vert":
                                codeHexa6Eme = "#90EE90";
                                break;
                            case "Bleu":
                                codeHexa6Eme = "#ADD8E6";
                                break;
                            case "Jaune":
                                codeHexa6Eme = "#FFFF00";
                                break;
                            default:
                                codeHexa6Eme = "#FFFFFF";
                                break;
                        }
                    }
                }

            return codeHexa6Eme;
        }

        private string GetCodeHexa5Eme()
        {
            var codeHexa5Eme = "";
            foreach (var variable in gb5eme.Controls)
                if (variable is RadioButton)
                {
                    var rd = variable as RadioButton;
                    if (rd.Checked)
                    {
                        var temp = rd.Text;
                        switch (temp)
                        {
                            case "Rouge":
                                codeHexa5Eme = "#FF0000";
                                break;
                            case "Vert":
                                codeHexa5Eme = "#90EE90";
                                break;
                            case "Bleu":
                                codeHexa5Eme = "#ADD8E6";
                                break;
                            case "Jaune":
                                codeHexa5Eme = "#FFFF00";
                                break;
                            default:
                                codeHexa5Eme = "#FFFFFF";
                                break;
                        }
                    }
                }

            return codeHexa5Eme;
        }

        private string GetCodeHexa4Eme()
        {
            var codeHexa4Eme = "";
            foreach (var variable in gb4eme.Controls)
                if (variable is RadioButton)
                {
                    var rd = variable as RadioButton;
                    if (rd.Checked)
                    {
                        var temp = rd.Text;
                        switch (temp)
                        {
                            case "Rouge":
                                codeHexa4Eme = "#FF0000";
                                break;
                            case "Vert":
                                codeHexa4Eme = "#90EE90";
                                break;
                            case "Bleu":
                                codeHexa4Eme = "#ADD8E6";
                                break;
                            case "Jaune":
                                codeHexa4Eme = "#FFFF00";
                                break;
                            default:
                                codeHexa4Eme = "#FFFFFF";
                                break;
                        }
                    }
                }

            return codeHexa4Eme;
        }

        private string GetCodeHexa3Eme()
        {
            var codeHexa3Eme = "";
            foreach (var variable in gb3eme.Controls)
                if (variable is RadioButton)
                {
                    var rd = variable as RadioButton;
                    if (rd.Checked)
                    {
                        var temp = rd.Text;
                        switch (temp)
                        {
                            case "Rouge":
                                codeHexa3Eme = "#FF0000";
                                break;
                            case "Vert":
                                codeHexa3Eme = "#90EE90";
                                break;
                            case "Bleu":
                                codeHexa3Eme = "#ADD8E6";
                                break;
                            case "Jaune":
                                codeHexa3Eme = "#FFFF00";
                                break;
                            default:
                                codeHexa3Eme = "#FFFFFF";
                                break;
                        }
                    }
                }

            return codeHexa3Eme;
        }


        private void gb6eme_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb5eme_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEtablissement_Load(object sender, EventArgs e)
        {
            // Dispositifs personnalisees
            foreach (string str in OperationsDb.GetDispositifsPersonnalisee())
            {
                lsbDispositifsPersonnalisee.Items.Add(str);
            }

            // recharger les champs personnalisés qui se trouvent dans la base de données
            Dictionary<string, string> tempChampsPeronnalisee = OperationsDb.getEtablissementChampsPersonnalisee();

            foreach (string nomChamps in tempChampsPeronnalisee.Keys)
            {
                Label lbl = ajouterDansPnlChampsPersonnalisee(nomChamps);
                // on ajoute le texte récupéré dans le dictionnaire
                dictChampsPersonnalise[lbl].Text = tempChampsPeronnalisee[nomChamps];
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdbEDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterChamp_Click(object sender, EventArgs e)
        {
            //On vérifie que la chaine n'as pas de charactères spéciaux, ou on empêche de les écrire?
            // on verras si ça marhce plus tard

            // On vérifie qu l'utilisateur n'ajoute pas le même champs deux fois
            bool labelExists = false;
            foreach (Label existingLabel in pnlChampsPersonnalises.Controls.OfType<Label>())
            {
                if (existingLabel.Text == txtNomDuNouveauChamp.Text)
                {
                    labelExists = true;
                }
            }



            if (txtNomDuNouveauChamp.Text == "")
            {
                MessageBox.Show("Ecrivez le nom de votre nouveau champs personnalisé.");
            }
            else if (labelExists)
            {
                MessageBox.Show("Ce champ existe déjà.");
            }
            else
            {
                ajouterDansPnlChampsPersonnalisee(txtNomDuNouveauChamp.Text);
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            pnlChampsPersonnalises.Controls.Clear();
            nbChampsPersonnalises = 0;
        }

        private bool validerChamps()
        {
            if (txtEtab.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtNomDuNouveauChamp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // On empêche les utilisateur d'utiliser des charactères spéciaux pour le nom de nouveaux champs

            // Permet l'utilisation des combinaisons avec la touche Ctrl (Ctrl+C, Ctrl+V, Ctrl+A, etc.)
            if (Control.ModifierKeys == Keys.Control)
            {
                return;
            }

            if (e.KeyChar == ' ')
            {
                e.KeyChar = '_';
            }

            // Empêche l'écriture si le champ est trop long
            TextBox txtNomDuNouveauChamp = sender as TextBox;
            if (txtNomDuNouveauChamp != null && txtNomDuNouveauChamp.Text.Length >= 64 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Vérifie que seuls les lettres ASCII non accentuées (A-Z, a-z), les chiffres (0-9) et '_' sont autorisés
            if (!(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') &&
                !(e.KeyChar >= '0' && e.KeyChar <= '9') &&
                e.KeyChar != '_' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloque le caractère
                return;
            }

            // Vérifie que le premier caractère est une lettre (A-Z, a-z) ou '_'
            if (txtNomDuNouveauChamp != null && txtNomDuNouveauChamp.SelectionStart == 0 &&
                !(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') &&
                e.KeyChar != '_' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloque le caractère
            }
        }

        private void txtNomDuNouveauChamp_TextChanged(object sender, EventArgs e)
        {
            // premet de s'assurer que le texte collé via le presse-papier respectent les règles de txtNomDuNouveauChamp_KeyPress


            // Supprime les caractères non autorisés (conserve uniquement les lettres non accentuées, chiffres, et underscores)
            string sanitizedText = Regex.Replace(txtNomDuNouveauChamp.Text, @"[^a-zA-Z0-9_]", "");

            // Vérifie que le premier caractère est une lettre ou un underscore
            if (sanitizedText.Length > 0 && !char.IsLetter(sanitizedText[0]) && sanitizedText[0] != '_')
            {
                sanitizedText = "_" + sanitizedText.Substring(1);
            }

            // Limite la longueur à 64 caractères
            if (sanitizedText.Length > 64)
            {
                sanitizedText = sanitizedText.Substring(0, 64);
            }

            // Met à jour le texte uniquement s'il a changé (pour éviter une boucle infinie)
            if (sanitizedText != txtNomDuNouveauChamp.Text)
            {
                txtNomDuNouveauChamp.Text = sanitizedText;
                txtNomDuNouveauChamp.SelectionStart = sanitizedText.Length; // Replace le curseur à la fin
            }
            
        }

        /// <summary>
        /// Ajoute un Label et un TextBox à la suite dans le Panel.
        /// </summary>
        /// <param name="nomDuNouveauChamp"></param>
        /// <returns></returns>
        private Label ajouterDansPnlChampsPersonnalisee(string nomDuNouveauChamp)
        {
            Label lbl = new Label();
            TextBox txtBox = new TextBox();

            // paramètres du label
            lbl.Width = 310;
            lbl.ForeColor = Color.White;
            lbl.Text = nomDuNouveauChamp; // le texte du champs remplissable est utilisé comme label

            //paramètres du textbox
            txtBox.Width = 320; // pour ressembler aux autres textbox du formulaire, en plus long
            txtBox.Height = 24;

            // ces paramètre mettent le textbox juste à côté du label
            //txtBox.Location = new Point(TextRenderer.MeasureText(lbl.Text, lbl.Font).Width + 5, (nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);
            //lbl.Location = new Point(0, (this.nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);

            int yCoord = (nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value;

            // ces paramètres les ordonnent avec un espace à droite pré-déterminé
            // coordonnées y sont nb de controls déjà créer * la taille du txt box + nb de controls créer * 5 pour laisser un espace entre chaque control - la valeur de scroll verticale du panel, car pour lui les coordonnées 0 ; 0 sont relatives à ce qui est actuellement affiché, pas ce qui existe
            txtBox.Location = new Point(300, yCoord);
            lbl.Location = new Point(0, yCoord);


            // on les ajoutent au panel
            pnlChampsPersonnalises.Controls.Add(txtBox);
            pnlChampsPersonnalises.Controls.Add(lbl);

            txtNomDuNouveauChamp.Text = ""; // on efface le texte du champs remplissable, pour plus facilement créer plusieurs champs aux nom différents
            this.nbChampsPersonnalises++;

            // on ajoute le label et le textboxdans le dictionnaire, pour pouvoir les retrouver facilement.
            dictChampsPersonnalise.Add(lbl, txtBox);

            return lbl;
        }

        private void btnDispositifsPersonnalisee_Click(object sender, EventArgs e)
        {
            // si la textBox n'est pas vide
            if (txtDispositifPersonnalisee.Text != "")
            {
                lsbDispositifsPersonnalisee.Items.Add(txtDispositifPersonnalisee.Text);
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
 * 
 */
