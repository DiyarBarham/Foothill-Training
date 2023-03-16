using System;
namespace ACM.BL
{
	public class Product
	{
        public decimal? currentPrice { get; set; }
        public String productDescription { get; set; }
        public String productName { get; set; }
        public int productID { get; private set; }

        public Product()
		{
		}

        public Product(int productID)
        {
            this.productID = productID;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(productName)) isValid = false;
            if (currentPrice == null) isValid = false;

            return isValid;
        }
    }
}

