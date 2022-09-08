namespace DataStructurs 
{
    class Test
    {
        static void Main(String[] args)
        {

            LinkedList list = new LinkedList();
            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(list.removeLast() + "\t");
                Console.WriteLine(list.toString());

            }

            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(i);
            }

            Console.WriteLine(list.toString());
        }

    }
}