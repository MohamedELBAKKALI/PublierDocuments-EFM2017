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
    public partial class GestionDesDocument : Form
    {
        public GestionDesDocument()
        {
            InitializeComponent();
            Actualise();
        }

        ModelGestionpublierDocumnets dbcontext = new ModelGestionpublierDocumnets();
        public void Actualise()
        {
            documentBindingSource.DataSource = dbcontext.Document.ToList();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            documentBindingSource.MoveLast();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            documentBindingSource.MoveNext();
        }

        private void btnPrivie_Click(object sender, EventArgs e)
        {
            documentBindingSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            documentBindingSource.MoveFirst();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            documentBindingSource.AddNew();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            documentBindingSource.EndEdit();
            var doc = documentBindingSource.Current as Document;
            dbcontext.Document.Add(doc);
            dbcontext.SaveChanges();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            documentBindingSource.RemoveCurrent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            dbcontext.SaveChanges();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            documentBindingSource.EndEdit();
            dbcontext.SaveChanges();
        }
    }
}
