// Course: one course in the catalog. The data is sample data.
public class Course
{
    public string Code { get; }
    public string Title { get; }
    public int Credits { get; }
    public int Enrolled { get; }
    public int Seats { get; }

    public Course(string code, string title, int credits, int enrolled, int seats)
    {
        Code = code;
        Title = title;
        Credits = credits;
        Enrolled = enrolled;
        Seats = seats;
    }

    // The department is the first four letters of the code.
    public string Dept => Code.Substring(0, 4);

    // How many seats are still open.
    public int SeatsLeft => Seats - Enrolled;

    public override string ToString()
    {
        return Code + "  " + Title;
    }
}
