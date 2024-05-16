namespace CalculatorTests;
using Calculator.Services;

public class CalculatorTests
{
    private CalculatorImpl _calc;

    public CalculatorTests() 
    {
        _calc = new CalculatorImpl();
    }

    [Fact]
    public void SumFivePlusTenReturnFiftheen()
    {
        // Arrange 
        float num1 = 5;
        float num2 = 10;

        // Act
        float sumResult = _calc.Sum(num1, num2);

        // Assert
        Assert.Equal(15, sumResult);

    }

    [Fact]
    public void SubFiveLessTenReturnMinusFive()
    {
        float num1 = 5;
        float num2 = 10;

        float subResult = _calc.Subtract(num1, num2);

        Assert.Equal(-5, subResult);
    }

    [Fact]
    public void DivideFiveByTenReturnZeroPointFive()
    {
        float num1 = 5;
        float num2 = 10;

        float divResult = _calc.Divide(num1, num2);

        Assert.Equal(0.5, divResult);
    }

    [Fact]
    public void MultFiveByTenReturnFifty()
    {
        float num1 = 5;
        float num2 = 10;

        float multResult = _calc.Multiply(num1, num2);

        Assert.Equal(50, multResult);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void MustCheckIfEvenReturnTrue(float nums)
    {

        bool result = _calc.IsEven(nums);

        Assert.True(result);
    }
}