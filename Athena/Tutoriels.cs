using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athena
{
    class Tutoriels
    {
        // Plusieurs fonctionnalités:
        // - fonction qui fait briller le bouton entré en paramètre
        //          -> surbrillance(btn)
        // - fonction qui créée un label autour du bouton (de préférence à droite) et avec
        //   le texte qui ont été entrés en paramètre
        //          -> description(btn, txt)
        //          -> LE BOUTON DOIT S'AFFICHER MINIMUM 1 SECONDE ET ÊTRE SUPPRIME AU CLIC OU ENTREE SUIVANT !!!
        //          -> Donc le label doit s'effacer avant l'action suivante donc je peux juste inclure un supprimer(label)
        //             avec un if label.name() == "lblTuto"; (label.name et pas lbl.text ! puisque le texte change à chaque fois)
        // - chatgpt proposait des listes avec les étapes?
        // - supprLabel(lbl) pour supprimer les labels comme exxpliqué plus haut
        //  
        // - possible d'afficher les étapes et de naviguer entre elles??
        //      -> utile si on loupe une étape ou qu'onn veut voir les 
        // 
        // EN GLOBALE.CS UNE VARIABLE BOOL TUTO ON OU OFF, EN FONCTION DU BOUTON TUTORIEL 

        // Liste des étapes du tutoriel
        private int currentStep = 0;
        private readonly string[] titres = new string[3];
        private readonly string[] descriptions = new string[3];
        private readonly Control[] controls = new Control[3];
        private float hue;
        private Label lblTuto;

        // Constructor
        public Tutoriels()
        {
            // Initialize the label
            lblTuto = new Label();

            // Set properties for the label
            lblTuto.Name = "lblTuto";
            lblTuto.Text = "This is the tutorial label!";
            lblTuto.AutoSize = true;  // Make the label size automatically adjust to its content
            //lblTuto.BackColor = System.Drawing.Color.Goldenrod ;
            //blTuto.Location = new System.Drawing.Point(10, 10);  // Set the position of the label on the form
        }

        //public void surbrillance(Control ctrl)
        //{
        //    hue = ctrl.BackColor.GetSaturation();
        //    ctrl.BackColor = System.Drawing.Color.BurlyWood;
        //}
        //public void plusSurbrillance(Control ctrl)
        //{ 
        //    ctrl.BackColor.set = hue;

        //}

        public void afficheExplications()
        {
            // créée un -label- !TOOLTIP! qui contient les explications du bouton ou autre, 
            // parametres : bouton, explications
            // gère : le nom du bouton pour récupérer les explications correspondantes
        }
    }
}
