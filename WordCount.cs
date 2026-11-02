// WordCount: the counting pattern, applied to words.
//
// Part E. Count is Exercise 5.
public static class WordCount
{
    // Return how many times each word appears in text.
    //   1. Lowercase the text, so "To" and "to" count as the same word.
    //   2. Split it into words. Spaces and the punctuation marks , . ! ? ; :
    //      all separate words, and empty pieces are skipped.
    //   3. Use the counting pattern: a new word starts at 1, a word you
    //      have seen before goes up by 1.
    public static Dictionary<string, int> Count(string text)
    {
        Dictionary<string, int> counts =
            new Dictionary<string, int>();

        char[] separators = { ' ', ',', '.', '!', '?', ';', ':' };

        string[] words = text.ToLower().Split(
            separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (counts.ContainsKey(word))
            {
                counts[word]++;
            }
            else
            {
                counts[word] = 1;
            }
        }

        return counts;
    }
}