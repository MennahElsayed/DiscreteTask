using System;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please , Enter the first  number :");



            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, Enter the second number : ");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                bool isprime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime == true && i > num1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
