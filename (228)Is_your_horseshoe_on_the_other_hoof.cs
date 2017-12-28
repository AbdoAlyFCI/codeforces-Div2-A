using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_your_horseshoe_on_the_other_hoof
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int[] sc = new int[4];
            int[] sc2;
            string input = Console.ReadLine();
            for (int i = 0; i < sc.Length; i++)
            {
                sc[i] = int.Parse(input.Split(' ')[i]);
            }
            sc2 = sc.Distinct().ToArray();
            Console.WriteLine(sc.Length-sc2.Length);

        }
    }
}
