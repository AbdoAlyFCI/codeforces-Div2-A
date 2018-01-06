using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                if(words[i].Length>10)
                {
                    Console.WriteLine("{0}{1}{2}",words[i][0],words[i].Length-2,words[i][words[i].Length-1]);
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
