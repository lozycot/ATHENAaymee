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
    public partial class frmTuto : Form
    {   
        // doit afficher l'image de tutoriel correspondant au formulaire qui a envoyé la requête
        // fonction afficheTuto(string nomDuFormulaireClient)
        public frmTuto(string nomForm) // format sans le .cs à la fin!!! avec this.GetType().Name;
        {
            InitializeComponent();
            string path = Chemin.DossierPhotosTutos + "photo_" + nomForm + ".png";
            pictureBox1.Image = Image.FromFile(path);

        }
        public void afficheTuto(string frmClient)
            {
                // cherche dans le dossier PhotosTuto sous /data/PhotosTuto une image avec le nom complet du frmClient
                // ex: photo_frmPlanches
            }

        private void frmTuto_Load(object sender, EventArgs e)
        {

        }

    }
}
