// MyQueue: first in, first out, built on a circular array.
//
// Part D. Build this class along with the Class 2 demo.
// Dequeue moves the head index. It never shifts the items.
public class MyQueue<T>
{
    private T[] items = new T[4];
    private int head = 0;    // index of the front item
    private int count = 0;

    // Given.
    public int Count => count;
    public bool IsEmpty => count == 0;

    // Join the back of the line. Grow first if every slot is taken.
    // The back of the line is at (head + count) % items.Length.
    public void Enqueue(T item)
    {
        if (count == items.Length)
        {
            Grow();
        }

        items[(head + count) % items.Length] = item;
        count++;
    }

    // Leave from the front of the line. Move head forward one slot,
    // wrapping with %, and hand back the item that was in front.
    public T Dequeue()
    {
        T item = Peek();
        head = (head + 1) % items.Length;
        count--;
        return item;
    }

    // Given. Look at the front item without removing it.
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return items[head];
    }

    // Doubles capacity, copies items front to back, and resets head.
    private void Grow()
    {
        T[] larger = new T[items.Length * 2];

        for (int i = 0; i < count; i++)
        {
            larger[i] = items[(head + i) % items.Length];
        }

        items = larger;
        head = 0;
    }
}