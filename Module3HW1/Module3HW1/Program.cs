using System;

namespace Module3HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListT<int>();

            list.Add(2);
            list.Add(1);
            list.Add(7);
            list.Add(4);
            list.AddRange(new int[] { 7, 3, 2, 1, 9, 8 });

            list.Remove(9);

            list.RemoveAt(3);

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
