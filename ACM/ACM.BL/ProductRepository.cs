using System;
namespace ACM.BL
{
	public class ProductRepository
	{
		public ProductRepository()
		{
		}

        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);

            if (productID == 2)
            {
                product.productName = "asd@asd.com";
                product.productDescription = "asd";
                product.currentPrice = 123;

            }
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}

