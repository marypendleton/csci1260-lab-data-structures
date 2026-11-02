// MyList: an array that manages itself. It tracks the count, grows by
// doubling when it is full, and refuses any index that is not in use.
//
// Part B. Build this class along with the Class 1 demo.
// Insert is Exercise 2.
public class MyList<T>
{
    private T[] items;
    private int count;

    // Given. Every list starts with room for four items.
    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    // Returns how many slots are in use.
    public int Count => count;

    // Returns how many slots exist in the array.
    public int Capacity => items.Length;

    // Add to the end. Grow first if every slot is taken.
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Grow();
        }

        items[count] = item;
        count++;
    }

    // The indexer is the code behind list[2]. Both get and set must
    // refuse any index that is not in use.
    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return items[index];
        }
        set
        {
            CheckIndex(index);
            items[index] = value;
        }
    }

    // Insert anywhere from 0 to Count. Inserting at Count is legal and
    // means the same thing as Add. Throw ArgumentOutOfRangeException
    // for anything else.
    public void Insert(int index, T item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count == items.Length)
        {
            Grow();
        }

        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }

        items[index] = item;
        count++;
    }

    // Remove the item at index and close the gap.
    public void RemoveAt(int index)
    {
        CheckIndex(index);

        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        count--;
    }

    // Linear search. Return the index, or -1 when the item is not there.
    // Compare with Equals(a, b), which works for every type T.
    public int IndexOf(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (Equals(items[i], item))
            {
                return i;
            }
        }

        return -1;
    }

    // Given. Builds a line like "[A, B, C]" from the slots in use.
    public override string ToString()
    {
        string result = "[";
        for (int i = 0; i < count; i++)
        {
            if (i > 0)
            {
                result += ", ";
            }
            result += items[i];
        }
        return result + "]";
    }

    // Doubles the array capacity and copies the items in use.
    private void Grow()
    {
        T[] larger = new T[items.Length * 2];

        for (int i = 0; i < count; i++)
        {
            larger[i] = items[i];
        }

        items = larger;
    }

    // Throws an exception when the index is outside the slots in use.
    private void CheckIndex(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }
}