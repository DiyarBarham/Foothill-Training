using System.Collections.Generic;
using Acme.common;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
  [TestClass]
  public class LoggingServiceTest
  {
    [TestMethod]
    public void WriteToFileTest()
    {
      // Arrange
      var changedItems = new List<ILoggable>();

      var customer = new Customer(1)
      {
        emailAddress = "test@test.com",
        firstName = "Ali",
        lastName = "Mohammad",
        addressList = null
      };
      changedItems.Add(customer);

      var product = new Product(2)
      {
        productName = "test",
        productDescription = "test test",
        currentPrice = 6M
      };
      changedItems.Add(product);

      // Act
      LoggingService.WriteToFile(changedItems);

      // Assert
      // Nothing here to assert
    }
  }
}
