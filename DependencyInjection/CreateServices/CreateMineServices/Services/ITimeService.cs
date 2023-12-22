namespace CreateMineServices.Services;

public interface ITimeService
{
    string GetTime();
}

public class TimeShort : ITimeService
{
    public string GetTime() => DateTime.Now.ToShortTimeString();
}

public class TimeLong : ITimeService
{
    public string GetTime() => DateTime.Now.ToLongTimeString();
}