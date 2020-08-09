using System;

namespace HomeWorkWeek2Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
        }
        
        public static void ExerciseOne()
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
    }
       
}