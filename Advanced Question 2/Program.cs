using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advanced_Question_2
{
    class Program
    {
        static int FindMaximumXOR(int[] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length-1; i++)
            {
                for (int x = i+1; x < nums.Length; x++)
                {
                    int temp = nums[i] ^ nums[x];
                    if (temp > max)
                    {
                        max = temp;
                    }
                } 
            }
            return max;
        }
        static int MaxXOR(int[] arr)
        {
            int maxx = 0, mask = 0;

            HashSet<int> se = new HashSet<int>();

            for (int i = 30; i >= 0; i--)
            {

                mask |= (1 << i);

                for (int j = 0; j < arr.Length; ++j)
                {
 
                    se.Add(arr[j] & mask);
                }

                int newMaxx = maxx | (1 << i);
              
                  foreach (int prefix in se)
                {
                    if (se.Contains(newMaxx ^ prefix))
                    {
                        maxx = newMaxx;
                        break;
                    }
                }
                se.Clear();
            }
            return maxx;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> nums = new List<int>();
            int[] x =
            {
                3,
                10,
                5,
                2,
                25,
                8
            };
            for (int i = 0; i < 100000; i++) 
            {
                int t = rand.Next(0, 100000);
                nums.Add(t);
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            
            int result = MaxXOR(x);
            stopwatch.Stop();
            Console.WriteLine(result);
            
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
