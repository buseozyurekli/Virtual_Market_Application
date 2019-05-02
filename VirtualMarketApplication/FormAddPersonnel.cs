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
    public partial class FormAddPersonnel : Form
    {
        // Personnel add operations are performed here
        public FormAddPersonnel()
        {
            InitializeComponent();
        }
        Personnel personnel = new Personnel();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtSurname.Text == "" || txtTc.Text == null)
            {
                MessageBox.Show("Please enter your details completely..");
            }
            if(txtTc.Text.Length == 11)
            {
                if (Form1.countPer == 0)
                {
                    personnel.name = txtName.Text;
                    personnel.surname = txtSurname.Text;
                    personnel.TC = Convert.ToInt64(txtTc.Text);
                    personnel.personnelPass = Convert.ToInt64(txtTc.Text);
                    personnel.AddPersonnel(personnel);
                    MessageBox.Show("Insert Successful..");
                    Dispose();
                    Form1.countPer++;
                }
                else
                {
                    personnel.TC = Convert.ToInt64(txtTc.Text);
                    personnel.personnelPass = Convert.ToInt64(txtTc.Text);
                    string nameSurname = txtName.Text + txtSurname.Name;
                    string control = personnel.PersonnelControl(personnel.TC);
                    if(control == nameSurname)
                    {
                        personnel.name = txtName.Text;
                        personnel.surname = txtSurname.Text;
                        personnel.AddPersonnel(personnel);
                        MessageBox.Show("Insert Successful..");
                        Dispose();
                    }
                    else if(control == "")
                    {
                        personnel.name = txtName.Text;
                        personnel.surname = txtSurname.Text;
                        personnel.AddPersonnel(personnel);
                        MessageBox.Show("Insert Successful..");
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Personnel already registered..");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter 11 digit tc number..");
            }
        }
    }
}
