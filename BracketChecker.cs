// BracketChecker: a stack remembers every bracket that is still open,
// and the most recent one is always on top.
//
// Part C. IsBalanced is Exercise 3.
public static class BracketChecker
{
    // True when every (, [, and { is closed by its partner, in order.
    // Brackets go wrong in exactly three ways. Catch all three:
    //   1. closing something that was never opened      ( ) )
    //   2. closing in the wrong order                    ( [ ) ]
    //   3. leaving something open at the end             ( ( )
    // Every other character is ignored.
    public static bool IsBalanced(string text)
    {
        MyStack<char> open = new MyStack<char>();

        foreach (char c in text)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                open.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (open.IsEmpty || !Matches(open.Pop(), c))
                {
                    return false;
                }
            }
        }

        return open.IsEmpty;
    }

    // Given. True when close is the partner of open.
    public static bool Matches(char open, char close)
    {
        return (open == '(' && close == ')')
            || (open == '[' && close == ']')
            || (open == '{' && close == '}');
    }
}