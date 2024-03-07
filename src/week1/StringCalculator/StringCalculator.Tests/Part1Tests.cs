
namespace StringCalculator.Tests;
public class Part1Tests
{

    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();
        var result = calculator.Add("");
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1")]
    [InlineData("300")]
    public void CanReturnOneNumber(string oneNumber)
    {
        var calculator = new Calculator();
        var result = calculator.Add(oneNumber);
        Assert.Equal(int.Parse(oneNumber), result);
    }

    [Theory]
    [InlineData("1,2")]
    public void CanAddTwoNumbers(string twoNumbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(twoNumbers);
        Assert.Equal(3, result);
    }

    [Theory]
    [InlineData("3000,45")]
    public void CanAddTwoNumbersMultipleDigits(string twoNumbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(twoNumbers);
        Assert.Equal(3045, result);
    }

    [Theory]
    [InlineData("1,2,3,4,5,6,7,8,9")]
    public void CanAddAnyAmountOfNumbers(string severalNumbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(severalNumbers);
        Assert.Equal(45, result);
    }

    [Theory]
    [InlineData("1\n2,3", 6)]
    public void CanAddWithNewlines(string containsNewline, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(containsNewline);
        Assert.Equal(expected, result);
    }
}
