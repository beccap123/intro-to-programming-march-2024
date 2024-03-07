using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingWithdrawls
{

    [Theory]
    [InlineData(100)]
    [InlineData(2.25)]
    public void MakingAWithdrawalDecreasesTheBalance(decimal amountToWithdraw)
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        Assert.Throws<OverdraftException>(() => account.Withdraw(account.GetBalance() + .01M));

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void CanWithdrawAllMoney()
    {
        var account = new BankAccount(new DummyBonusCalculator());

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void AreAnyDecimalsAllowed()
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        Assert.Throws<InvalidTransactionAmountException>(() => account.Withdraw(-1.1M));

        Assert.Equal(openingBalance, account.GetBalance());
    }


    [Theory]
    [InlineData(-1.0)]
    [InlineData(0)]
    public void ValidatesAmountForWithdraw(decimal amountToWithdraw)
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        Assert.Throws<InvalidTransactionAmountException>(() => account.Withdraw(amountToWithdraw));

        Assert.Equal(openingBalance, account.GetBalance());
    }
}