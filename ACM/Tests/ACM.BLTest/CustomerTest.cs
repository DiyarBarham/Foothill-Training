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

    [TestMethod]
    public void ValidateTestValid()
    {
        //Arrange
        Customer customer = new Customer
        {
            lastName = "Mohammad",
            emailAddress = "asdQ@asd.com"
        };
        bool expected = true;

        //Act
        bool result = customer.Validate();

        //Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void MissingLastNameTestValid()
    {
        //Arrange
        Customer customer = new Customer
        {
            firstName = "Mohammad",
        };
        bool expected = false;

        //Act
        bool result = customer.Validate();

        //Assert
        Assert.AreEqual(expect ed, result);
    }
} 