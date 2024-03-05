namespace TodosApi.ContractTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 10, b = 20, answer;

        answer = a + b;

        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]

    public void CanAddIntegers(int a, int b, int expected)

    {

        int answer = a + b;

        Assert.Equal(expected, answer);

    }
}