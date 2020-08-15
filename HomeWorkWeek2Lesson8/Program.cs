using System;
using System.Runtime.CompilerServices;

namespace HomeWorkWeek2Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Exe1();
            Exe2();
            Exe3(10);
            Exe4();
            Exe5();
            Exe6();
            Exe7();
            Exe8();
            Exe9();
            Exe10();
            
        }

        public static void Exe1()
        {
            int count = 0;
            int prime = 0;

            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }

                if (count == (i - 2))
                {
                    prime++;
                }

                count = 0;
            }

            Console.WriteLine(prime);
        }

        public static void Exe2()
        {
            int even = 1;
            do
            {
                if (even % 2 == 0)
                {
                    Console.Write(even + " ");

                }

                even++;
            } while (even <= 1000);
        }

        public static void Exe3(int n)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

        }

        public static void Exe4()
        {
            int number = Int32.Parse(Console.ReadLine());

            int pyramid = 0;
            int value = 0;
            while (value < number)
            {
                for (int i = 0; i < pyramid; i++)
                {
                    value++;
                    Console.Write(value);
                    if (value >= number)
                        return;
                }

                Console.WriteLine();
                pyramid++;
            }
        }

        public static void Exe5()
        {
            for (int i = 1; i <= 20; i++)
            {
                double power = (Math.Pow(i, 3));
                Console.WriteLine($"{i} to the power of 3: {power}");

            }
        }

        public static void Exe6()
        {
            double sum = 0;
            for (double i = 1; i <= 20; i++)
            {
                sum = sum + 1 / i;
            }

            Console.WriteLine(sum);
        }

        public static void Exe7()
        {
            int i, j, k, n;
            Console.WriteLine("Give length: ");
            n = Int32.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (i = 1; i <= n - 1; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }

                for (j = n - 1; j >= 2 * i - n + 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }

        public static void Exe8()
        {
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray);
            Console.WriteLine(charArray);
            
        }

        public static void Exe9()
        {
            int value = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
        }

        public static void Exe10()
        {
            Console.WriteLine("Give first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Give second number: ");
            int second = int.Parse(Console.ReadLine());

            int i = first;

            while (i % second != 0)
            {
                i += first;
                
            }

            Console.WriteLine($"Least common multiple: {i}");


        }
    }
}
