using System;
using System.Collections.Generic;
using System.Linq;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your last five grades");
            Console.WriteLine("Numbers must be in range from 2 to 6");
            List<int> grades = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                grades.Add(n);
            }
            double result = grades.Where(x => x >= 2 && x <= 6).Average();
            Console.WriteLine($"Your average grade is {result}");
        }
    }
}
