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

        [TestMethod]
        public void RetrieveExistingWithAddress()
		{
			// Arrange
			CustomerRepository customerRepository = new CustomerRepository();
			Customer expected = new Customer(1)
			{
				emailAddress = "asd@asd.com",
				firstName = "asd",
				lastName = "qwe",
				addressList = new List<Address>()
				{
					new Address()
					{
                        addressType = 1,
						streetLine1 = "asd1",
						streetLine2 = "asd2",
						city = "Ramalllah",
						state = "Jenin",
						country = "Palestine",
						postalCode = "123"
					},
					
					new Address()
					{
                        addressType = 2,
                        streetLine1 = "asd3",
                        streetLine2 = "asd4",
                        city = "Ramalllah1",
                        state = "Jenin11",
                        country = "Palestine1",
                        postalCode = "1234"
                    }
				},
			};

			// Act
			Customer actual = customerRepository.Retrieve(1);

			// Assert
			Assert.AreEqual(expected.customerID, actual.customerID);
            Assert.AreEqual(expected.emailAddress, actual.emailAddress);
            Assert.AreEqual(expected.firstName, actual.firstName);
            Assert.AreEqual(expected.lastName, actual.lastName);

			for(int i=0; i < 2; i++)
			{
				Assert.AreEqual(expected.addressList[i].city, actual.addressList[i].city);
                Assert.AreEqual(expected.addressList[i].country, actual.addressList[i].country);
                Assert.AreEqual(expected.addressList[i].streetLine1, actual.addressList[i].streetLine1);
                Assert.AreEqual(expected.addressList[i].streetLine2, actual.addressList[i].streetLine2);
                Assert.AreEqual(expected.addressList[i].state, actual.addressList[i].state);
                Assert.AreEqual(expected.addressList[i].postalCode, actual.addressList[i].postalCode);
            }

        }
    }
}

