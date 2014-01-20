using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 101; i++)
            {
                string result = "";
                bool mult3 = i % 3 == 0;
                bool mult5 = i % 5 == 0;

                if (mult3 && mult5)
                    result = "FizzBuzz";
                else if (i % 3 == 0)
                    result = "Fizz";
                else if (i % 5 == 0)
                    result = "Buzz";
                else
                    result = i.ToString();

                Console.WriteLine(result);
                
            }
            Console.Read();
        }
    }
}
