using Acme.common;
namespace Acme.CommonTest;

[TestClass]
public class StringHandlerTest
{
    [TestMethod]
    public void InsertSpacesTestValid()
    {
        String source = "SonicScrewdriver";
        String expected = "Sonic Screwdriver";

        String result = source.InsertSpaces();

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void InsertSpacesTestWithExistingSpaces()
    {
        String source = "Sonic Screwdriver";
        String expected = "Sonic Screwdriver";

        String result = source.InsertSpaces();

        Assert.AreEqual(expected, result);
    }
}
