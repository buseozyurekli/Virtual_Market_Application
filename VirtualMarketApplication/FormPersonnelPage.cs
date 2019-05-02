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
    public partial class FormPersonnelPage : Form
    {
        // Personnel operations are performed here
        public FormPersonnelPage()
        {
            InitializeComponent();
        }

		VirtualMarketOperations virtualMarketOperations = new VirtualMarketOperations();

		private void FormPersonnelPage_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 2; i++)
			{
				if (i == 0)
				{
					foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
					{
						Product itemProduct = new Product();
						itemProduct = (Product)itemTree.SearchRoot().data;
						comboBoxNewCategory.Items.Add(itemProduct.ProductType);
					}
				}
				else
				{
					foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
					{
						Product itemProduct = new Product();
						itemProduct = (Product)itemTree.SearchRoot().data;
						comboBoxQuantityCategory.Items.Add(itemProduct.ProductType);
					}
				}
			}
		}

		private void btnAddNewProduct_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			product.Category = comboBoxNewCategory.Text;
			product.ProductType = txtBoxNewType.Text;
			product.Brand = txtBoxNewBrand.Text;
			product.Model = txtBoxNewModel.Text;
			product.Price = Convert.ToInt16(txtBoxNewPrice.Text);
			product.Quantity = Convert.ToInt16(txtBoxNewQuantity.Text);
			product.ProductDescription = txtBoxNewDescription.Text;
			virtualMarketOperations.AddProductToCategory(product);
			MessageBox.Show("Product has been added to " + comboBoxNewCategory.Text + " Category.");
		}

		private void btnAddtoQuantitytoProduct_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
			{
				foreach (BinarySearchTreeNode itemNode in itemTree.SearchNodes())
				{
					product = (Product)itemNode.data;
					if (product.Brand == txtBoxQuantityBrand.Text && product.Category == comboBoxQuantityCategory.Text && product.Model == txtBoxQuantityModel.Text && product.ProductType == txtBoxQuantityType.Text)
					{
						product.Quantity += Convert.ToInt16(txtBoxQuantityQuantity.Text);
						break;
					}
				}
			}
			MessageBox.Show(txtBoxQuantityQuantity.Text + " product has been added to stock.");
		}
	}
}
