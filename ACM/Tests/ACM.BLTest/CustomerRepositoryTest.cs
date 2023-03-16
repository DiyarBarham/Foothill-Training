using System;
using ACM.BL;
namespace ACM.BLTest
{
	[TestClass]
	public class CustomerRepositoryTest
	{
		[TestMethod]
		public void RetreiveValid()
		{
			// Arrange
			CustomerRepository customerRepository = new CustomerRepository();
			Customer expected = new Customer(1)
			{
				emailAddress = "asd@asd.com",
				firstName = "asd",
				lastName = "qwe"
			};

			// Act
			Customer result = customerRepository.Retrieve(1);

			// Assert
			Assert.AreEqual(expected.fullName, result.fullName);
            Assert.AreEqual(expected.emailAddress, result.emailAddress);
            Assert.AreEqual(expected.customerID, result.customerID);
        }
	}
}

