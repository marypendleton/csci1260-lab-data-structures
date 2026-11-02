// MyStack: last in, first out.
//
// Part C. Build this class along with the Class 2 demo.
// A stack HAS A MyList. It does not inherit from one.
public class MyStack<T>
{
    private MyList<T> items = new MyList<T>();

    // Returns how many items are on the stack.
    public int Count => items.Count;

    // Returns true when the stack holds nothing.
    public bool IsEmpty => Count == 0;

    // Put an item on top.
    public void Push(T item)
    {
        items.Add(item);
    }

    // Take the top item off and hand it back.
    public T Pop()
    {
        T item = Peek();
        items.RemoveAt(items.Count - 1);
        return item;
    }

    // Look at the top item without removing it. On an empty stack, throw
    // InvalidOperationException("Stack is empty.").
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return items[items.Count - 1];
    }
}