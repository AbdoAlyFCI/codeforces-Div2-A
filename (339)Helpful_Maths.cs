using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string s = Console.ReadLine();
            if (s.Length == 1)
            {
                Console.WriteLine(s);
            }
            else
            {
                int n = s.Length - (s.Length / 2);
                char[] num = new char[n];
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '+')
                    {
                        continue;
                    }
                    else
                    {
                        num[c] = s[i];
                        c++;
                    }
                }
                Array.Sort(num);
                for (int i = 0; i < c; i++)
                {
                    Console.Write(num[i]);
                    if(i==c-1)
                    {
                        break;
                    }
                    Console.Write("+");
                }
            }
        }
    }
}
