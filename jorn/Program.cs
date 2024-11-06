using jorn.Domain;
using jorn.Helpers;

internal class Program
{
    private static void Main(string[] args)
    {
        if (!InputValidator.IsValid(args))
        {
            Console.WriteLine("Invalid, follow the pattern: jorn 0000 0000 0000");
            return;
        }

        var journey = new Journey();
        journey.SetEntryTime(args[0]);
        journey.SetLunchStartTime(args[1]);
        journey.SetLunchEndTime(args[2]);

        var exitTime = journey.GetExitTime();

        Console.WriteLine($"Your punch out time will be {exitTime:hh\\:mm}.");
    }
}
