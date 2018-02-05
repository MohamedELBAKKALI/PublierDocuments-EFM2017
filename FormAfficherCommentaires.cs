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
    public partial class FormAfficherCommentaires : Form
    {
        public FormAfficherCommentaires()
        {
            InitializeComponent();
            mombreBindingSource.DataSource = dbcontext.Mombre.ToList();
            documentBindingSource.DataSource = dbcontext.Document.ToList();
            //var sql = from s in dbcontext.Commentaire.ToList()
            //          where s.date_commentaire.Value.Year == DateTime.Now.Year
            //          select s;
            commentaireBindingSource.DataSource = dbcontext.Commentaire.ToList()
                .Where(s => s.date_commentaire.Value.Year == DateTime.Now.Year);
        }
        ModelGestionpublierDocumnets dbcontext = new ModelGestionpublierDocumnets();

    }
}
