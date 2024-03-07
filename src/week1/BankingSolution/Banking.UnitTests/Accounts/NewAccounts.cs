
using Bank;
using NSubstitute;

namespace Banking.UnitTests.Accounts;

public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        // WTCWYH - "Write the code you WISH YOU HAD"

        // Given - I have a brand new account
        var account = new BankAccount(Substitute.For<ICalculateBonusesForDeposits>());

        // WHEN I get the balance
        decimal openingBalance = account.GetBalance();

        Assert.Equal(5000M, openingBalance);
    }
}
