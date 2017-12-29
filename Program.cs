using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorful_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 1,N=0;
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            for (int i = 0; i < t.Length; i++)
            {
                for (int k = N; k < s.Length; k++)
                {
                    if(s[k]==t[i])
                    {
                        pos++;
                        N++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(pos);
        }
    }
}
