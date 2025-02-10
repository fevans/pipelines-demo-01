namespace PDemo.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void ShouldReturnTrue()
    {
        var response = true;
        Assert.IsTrue(response);
    }

    [TestMethod]
    public void ShouldReturnFalse()
    {
        var response = false;
        Assert.IsFalse(response);
    }
}
