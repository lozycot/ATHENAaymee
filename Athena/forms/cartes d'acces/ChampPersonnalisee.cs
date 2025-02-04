using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesAcces2024
{
    /// <summary>
    /// Représente un champ ajouté par l'utilisateur dans <see cref="CartesAcces2024.frmEtablissement"/>.
    /// </summary>
    public class ChampPersonnalisee
    {
        /// <summary>
        /// Option du champs, 'Texte', 'Code-Barres' ou 'Code QR'
        /// </summary>
        private string optionDuChamps;
        private Image imageDuChamp;
        private Point coordonneeDuChamp;
        private string valeurDuChamp;
        private Font policeDuChamp;
        private PictureBox pictureBoxDuChamp;
        private Dictionary<string, Image> imageParCouleur;

        // Constructeur
        public ChampPersonnalisee(string option, Image image, Point coordonnee, string valeur, Font police, PictureBox pictureBox)
        {
            this.optionDuChamps = option;
            this.imageDuChamp = image;
            this.coordonneeDuChamp = coordonnee;
            this.valeurDuChamp = valeur;
            this.policeDuChamp = police;
            this.pictureBoxDuChamp = pictureBox;
        }

        // Getters et Setters
        public string OptionDuChamps
        {
            get { return optionDuChamps; }
            set { optionDuChamps = value; }
        }

        public Image ImageDuChamp
        {
            get { return imageDuChamp; }
            set { imageDuChamp = value; }
        }

        public Point CoordonneeDuChamp
        {
            get { return coordonneeDuChamp; }
            set { coordonneeDuChamp = value; }
        }

        public string ValeurDuChamp
        {
            get { return valeurDuChamp; }
            set { valeurDuChamp = value; }
        }

        public Font PoliceDuChamp
        {
            get { return policeDuChamp; }
            set { policeDuChamp = value; }
        }

        public PictureBox PictureBoxDuChamp
        {
            get { return pictureBoxDuChamp; }
            set { pictureBoxDuChamp = value; }
        }

        public Dictionary<string, Image> ImageParCouleur
        {
            get { return imageParCouleur;  }
            set { imageParCouleur = value; }
        }

    }
}
