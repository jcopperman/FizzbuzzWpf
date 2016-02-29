using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWpf
{
    public class FizzbuzzCalculator
    {
        public string output;
        public double value = 150.2374;

        public void Fizzbuzz()
        {
            for (int i = 1; i <= value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output += "FizzBuzz ";
                }
                else if (i % 5 == 0)
                {
                    output += "Buzz ";
                }
                else if (i % 3 == 0)
                {
                    output += "Fizz ";
                }
                else
                {
                    output += i.ToString() + " ";
                }
            }
        }              
    }
}
