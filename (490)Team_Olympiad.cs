using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Olympiad
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> t1 = new Queue<int>();
            Queue<int> t2 = new Queue<int>();
            Queue<int> t3 = new Queue<int>();
            int te1=0,te2=0,te3=0;
            int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {
                int temp = int.Parse(input.Split(' ')[i]);
                
                    if(temp==1)
                    {
                        t1.Enqueue(i+1);
                        te1++;
                    }
                    else if(temp==2)
                    {
                        t2.Enqueue(i+1);
                        te2++;
                    }
                    else if(temp==3)
                    {
                        t3.Enqueue(i+1);
                        te3++;
                    }
            }
                int []s=new int[3];
                s[0]=te1;
                s[1]=te2;
                s[2]=te3;
                if(s.Min()==0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(s.Min());
                    for (int i = 0; i < s.Min(); i++)
                    {
                        Console.Write("{0} {1} {2}\n",t1.Dequeue(),t2.Dequeue(),t3.Dequeue());
                        
                    }
                }
            
            
            
            
        }
    }
}
