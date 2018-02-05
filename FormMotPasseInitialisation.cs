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
    public partial class FormMotPasseInitialisation : Form
    {
        public FormMotPasseInitialisation()
        {
            InitializeComponent();
            mombreBindingSource.DataSource = dbcontext.Mombre.ToList();
            login_ComboBox.DataSource = mombreBindingSource;

        }
        ModelGestionpublierDocumnets dbcontext = new ModelGestionpublierDocumnets();

        private void login_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInitialisation_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != passeTextBox.Text)
            {
                MessageBox.Show("Confirmation pas valide");
            }
            else
            {
                mombreBindingSource.EndEdit();
                dbcontext.SaveChanges();
            }
        }
    }
}
