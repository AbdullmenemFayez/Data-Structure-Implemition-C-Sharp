using System;

namespace DataStructurs;

public class LinkedList
{
    private ListNode head, tail;
    private int size;

    public LinkedList()
    {
        this.size = 0; 
        this.head = null;
        this.tail = null;
    }

    public int length()
    {
        return size;
    }

    public void add(int val)
    {
        if (size == 0)
        {
            head = tail=new ListNode(val);
        }
        else
        {
            ListNode newNode = new ListNode(val);
            tail.next = newNode;
            tail = newNode;
        }

        size++;
    }

    public void AddFirst(int val)
    {
        if (size == 0)
        {
            head = tail = new ListNode(val);
        }
        else
        {
            head = new ListNode(val, head);
        }

        ++size;
    }

    public void AddLast(int val)
    {
        add(val);
    }

    public int removeFirst()
    {
        if (size == 0)
        { 
            throw new InvalidOperationException("Linked List is Empty !");
        }

        int ret = head.val;
        head = head.next;
        if (size == 1) tail = head =null!;
            
        --size;
        return ret;
    }

    public int remove(int index)
    {
        int ret = 0;
        if (index >= size || index < 0) throw new IndexOutOfRangeException("Out of range !");
        if (index == 0)
        {
            return removeFirst();
        }

        if (index == size - 1 )
        {
            return removeLast();
        }
        ListNode curr1 = head, curr2 = head.next;
        while (index > 0)
        {
            curr1 = curr1.next;
            curr2 = curr2.next;
            --index;
        }

        ret = curr1.next.val;
        curr1.next = curr2;
        --size;

        return ret;
    }

    public int removeLast()
    {
        if (isEmpty())
        {
            throw new InvalidOperationException("Linked List is Empty !");
        }



        int ret = tail.val;
        if (size == 1)
        {
            tail = head = null!;
        }
        else{
            ListNode curr = head;
        
        while (curr.next != tail)
        {
            curr = curr.next;
        }

        curr.next = null!;
        tail = curr; 
        }
        --size;
        return ret;
    }

    bool isEmpty()
    {
        return size == 0;
    }
    public String toString()
    {
        if (isEmpty())
        {
            return "[ ]";
        }
        ListNode curr = head;
        String x = "";
        while (curr != null)
        {
            x += curr.val + " , ";
            curr = curr.next;
        }

        return string.Concat("[ ", x.AsSpan(0, x.Length - 2), "]");
    }
}