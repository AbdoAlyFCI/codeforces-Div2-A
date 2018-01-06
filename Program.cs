using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaass_and_Oskols
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = 0, R = 0;
            int n = int.Parse(Console.ReadLine());
            int[] birdnum = new int[n];
            string input = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                birdnum[i] = int.Parse(input.Split(' ')[i]);
            }
            int m = int.Parse(Console.ReadLine());
            int[,] indexs = new int[m, 2];
            for (int i = 0; i < indexs.GetLength(0); i++)
            {
                input = Console.ReadLine();
                for (int h = 0; h < indexs.GetLength(1); h++)
                {
                    indexs[i, h] = int.Parse(input.Split(' ')[h]);
                }
            }
            if (n == 1 &&m !=0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1 && m == 0)
            {
                Console.WriteLine(birdnum[0]);
            }
            else
            {
                for (int i = 0; i < indexs.GetLength(0); i++)
                {
                    L = 0;
                    R = 0;
                    if (indexs[i, 1] > birdnum[indexs[i, 0] - 1])
                    {
                        L = birdnum[indexs[i, 0]];
                    }
                    else
                    {
                        if (indexs[i, 1] == 1)
                        {
                            R = birdnum[indexs[i, 0] - 1] - 1;
                           
                        }
                        else
                        {
                            L = indexs[i, 1] - 1;
                            R = birdnum[indexs[i, 0] - 1] - indexs[i, 1];
                        }
                    }
                    if (indexs[i, 0] == 1)
                    {
                        birdnum[1] += R;
                    }
                    else if (indexs[i, 0] == n)
                    {
                        birdnum[n - 2] += L;
                    }
                    else
                    {
                        birdnum[indexs[i, 0] - 2] += L;
                        birdnum[indexs[i, 0]] += R;

                    }
                    birdnum[indexs[i, 0] - 1] = 0;


                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(birdnum[i]);
                }

            }
        }
    }
}
