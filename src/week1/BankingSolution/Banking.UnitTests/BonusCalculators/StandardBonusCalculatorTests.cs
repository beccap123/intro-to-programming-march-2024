

using Bank;

namespace Banking.UnitTests.BonusCalculators;
public class StandardBonusCalculatorTests
{

    [Theory]
    [InlineData(5000, 100, 15)]
    [InlineData(4999.99, 100, 0)]
    public void CanCalculateBonusForDeposits(decimal balance, decimal amount, decimal expected)
    {
        var calculator = new StandardBonusCalculator();

        var bonus = calculator.CalculateDepositBonusFor(balance, amount);

        Assert.Equal(expected, bonus);
    }
}

