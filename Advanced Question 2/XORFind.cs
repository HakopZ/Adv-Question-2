using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced_Question_2
{
    public static class XORFind
    {
        static Trie trie = new Trie();
        public static int find_max_XOR(int num)
        {
            TrieNode temp = trie.Root;
            string binary = Convert.ToString(num, 2);
            binary = binary.PadLeft(32, '0');
            string max_xor = "";
            foreach (var l in binary)
            {
                int oppositeBit = Math.Abs(int.Parse(l.ToString()) - 1);
                if (temp.Children.ContainsKey(oppositeBit.ToString().First()))
                {
                    max_xor += oppositeBit.ToString();
                    temp = temp.Children[oppositeBit.ToString().First()];
                }
                else
                {
                    max_xor += l;
                    temp = temp.Children[l];
                }
            }
            return (Convert.ToInt32(max_xor, 2) ^ num);

        }
        public static int FindingMaximumXORWithTrie(int[] nums)
        {
            trie.Insert(nums);
            int max = 0;
            foreach (var num in nums)
            {
                max = Math.Max(max, find_max_XOR(num));
            }

            return max;
        }

    }
}
