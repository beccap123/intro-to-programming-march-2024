using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(42.23)]
    public void MakingADepositIncreasesBalance(decimal amountToDeposit)
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        // WTCYWYH
        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
