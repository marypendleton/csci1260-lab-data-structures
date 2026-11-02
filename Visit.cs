// Visit: one student waiting at office hours, and how much time they
// still need.
public class Visit
{
    public string Name { get; }
    public int MinutesLeft { get; private set; }

    public Visit(string name, int minutesNeeded)
    {
        Name = name;
        MinutesLeft = minutesNeeded;
    }

    // Spend up to slice minutes with this student.
    // Returns the minutes actually used.
    public int Help(int slice)
    {
        int used = Math.Min(slice, MinutesLeft);
        MinutesLeft -= used;
        return used;
    }
}
