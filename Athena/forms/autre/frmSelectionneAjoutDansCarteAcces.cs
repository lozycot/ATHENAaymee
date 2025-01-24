using CartesAcces2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athena.forms.autre
{
    public partial class frmSelectionneAjoutDansCarteAcces : Form
    {

        /// <summary>
        /// Sert à compter le nombre de champs personnalisés crées par l'utilisateur. Utilisé pou gérer leur coordonnées lors de leurs création.
        /// </summary>
        private int nbChampsPersonnalises;

        /// <summary>
        /// Contient en clé le Label d'un champ ajouté, et en valeur le TextBox associé.
        /// </summary>
        Dictionary<Label, TextBox> dictChampsPersonnalise = new Dictionary<Label, TextBox>();

        /// <summary>
        /// Contient en clé le Textbox d'un champ ajouté, et en valeur le RadioButton associé.
        /// </summary>
        Dictionary<TextBox, RadioButton> dictSelectionChampsPersonnalise = new Dictionary<TextBox,RadioButton>();

        public frmSelectionneAjoutDansCarteAcces()
        {
            InitializeComponent();
            nbChampsPersonnalises = 0;
        }


        private void frmSelectionneAjoutDansCarteAcces_Load(object sender, EventArgs e)
        {
            // recharger les champs personnalisés qui se trouvent dans la base de données
            Dictionary<string, string> tempChampsPeronnalisee = OperationsDb.getEtablissementChampsPersonnalisee();

            foreach (string nomChamps in tempChampsPeronnalisee.Keys)
            {
                Label lbl = ajouterDansPnlChampsPersonnalisee(nomChamps);
                dictChampsPersonnalise[lbl].Text = tempChampsPeronnalisee[nomChamps];
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
            RadioButton rdButton = new RadioButton();

            // paramètres du label
            lbl.Width = 310;
            lbl.ForeColor = Color.White;
            lbl.Text = nomDuNouveauChamp; // le texte du champs remplissable est utilisé comme label

            //paramètres du textbox
            txtBox.Width = 320; // pour ressembler aux autres textbox du formulaire, en plus long
            txtBox.Height = 24;

            //paramètres du radioButton
            rdButton.Checked = false;

            // ces paramètre mettent le textbox juste à côté du label
            //txtBox.Location = new Point(TextRenderer.MeasureText(lbl.Text, lbl.Font).Width + 5, (nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);
            //lbl.Location = new Point(0, (this.nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value);

            int yCoord = (nbChampsPersonnalises * txtBox.Size.Height) + (this.nbChampsPersonnalises * 5) - pnlChampsPersonnalises.VerticalScroll.Value;

            // ces paramètres les ordonnent avec un espace à droite pré-déterminé
            // coordonnées y sont nb de controls déjà créer * la taille du txt box + nb de controls créer * 5 pour laisser un espace entre chaque control - la valeur de scroll verticale du panel, car pour lui les coordonnées 0 ; 0 sont relatives à ce qui est actuellement affiché, pas ce qui existe
            lbl.Location = new Point(0, yCoord);
            txtBox.Location = new Point(300, yCoord);
            rdButton.Location = new Point(650, yCoord);

            // On ne veux pas permettre à l'utilisateur d'entrer des informations erronées
            // ou de les corrigers autre part que dans l'importation des informations frmEtablissement
            txtBox.ReadOnly = true;

            // on les ajoutent au panel
            pnlChampsPersonnalises.Controls.Add(txtBox);
            pnlChampsPersonnalises.Controls.Add(lbl);
            pnlChampsPersonnalises.Controls.Add(rdButton);

            this.nbChampsPersonnalises++;

            // on ajoute le label et le textboxdans le dictionnaire, pour pouvoir les retrouver facilement.
            dictChampsPersonnalise.Add(lbl, txtBox);
            dictSelectionChampsPersonnalise.Add(txtBox, rdButton);
            dictSelectionChampsPersonnalise.Values.First().Checked = true;

            return lbl;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // On récupère ce que l'utilisateur veux ajouter (texte,code QR, code Barre)
            string optionChoisie = "Texte";
            foreach (RadioButton rdb in pnlOptions.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked == true)
                {
                    optionChoisie = rdb.Text;
                }
            }

            // MultipleCartesEdition ajoute un controle.
            // Pour chaque pair (TextBox / Radiobutton) de valeurs pour tout les champs personnalisées
            foreach (KeyValuePair<TextBox, RadioButton> pairSelectionChampPersonnalisee in dictSelectionChampsPersonnalise)
            {
                if (pairSelectionChampPersonnalisee.Value.Checked == true) // si c'est la valeur que l'utilisateur veux ajouter
                {
                    if (optionChoisie == "Text") // Si l'option est texte
                    {
                        // pour chaque pair (Label / TextBox) de tout les champs personnalisées
                        foreach (KeyValuePair<Label, TextBox> pairChampPersonnalisee in dictChampsPersonnalise)
                        {
                            // si les textbox sont les même dans les daux paires, on peut récupérer le nom de champ correspondant
                            if (pairChampPersonnalisee.Value == pairSelectionChampPersonnalisee.Key)
                            {
                                // On donne le texte à transformer et a ajouter
                                Globale.formMultipleCartes.ajouteControlChampPersonnalisee(
                                    // On donne le texte à transformer et ajouter ainsi que le nom du champs
                                    pairChampPersonnalisee.Key.Text.Replace('_', ' ') + ": " + pairSelectionChampPersonnalisee.Key.Text,
                                    optionChoisie,
                                    new Font("Calibri", (int)numPoliceChampAjoutee.Value, FontStyle.Bold)
                                );
                            }

                        }
                    }
                    else // Si l'option n'est pas texte
                    {
                        // On donne le texte à transformer et a ajouter
                        Globale.formMultipleCartes.ajouteControlChampPersonnalisee(pairSelectionChampPersonnalisee.Key.Text, optionChoisie);
                    }
                }
            }

            // On ferme ce formulaire
            this.Close();
        }
    }
}
