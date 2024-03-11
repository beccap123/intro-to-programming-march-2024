

namespace Bank;
public class Clock : IClock
{
    public DateTime GetCurrentLocalTime()
    {
        return DateTime.Now;
    }
}

public interface IClock
{
    DateTime GetCurrentLocalTime();
}
