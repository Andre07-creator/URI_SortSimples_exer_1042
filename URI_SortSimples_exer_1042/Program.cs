using System;
using System.Collections.Generic;
namespace URI_SortSimples_exer_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string[] Value = Console.ReadLine().Split(' ');
            int v1 = int.Parse(Value[0]);
            int v2 = int.Parse(Value[1]);
            int v3 = int.Parse(Value[2]);
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);

            list.Sort();
            foreach (int s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
        }

    }
}
