using Bank;
using NSubstitute;

namespace Banking.UnitTests.Accounts;
public class GoldCustomerDeposits
{
    [Theory]
    [InlineData(100, 110)]
    [InlineData(42.23, 46.453)]
    public void MakingADespositIncreasesBalance(decimal amountToDeposit, decimal expected)
    {
        // Given
        var stubbedBonusCalculator = Substitute.For<ICalculateBonusesForDeposits>();
        var account = new BankAccount(new StubbedBonusCalculator());

        // Get Balance is a "Query" - we are asking it for something.
        var openingBalance = account.GetBalance();

        stubbedBonusCalculator.CalculateDepositBonusFor(openingBalance, amountToDeposit).Returns(13.23M);

        // When
        // WTCYWYH 
        // Command - Telling it to do some work.
        account.Deposit(142.23M);

        // Then
        // Assert.Equal(openingBalance + expected, account.GetBalance());

        // did the bonus calculator get called with the balaance, and the amount to deposit
        // did the bonus get added to the balance

        Assert.Equal(openingBalance + 142.23M + 13.23M, account.GetBalance());
    }

}
