using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VirtualMarketApplication
{
    public class Customer : VirtualMarket
    {
        public string mail;
        public string username;
        public int password;
		private ArrayList OrderList = new ArrayList();

		public void AddToProductIntoOrderList(Product productParam, int orderCount)
		{
			Product product = new Product();
			product = productParam;
			bool founder = false;
			foreach (Product itemProduct in OrderList)
			{
				if (itemProduct.ID == product.ID && itemProduct.Category != null && product.Category != null)
				{
					product.Quantity = itemProduct.Quantity;
					itemProduct.Quantity += orderCount;
					founder = true;
					break;
				}
			}
			if (founder == false && product.Category != null)
			{
				product.Quantity = orderCount;
				OrderList.Add(product);
			}
		}

		public ArrayList GetterOrderListToCustomer()
		{
			return OrderList;
		}
	}
}
