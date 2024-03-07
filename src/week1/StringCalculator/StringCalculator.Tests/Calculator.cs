
//https://osherove.com/tdd-kata-1
namespace StringCalculator.Tests;
public class Calculator
{
    public int Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        else
        {
            int sum = 0;
            string[] numbersArray = numbers.Split(',', '\n');
            foreach (var oneNumber in numbersArray)
            {
                sum += int.Parse(oneNumber);
            }
            return sum;
        }
    }
}
