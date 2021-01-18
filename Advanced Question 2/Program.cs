using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Advanced_Question_2
{
    class Program
    {
        //First method
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
            
        }
    }
}
