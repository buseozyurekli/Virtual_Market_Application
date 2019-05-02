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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int count = 0,countPer = 0;
        public static string userName;
        public static string personnel;
        VirtualMarket market = new VirtualMarket();

        private void btnSign_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Visible = false;
            formSignUp.ShowDialog();
            this.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
			if (txtUserName.Text == "" && txtPass.Text == "")
			{
				MessageBox.Show("Please enter your user name and password!");
			}
			else if (txtUserName.Text == "")
			{
				MessageBox.Show("Please enter your user name!");
			}
			else if (txtPass.Text == "")
			{
				MessageBox.Show("Please enter your password!");
			}
			else
			{
				string message = market.FindCustomer(txtUserName.Text, Convert.ToInt32(txtPass.Text));
				MessageBox.Show(message);
				if (message == "Login Successful..")
				{
					FormHomePage formHomePage = new FormHomePage();
					this.Visible = false;
					formHomePage.ShowDialog();
					this.Visible = true;
				}
			}
        }

        private void btnAddPer_Click(object sender, EventArgs e)
        {
            FormAdminEntry formAdminEntry = new FormAdminEntry();
            formAdminEntry.ShowDialog();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			VirtualMarketOperations virtualMarketOperations = new VirtualMarketOperations();
			virtualMarketOperations.AddToDefaultCategories();
			Product product = new Product();
			product.Brand = "Apple";
			product.Model = "Macbook";
			product.Price = 5000;
			product.Quantity = 100;
			product.ProductDescription = "Apple - Macbook";
			product.ProductType = "Laptop";
			product.Category = "Computer";
			virtualMarketOperations.AddProductToCategory(product);
		}

		private void btnLoginPer_Click(object sender, EventArgs e)
        {
			personnel = txtPassPer.Text;
			if (txtPassPer.Text == "")
			{
				MessageBox.Show("Please enter your password!");
			}
			else
			{
				string message = market.FindPersonnel(Convert.ToInt64(txtPassPer.Text));
				MessageBox.Show(message);
				if (message == "Login Successful..")
				{
					FormPersonnelPage formPersonnelPage = new FormPersonnelPage();
					this.Visible = false;
					formPersonnelPage.ShowDialog();
					this.Visible = true;
				}
			}
        }
    }
}
