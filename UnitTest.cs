[TestClass]

public class ConverterTests
{
    [TestMethod]
    public void Do_InputGreaterThan100_7_Returns1000()
    {
        // Arrange
        float x = 105.2f;

        // Act
        int result = Converter.Do(x);

        // Assert
        Assert.AreEqual(1000, result);
    }

    [TestMethod]
    public void Do_InputLessThan100_7_ReturnsIntegerPart()
    {
        // Arrange
        float x = 65.7f;

        // Act
        int result = Converter.Do(x);

        // Assert
        Assert.AreEqual(65, result);
    }

    [TestMethod]
    public void Do_InputEqualToZero_ThrowsArgumentException()
    {
        // Arrange
        float x = 0;

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => Converter.Do(x));
    }

    [TestMethod]
    public void Do_InputLessThanZeroAndGreaterThanOrEqualToMinus30_4_ReturnsIntegerPartMinus5()
    {
        // Arrange
        float x = -20.5f;

        // Act
        int result = Converter.Do(x);

        // Assert
        Assert.AreEqual(-25, result);
    }

    [TestMethod]
    public void Do_InputLessThanOrEqualToMinus30_5_ReturnsMinus2000()
    {
        // Arrange
        float x = -31.0f;

        // Act
        int result = Converter.Do(x);

        // Assert
        Assert.AreEqual(-2000, result);
    }
}
