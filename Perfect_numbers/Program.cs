using System;

namespace Perfect_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Please,Enter the start of the range :");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,Enter the end of the range : ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                sum = 0;
                for (int factor = 1; factor < i; factor++)
                {
                    if (i % factor == 0)
                    {
                        sum += factor;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
