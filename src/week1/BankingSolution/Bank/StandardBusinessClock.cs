namespace Bank;

public class StandardBusinessClock(IClock _clock) : IProvideTheBusinessClock
{
    public bool IsOpen()
    {
        var now = _clock.GetCurrentLocalTime();
        if (now.Hour >= 9 && now.Hour < 17)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}