
//https://osherove.com/tdd-kata-1

namespace StringCalculator.Tests;
public class Calculator(ILogger logger, IWebService service)
{
    public int Add(string numbers)
    {
        int sum = 0;

        if (String.IsNullOrEmpty(numbers))
        {
            return sum;
        }
        else
        {
            string[] numbersArray = numbers.Split(',', '\n');
            foreach (var oneNumber in numbersArray)
            {
                sum += int.Parse(oneNumber);
            }
        }

        try
        {
            logger.Write(sum.ToString());
        }
        catch (LoggerException)
        {
            //service.NotifyOfLoggingError($"Logger failure {sum}");
        }
        service.NotifyOfLoggingError($"Logger failure {sum}");


        return sum;
    }
}

public interface IWebService
{
    void NotifyOfLoggingError(string message);
}

public interface ILogger
{
    void Write(string message);
}

public class LoggerException : ApplicationException { }
