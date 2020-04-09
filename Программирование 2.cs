using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<short> digits = new List<short>() { 1, 0, 93, 75 };
            digits.Add(5);
            digits.Add(15);
            digits.Add(8);
            digits.Add(45);
            Console.WriteLine(digits[4]);

            Console.ReadKey()
                ;

        }
    }
}
