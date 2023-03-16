using ACM.BL;
namespace ACM.BLTest;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void FullNameTestValid ()
    {
        //Arrange
        Customer customer = new Customer
        {
            firstName = "Mohammad",
            lastName = "Ali"
        };
        String expected = "Mohammad, Ali";

        //Act
        String result = customer.fullName;

        //Assert
        Assert.AreEqual(expected, result);
    }
} 