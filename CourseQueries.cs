// CourseQueries: questions asked of the course list with LINQ.
//
// Parts G and H, along with the Class 4 demo. Every method is one query:
// no for or foreach loops.
public static class CourseQueries
{
    // Part G, demo: the code of every course with at least one open seat.
    public static List<string> OpenCourseCodes(List<Course> courses)
    {
        return courses.Where(c => c.SeatsLeft > 0)
            .Select(c => c.Code)
            .ToList();
    }

    // Part G, demo: the titles of the four credit courses.
    public static List<string> FourCreditTitles(List<Course> courses)
    {
        return courses.Where(c => c.Credits == 4)
            .Select(c => c.Title)
            .ToList();
    }

    // Exercise 7: one line per open course, in list order,
    // like "CSCI 1250: 2 seats left".
    public static List<string> SeatsLeftReport(List<Course> courses)
    {
        return courses.Where(c => c.SeatsLeft > 0)
            .Select(c => c.Code + ": " + c.SeatsLeft + " seats left")
            .ToList();
    }

    // Part H, demo: the three biggest courses, largest first,
    // like "ENGL 1010 (150)".
    public static List<string> TopThreeByEnrollment(List<Course> courses)
    {
        return courses.OrderByDescending(c => c.Enrolled)
            .Take(3)
            .Select(c => c.Code + " (" + c.Enrolled + ")")
            .ToList();
    }

    // Part H, demo: every student in every course, added up.
    public static int TotalEnrolled(List<Course> courses)
    {
        return courses.Sum(c => c.Enrolled);
    }

    // Part H, demo: how many courses have no seats left.
    public static int FullCourseCount(List<Course> courses)
    {
        return courses.Count(c => c.SeatsLeft == 0);
    }

    // Part H, demo: a dictionary from course code to course, in one line.
    public static Dictionary<string, Course> ByCode(List<Course> courses)
    {
        return courses.ToDictionary(c => c.Code);
    }

    // Exercise 8: one line per department, most students first,
    // like "ENGL | courses: 2 | students: 246".
    public static List<string> DepartmentReport(List<Course> courses)
    {
        return courses.GroupBy(c => c.Dept)
            .OrderByDescending(g => g.Sum(c => c.Enrolled))
            .Select(g => g.Key + " | courses: " + g.Count()
                + " | students: " + g.Sum(c => c.Enrolled))
            .ToList();
    }
}