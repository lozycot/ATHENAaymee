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

namespace CartesAcces2024
{
    public partial class frmEtablissement : Form
    {
        private int nbChampsPersonnalises = 0;

        public frmEtablissement()
        {
            InitializeComponent();
            
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
            GetLogicielEdt();
            GetInfosCarte();
            string InfosCarte = "";
            if(Globale.InfosCarte == true)
            {
                InfosCarte = "True";
            }
            else
            {
                InfosCarte = "False";
            }
            if (ConnectDb.DbConnect.DbData("Etablissement"))
            {
                string sql = "DELETE FROM Etablissement";
                using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                string insert = "INSERT INTO Etablissement (nomEtablissement,nomRueEtablissement,numeroRueEtablissement,codePostalEtablissement,villeEtablissement,numeroTelephoneEtablissement," +
                    "emailEtablissement,urlEtablissement,codeHexa6eme,codeHexa5eme,codeHexa4eme,codeHexa3eme,bordure,InfosCarte,LogicielEdt) VALUES ('" + txtEtab.Text + "','" + txtNomRue.Text + "','" + txtNumRue.Text + "','" + txtCodePostal.Text +
                    "','" + txtVille.Text + "','" + txtNumTel.Text + "','" + txtMail.Text + "','" + txtUrl.Text + "','" + GetCodeHexa6Eme() + "','" + GetCodeHexa5Eme() + "','" + GetCodeHexa4Eme() + "','" + GetCodeHexa3Eme() + "','" + cbBordure.Checked + "','" + InfosCarte + "','" + Convert.ToString(Globale.LogicielEdt) +"')";
                using (SQLiteCommand insertSQL = new SQLiteCommand(insert, connection))
                {
                    connection.Open();
                    insertSQL.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Données enregistrées");
                    Close();
                }

                // alter table pour rajouter les champs personnalisés
                // puis insert des valeurs associées à chaque champs
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
            if (txtNomDuNouveauChamp.Text == "")
            {
                MessageBox.Show("Ecrivez le nom de votre nouveau champs personnalisé.");
            }
            else
            {
                Label lbl = new Label();
                TextBox txtBox = new TextBox();

                // paramètres du label
                lbl.Width = 310;
                lbl.ForeColor = Color.White;
                lbl.Text = txtNomDuNouveauChamp.Text; // le texte du champs remplissable est utilisé comme label

                //paramètres du textbox
                txtBox.Width = 320; // pour ressembler aux autres textbox du formulaire, en plus long
                txtBox.Height = 24;

                // ces paramètre mettent le textbox juste à côté du label
                //txtBox.Location = new Point(TextRenderer.MeasureText(lbl.Text, lbl.Font).Width + 5, (nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);
                //lbl.Location = new Point(0, (this.nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);

                // ces paramètres les ordonnent avec un espace à droite pré-déterminé
                // coordonnées x sont nb de controls déjà créer * la taille du txt box + nb de controls créer * 5 pour laisser un espace entre chaque control - la valeur de scroll verticale du panel, car pour lui les coordonnées 0 ; 0 sont relatives à ce qui est actuellement affiché, pas ce qui existe
                txtBox.Location = new Point(300, (nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);
                lbl.Location = new Point(0, (this.nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);

                // on les ajoutent au panel
                pnlChampsPersonnalises.Controls.Add(txtBox);
                pnlChampsPersonnalises.Controls.Add(lbl);

                //txtNomDuNouveauChamp.Text = ""; // on efface le texte du champs remplissable, pour plus facilement créer plusieurs champs aux nom différents
                this.nbChampsPersonnalises++;
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            pnlChampsPersonnalises.Controls.Clear();
            nbChampsPersonnalises = 0;
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
