using System;
using ACM.BL;
namespace ACM.BLTest
{
	[TestClass]
	public class OrderRepositoryTest
	{
		[TestMethod]
		public void RetreiveValid()
		{
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order expected = new Order(10)
            {
                orderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act
            Order result = orderRepository.Retrieve(10);

            // Assert
            Assert.AreEqual(expected.orderDate, result.orderDate);
        }
	}
}

