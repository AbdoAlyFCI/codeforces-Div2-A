using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.Write(char.ToUpper(n[0]));
            for (int i = 1; i < n.Length; i++)
            {
                Console.Write(n[i]);
            }
            
            
        }
    
    }
}
