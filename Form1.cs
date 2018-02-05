using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublierDocuments2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDesDocument GD = new GestionDesDocument();
            GD.ShowDialog();
        }


        private void administrateursMotDePasseInitialisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMotPasseInitialisation FMPI = new FormMotPasseInitialisation();
            FMPI.ShowDialog();
        }

        private void afficherLesCommentairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherCommentaires FC = new FormAfficherCommentaires();
            FC.ShowDialog();
        }

        private void membreComentairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembreCommentaires mc = new MembreCommentaires();
            mc.ShowDialog();
        }

        private void etatDocumentCommentaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtatDocumentComentaires ec = new FormEtatDocumentComentaires();
            ec.ShowDialog();
        }
    }
}
