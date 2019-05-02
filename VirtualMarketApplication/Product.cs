using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMarketApplication
{
    public class Product
    {
		public string Category;
		public string ProductType;
		public string ID;
		public string Brand;
        public string Model;
		public string ProductDescription;
		public int Quantity;
		public int Price;

		public Product()
		{
			Random productID = new Random();
			int i = productID.Next(100000, 999999);
			ID = "#" + i;
		}
    }
}
