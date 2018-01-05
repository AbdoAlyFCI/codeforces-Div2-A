using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Roll
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int denominator = 6;
            int numerator=0;
            string input = Console.ReadLine();
            int y = int.Parse(input.Split(' ')[0]);
            int w = int.Parse(input.Split(' ')[1]);
            if(w==6 ||y==6)
            {
                Console.WriteLine("1/6");
            }
            else if (w == 1 && y == 1)
            {
                Console.WriteLine("1/1");
            }
            else
            {
                if(y>w)
                {
                    numerator = 6 - (y - 1);
                }
                else
                {
                    numerator = 6 - (w - 1);
                }
                for (int i = 2; i <= 3; i++)
                {
                    if (numerator % i == 0)
                    {
                        numerator = numerator / i;
                        denominator = denominator / i;
                    }
                    else
                        continue;
                }
                Console.WriteLine(numerator+"/"+denominator);
            }
        }
    }
}
