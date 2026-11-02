// SampleData: the course list used by the demos and the lab check.
// The enrollment numbers are made up.
public static class SampleData
{
    public static List<Course> Courses()
    {
        return new List<Course>
        {
            new Course("CSCI 1250", "Introduction to Programming", 4, 58, 60),
            new Course("CSCI 1260", "Object Oriented Programming", 4, 28, 30),
            new Course("MATH 1530", "Probability and Statistics", 3, 45, 45),
            new Course("MATH 1910", "Calculus I", 4, 112, 120),
            new Course("MATH 1920", "Calculus II", 4, 70, 80),
            new Course("ENGL 1010", "Composition I", 3, 150, 150),
            new Course("ENGL 1020", "Composition II", 3, 96, 120),
            new Course("HIST 2010", "United States History I", 3, 80, 100),
            new Course("HIST 2020", "United States History II", 3, 64, 100),
        };
    }
}
