using System;
using ACM.BL;
namespace ACM.BLTest
{
	[TestClass]
	public class ProductRepositoryTest
	{
		[TestMethod]
		public void RetreiveValid()
		{
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(2 )
            {
                productName = "asd@asd.com",
                productDescription = "asd",
                currentPrice = 123
            };

            // Act
            Product result = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.productName, result.productName);
            Assert.AreEqual(expected.productDescription, result.productDescription);
            Assert.AreEqual(expected.currentPrice, result.currentPrice);
        }
	}
}

