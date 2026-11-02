// CourseCatalog: looks up a course title by its code in one step.
//
// Part E. Build this class along with the Class 3 demo.
public class CourseCatalog
{
    private Dictionary<string, string> courses =
        new Dictionary<string, string>();

    // Returns how many courses are in the catalog.
    public int Count => courses.Count;

    // Adds a course. Returns false, and changes nothing, when the code is
    // already there.
    public bool AddCourse(string code, string title)
    {
        return courses.TryAdd(code, title);
    }

    // Returns the title for a code, or "(no such course)" when the code is
    // missing. Uses TryGetValue so the code is looked up only once.
    public string TitleFor(string code)
    {
        if (courses.TryGetValue(code, out string? title))
        {
            return title;
        }

        return "(no such course)";
    }
}