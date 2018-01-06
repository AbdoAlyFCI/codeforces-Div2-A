using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrot_Cakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split(' ')[0]);
            int t = int.Parse(input.Split(' ')[1]);
            int k = int.Parse(input.Split(' ')[2]);
            int d = int.Parse(input.Split(' ')[3]);
            int tw = 0, to = 0;
            int n2 = n;
            while (n != 0)
            {
                tw += t;
                if (n > k)
                {
                    n -= k;
                }
                else
                {
                    n = 0;
                    continue;
                }
            }
            to += d;
            while(n2!=0)
            {
                to += t;
                for (int i = 0; i < 2; i++)
                {
                    if(n>k)
                    {
                        n2-= k;

                    }
                    else
                    {
                        n2 = 0;
                        break;
                    }
                }
            }
            if(to<tw)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


            
        }
    }
}
