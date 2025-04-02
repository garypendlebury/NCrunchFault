using System.Collections.Immutable;

namespace NCrunchFault;

public class Program
{
    // This field being static and ImmutableHashSet causes the problem. If non-static or the type changed to HashSet, NCrunch works.
    private static readonly ImmutableHashSet<DayOfWeek> Days = [DayOfWeek.Wednesday, DayOfWeek.Thursday];

    static void Main(string[] args)
    {
    }

    private bool PrivateMethod(DayOfWeek dayOfWeek) => Days.Contains(dayOfWeek);

    public bool ExternalCall(DateOnly date) => PrivateMethod(date.DayOfWeek);
}
