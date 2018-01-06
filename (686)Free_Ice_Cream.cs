using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_Ice_Cream
{
    class Program
    {
        static void Main(string[] args)
        {
            int child = 0;
            string input = Console.ReadLine();
            int n = int.Parse(input.Split(' ')[0]);
            double x = double.Parse(input.Split(' ')[1]);
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                char op = char.Parse(input.Split(' ')[0]);
                int count = int.Parse(input.Split(' ')[1]);
                if(op=='+')
                {
                    x += count;
                }
                else
                {
                    if(count>x)
                    {
                        child++;
                    }
                    else
                    {
                        x -= count;
                    }
                }
                
            }
            Console.WriteLine("{0} {1}",x,child);
        }
    }
}
