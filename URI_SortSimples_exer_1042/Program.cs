using System;

namespace URI_SortSimples_exer_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Value = Console.ReadLine().Split(' ');
            int v1 = int.Parse(Value[0]);
            int v2 = int.Parse(Value[1]);
            int v3 = int.Parse(Value[2]);

            if (v1 < v2 && v1 < v3)
            {
                Console.WriteLine(v1);
            }
            else if (v2 < v1 && v2 < v3)
            {
                Console.WriteLine(v2);
            }
            else
            {
                Console.WriteLine(v3);
            }

            if (v1 < v2 && v1 > v3)
            {
                Console.WriteLine(v1);
            }
            else if (v2 < v1 && v2 > v3)
            {
                Console.WriteLine(v2);
            }
            else
            {
                Console.WriteLine(v3);
            }
            if (v1 > v2 && v1 > v3)
            {
                Console.WriteLine(v1);
            }
            else if (v2 > v3 && v2 > v3)
            {
                Console.WriteLine(v2);
            }
            else
            {
                Console.WriteLine(v3);
            }
            Console.WriteLine();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);

        }
    }
}
