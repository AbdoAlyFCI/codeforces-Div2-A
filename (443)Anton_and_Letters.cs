using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_and_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] alp = new char[26];
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int index = input[i]-97;
                if (input[i] == ' ' || input[i] == '{' || input[i] == ',' || input[i] == '}')
                {
                    continue;
                }
                else
                    if(alp[index]=='\0')
                    {
                        alp[index] = input[i];
                        count++;
                    }
                else
                    {
                        continue;
                    }
            }
            Console.WriteLine(count);
        }
    }
}
