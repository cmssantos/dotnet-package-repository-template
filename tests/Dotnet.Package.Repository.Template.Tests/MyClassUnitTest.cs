namespace Dotnet.Package.Repository.Template.Tests;

public class MyClassUnitTest
{
    [Fact]
    public void GetName_ReturnsClassName()
    {
        // Arrange
        var expected = "MyClass";

        // Act
        var actual = MyClass.GetName();

        // Assert
        Assert.Equal(expected, actual);
    }
}
