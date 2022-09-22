using DataStructurs;

namespace Data_Structures;

public class Stack
{
    private int _size;
    private ListNode _top;

    public Stack()
    {
        _top = null!;
        _size = 0;
    }

    public void Push(int val)
    {
        if (_size == 0)
        {
            _top = new ListNode(val);
        }
        else
        {
            ListNode newNode = new ListNode(val);
            newNode.next = _top;
            _top = newNode;
        }

        ++_size;
    }

    public int Peek()
    {
        if (_size == 0)
        { 
            throw new InvalidOperationException("Stack is Empty !");
         
        }

        return _top.val;

    }

    public int Pop()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Stack is Empty !");

        }

        int ret = _top.val;
        _top = _top.next;
        --_size;
        return ret;
    }

    public override string ToString()
    {
        if (_size == 0)
        {
            return "[ ]";
        }

        ListNode curr = _top;
        string str = "";
        while (curr != null!)
        {
            str += curr.val + "  ";
            curr = curr.next;
        }

        String rev = "";
        int len;
        len = str.Length - 2; 
        while (len >= 0) {
            rev = rev + str[len];
            if (str[len]!=' ')
            {
                rev += " ,";
            }
            len--;
        }

        return "[ " + rev.Substring(1, rev.Length -2) + "]";
    }
}
