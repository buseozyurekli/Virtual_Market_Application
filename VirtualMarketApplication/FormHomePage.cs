using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace VirtualMarketApplication
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }
		VirtualMarketOperations virtualMarketOperations = new VirtualMarketOperations();
        BinarySearchTree SearchTree = new BinarySearchTree();
		Customer customer = new Customer();

        private void FormHomePage_Load(object sender, EventArgs e)
        {
			labelUserInformation.Text = "User Name : " + Form1.userName;
			foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
			{
				Product itemProduct = new Product();
				itemProduct = (Product)itemTree.SearchRoot().data;
				comboBox1.Items.Add(itemProduct.ProductType);
			}
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			dataGridViewProducts.Rows.Clear();
			RefreshToDisplayingProductList();
        }

        private void btnSearch_Click(object sender, EventArgs e) // Product search is performed here
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode();
			Product product = new Product();
			string key = txtSearch.Text;
			foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
			{
				foreach (BinarySearchTreeNode itemNode in itemTree.SearchNodes())
				{
					node = itemNode;
					product = (Product)itemNode.data;
					if (product.Brand == key || product.Category == key || product.Model == key || product.ProductDescription == key || product.ProductType == key)
					{
						MessageBox.Show("Product ;\n   --> Category : " + product.Category + "\n   --> Type : " + product.ProductType + "\n   --> Brand/Model : " + product.Brand+ " / " + product.Model + "\n   --> Price : " + product.Price + "\n   --> Quantity : " + product.Quantity + "\n   --> Description : " + product.ProductDescription);
						break;
					}
				}
			}
			if (node.data == null) 
            {
                MessageBox.Show(txtSearch.Text + " not found..");
            }
        }

		private void RefreshToDisplayingProductList()
		{
			int rowCount = 0;
			foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
			{
				Product product = new Product();
				product = (Product)itemTree.SearchRoot().data;
				if (product.ProductType == comboBox1.Text)
				{
					foreach (BinarySearchTreeNode itemNode in itemTree.SearchNodes())
					{
						Product goingToInsertProduct = new Product();
						goingToInsertProduct = (Product)itemNode.data;
						if (itemNode.data != null && itemNode.data != product)
						{
							dataGridViewProducts.Rows.Add();
							dataGridViewProducts.Rows[rowCount].Cells[0].Value = goingToInsertProduct.Category;
							dataGridViewProducts.Rows[rowCount].Cells[1].Value = goingToInsertProduct.ProductType;
							dataGridViewProducts.Rows[rowCount].Cells[2].Value = goingToInsertProduct.ID;
							dataGridViewProducts.Rows[rowCount].Cells[3].Value = goingToInsertProduct.Brand;
							dataGridViewProducts.Rows[rowCount].Cells[4].Value = goingToInsertProduct.Model;
							dataGridViewProducts.Rows[rowCount].Cells[5].Value = goingToInsertProduct.ProductDescription;
							dataGridViewProducts.Rows[rowCount].Cells[6].Value = goingToInsertProduct.Quantity;
							dataGridViewProducts.Rows[rowCount].Cells[7].Value = "1";
							dataGridViewProducts.Rows[rowCount].Cells[8].Value = "$ " + goingToInsertProduct.Price;
							rowCount++;
						}
					}
				}
			}
		}

		private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) //Products information is kept here.
		{
			if (e.ColumnIndex == 9)
			{
				int stock = (int)dataGridViewProducts.Rows[e.RowIndex].Cells[6].Value;
				int quantity = Convert.ToInt16((string)dataGridViewProducts.Rows[e.RowIndex].Cells[7].Value);
				if (stock >= quantity) // Stock check is performed here
				{
					stock -= quantity;
					foreach (BinarySearchTree itemTree in virtualMarketOperations.CategoryList())
					{
						Product product = new Product();
						product = (Product)itemTree.SearchRoot().data;
						if ((string)dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value == product.ProductType)
						{
							foreach (BinarySearchTreeNode itemNode in itemTree.SearchNodes())
							{
								Product setterProduct = new Product();
								setterProduct = (Product)itemNode.data;
								if ((string)dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value == setterProduct.ID)
								{
									setterProduct.Quantity = stock;
									customer.AddToProductIntoOrderList(setterProduct, quantity);
									itemNode.data = setterProduct;
									dataGridViewProducts.Rows[e.RowIndex].Cells[6].Value = stock;
								}
							}
						}
					}
					MessageBox.Show("Thank you for choosing us. We hope you come again!");
				}
				else if (stock == 0)
				{
					MessageBox.Show("Your chosen product out of stock!");
				}
				else if (quantity == 0)
				{
					MessageBox.Show("Please enter a valid quantity!");
				}
				else
				{
					MessageBox.Show("Not enough product left in our stock. Please change the quantity and try again!");
				}
			}
		}

		private void btnExitMyAccount_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void FormHomePage_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageBox.Show("We wish you a nice day!");
			Dispose();
		}

		private void btnShowToMyBasket_Click(object sender, EventArgs e)
		{
			string message = "";
			message = "	• Order List;\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n";
			foreach (Product itemProduct in customer.GetterOrderListToCustomer())
			{
				message += "	• Product;\n→ Category : " + itemProduct.Category + "\n→ Type : " + itemProduct.ProductType + "\n→ ID : " + itemProduct.ID + "\n→ Brand : " + itemProduct.Brand + "\n→ Model : " + itemProduct.Model + "\n→ Quantity : " + itemProduct.Quantity + "\n→ Price : " + itemProduct.Price + Environment.NewLine;
			}
			MessageBox.Show(message);
		}
	}
}
