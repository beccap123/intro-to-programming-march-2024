namespace Bank;
public interface ICalculateBonusesForDeposits
{
    decimal CalculateDepositBonusFor(decimal currentBalance, decimal amountToDeposit);
}