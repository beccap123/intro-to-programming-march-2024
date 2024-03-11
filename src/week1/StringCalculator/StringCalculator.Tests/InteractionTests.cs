
using NSubstitute;

namespace StringCalculator.Tests;
public class InteractionTests
{
    [Theory]
    [InlineData("1,2", "3")]
    [InlineData("42", "42")]
    public void ResultIsLogged(string numbers, string expected)
    {
        // Given
        var mockedLogger = Substitute.For<ILogger>();
        var mockedWebService = Substitute.For<IWebService>();
        var calculator = new Calculator(mockedLogger, mockedWebService);
        // When
        calculator.Add(numbers);
        // Then
        // ?
        mockedLogger.Received().Write(expected);
        mockedWebService.DidNotReceive().NotifyOfLoggingError(Arg.Any<string>());
    }

    [Fact]
    public void WhenTheLoggerCrashesWhenYouCallAWebService()
    {
        var stubbedLogger = Substitute.For<ILogger>();
        stubbedLogger.When(s => s.Write(Arg.Any<string>())).Throw<LoggerException>();

        var mockedWebService = Substitute.For<IWebService>();
        var calculator = new Calculator(stubbedLogger, mockedWebService);

        calculator.Add("10");

        mockedWebService.Received().NotifyOfLoggingError("Logger Failure 10");
    }
}
