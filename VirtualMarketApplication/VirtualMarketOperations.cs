using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VirtualMarketApplication
{
	public class VirtualMarketOperations : VirtualMarket
	{
		public void AddToDefaultCategories()
		{
			for (int i = 0; i < 8; i++)
			{
				BinarySearchTree tree;
				BinarySearchTreeNode node = new BinarySearchTreeNode();
				Product product;
				switch (i) // Product categories are determined here
				{
					case 0:
						product = new Product();
						product.ProductType = "Computer";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 1:
						product = new Product();
						product.ProductType = "White Goods";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 2:
						product = new Product();
						product.ProductType = "Dress";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 3:
						product = new Product();
						product.ProductType = "Stationary";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 4:
						product = new Product();
						product.ProductType = "Decoration";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 5:
						product = new Product();
						product.ProductType = "Garden";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 6:
						product = new Product();
						product.ProductType = "Textile";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
					case 7:
						product = new Product();
						product.ProductType = "Foods";
						node.data = product;
						tree = new BinarySearchTree(node);
						Category.Add(tree);
						break;
				}
			}
		}

		public ArrayList CategoryList()
		{
			return Category;
		}

		public void AddProductToCategory(Product product) // Products are added here by category
		{
			foreach (BinarySearchTree itemTree in Category)
			{
				Product itemProduct = new Product();
				itemProduct = (Product)itemTree.SearchRoot().data;
				if (itemProduct.ProductType == product.Category)
				{
					itemTree.Insert(product);
				}
			}
		}
	}
}
