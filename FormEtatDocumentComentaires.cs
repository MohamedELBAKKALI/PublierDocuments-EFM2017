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
    public partial class FormEtatDocumentComentaires : Form
    {
        public FormEtatDocumentComentaires()
        {
            InitializeComponent();
            comboBox1.DataSource = dbcontext.Document.ToList();
        }
        ModelGestionpublierDocumnets dbcontext = new ModelGestionpublierDocumnets();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
