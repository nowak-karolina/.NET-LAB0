using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class FizzBuzz
    {
        int upperBound = 10;

        public FizzBuzz(int arg)
        {
            upperBound = arg;
        }

        public void Display()
        {
            for (int i = 1; i <= upperBound; i++)
            {
                if(i % 5==0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void SetUpperBound(int bound)
        {
            upperBound = bound;
        }
    }
}
