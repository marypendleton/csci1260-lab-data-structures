// ArrayTools: the three algorithms every array based structure is built from.
// Each method works on a partially filled array: the array holds the room,
// and count says how many slots are actually in use.
//
// Part A. Write IndexOf and InsertAt along with the Class 1 demo.
// RemoveAt is Exercise 1.
public static class ArrayTools
{
    // Linear search: check every slot in use until you find the target.
    // Return the index, or -1 when the target is not there.
    public static int IndexOf(int[] data, int count, int target)
    {
        for (int i = 0; i < count; i++)
        {
            if (data[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    // Insert: shift right starting from the END, then drop the value
    // into the gap. Return the new count.
    public static int InsertAt(int[] data, int count, int index, int value)
    {
        for (int i = count; i > index; i--)
        {
            data[i] = data[i - 1];
        }

        data[index] = value;
        return count + 1;
    }

    // Remove: shift left starting at the gap. The last slot is no longer
    // in use, so the count drops by one. Return the new count.
    public static int RemoveAt(int[] data, int count, int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            data[i] = data[i + 1];
        }

        return count - 1;
    }

    // Given. Builds a line like "10 20 30" from the slots in use.
    public static string Show(int[] data, int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            if (i > 0)
            {
                result += " ";
            }
            result += data[i];
        }
        return result;
    }
}
