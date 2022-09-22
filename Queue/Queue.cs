using DataStructurs;

namespace Data_Structures;

public class Queue
{
    private ListNode _head, _tail;
    private int _size;
    public Queue()
    {
        _head = null!;
        _tail = null!;
        _size = 0;
    }

    public void Add(int val)
    {
        if (_size == 0)
        {
            _head = _tail = new ListNode(val);
        }
        else
        {
            ListNode newNode = new ListNode(val);
            _tail.next = newNode;
            _tail = newNode;
        }

        ++_size;
    }

    public int Poll()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is Empty !");
        }

        int ret = _head.val;
        if (_size == 1)
        {
            _tail = _head = null!;
        }
        else _head = _head.next;

        --_size;
        return ret;
    }

    public int Size()
    {
        return _size;
    }

    public String toString()
    {
        if (IsEmpty())
        {
            return "[ ]";
        }
        ListNode curr = _head;
        String x = "";
        while (curr != null!)
        {
            x += curr.val + " , ";
            curr = curr.next;
        }

        return string.Concat("[ ", x.AsSpan(0, x.Length - 2), "]");
    }

    public bool IsEmpty()
    {
        return _size == 0;
    }
}

