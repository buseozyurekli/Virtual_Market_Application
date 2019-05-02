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
    public partial class FormSignUp : Form
    {
        // Signup and checks are performed here
        public FormSignUp()
        {
            InitializeComponent();
        }
        Customer custom = new Customer();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            if(txtMail.Text == "" || txtUser.Text == "" || txtPassword.Text == "" || txtAgainPass.Text == "")
            {
                MessageBox.Show("Please enter your details completely..");
            }
            else
            {
                if(txtPassword.Text.Length <= 8 && txtAgainPass.Text.Length <= 8 && txtPassword.Text == txtAgainPass.Text)
                {
                    if(Form1.count == 0)
                    {
                        custom.mail = txtMail.Text;
                        custom.password = Convert.ToInt32(txtPassword.Text);
                        custom.username = txtUser.Text;
                        custom.SignUp(custom);
                        MessageBox.Show("Your membership is successful..");
                        Dispose();
                        Form1.count++;
                    }
                    else
                    {
                        custom.username = txtUser.Text;
                        string control = custom.CustomerControl(custom.username);
                        if(control == custom.mail)
                        {
                            custom.mail = txtMail.Text;
                            custom.password = Convert.ToInt32(txtPassword.Text);
                            custom.SignUp(custom);
                            MessageBox.Show("Your membership is successful..");
                            Dispose();
                        }
                        else if(control == "")
                        {
                            custom.mail = txtMail.Text;
                            custom.password = Convert.ToInt32(txtPassword.Text);
                            custom.SignUp(custom);
                            MessageBox.Show("Your membership is successful..");
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("This username belongs to someone else..");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your password must be less than 8 characters..");
                }
            }
        }

    }
}
