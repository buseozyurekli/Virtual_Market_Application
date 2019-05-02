using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMarketApplication
{
    public partial class FormAdminEntry : Form 
    {
        // Admin login operations are done here.
        public FormAdminEntry()
        {
            InitializeComponent();
        }
        Personnel personnel = new Personnel();
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if(personnel.adminPass == txtAdminPass.Text)
            {
                FormAddPersonnel formAddPersonnel = new FormAddPersonnel();
                this.Visible = false;
                formAddPersonnel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Admin password is wrong..");
            }
        }
    }
}
