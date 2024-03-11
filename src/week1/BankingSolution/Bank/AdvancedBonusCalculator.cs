

namespace Bank;

//using a primary constructor for _clock as another way to show how you can do a constructor 
public class AdvancedBonusCalculator(IProvideTheBusinessClock _clock) : ICalculateBonusesForDeposits
{

    public decimal CalculateDepositBonusFor(decimal currentBalance, decimal amountToDeposit)
    {
        // if it is between 9 am and 5 pm and not on a weekend or holiday then
        // if the current balance >= 5000 return a bonus of 10 percent
        // otherwise return nothing

        if (_clock.IsOpen() && currentBalance >= 5000M)
        {
            return amountToDeposit * .10M;
        }
        return 0;
    }
}
