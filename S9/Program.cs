using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's theory score: ");
            int theo = int.Parse(Console.ReadLine());
            Console.Write("Enter student's practical grade: ");
            int prac = int.Parse(Console.ReadLine());
            int sum = theo + prac;
            Console.WriteLine("The student's final grade is: " + sum);
            Console.ReadKey();
        }
    }
}
