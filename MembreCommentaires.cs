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
    public partial class MembreCommentaires : Form
    {
        public MembreCommentaires()
        {
            InitializeComponent();

            comboBox1.DataSource = dbcontext.Commentaire.ToList();
            commentaireBindingSource.DataSource = dbcontext.Commentaire.ToList();

        }
        ModelGestionpublierDocumnets dbcontext = new ModelGestionpublierDocumnets();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rqt = dbcontext.Commentaire.ToList()
                .Where(s => s.login_.ToString() == comboBox1.ValueMember.ToString()).OrderByDescending(s => s.date_commentaire).ToList();
            //var rqt2 = from s in dbcontext.Commentaire.ToList()
            //           where s.login_ == comboBox1.ValueMember
            //           select s;
            commentaireBindingSource.DataSource = null;
            commentaireBindingSource.DataSource = rqt.ToList();
        }
    }
}
