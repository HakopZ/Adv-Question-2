using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Question_2
{
    public class TrieNode
    {
        public char Letter { get; private set; }

        public Dictionary<char, TrieNode> Children;
        public bool Word { get; set; }

        public TrieNode(char b)
        {
            Letter = b;
            Children = new Dictionary<char, TrieNode>();
            Word = false;
        }
        public TrieNode()
        {
            Letter = ' ';
            Children = new Dictionary<char, TrieNode>();
            Word = false;
        }
    }
    public class Trie
    {
        public TrieNode Root;
        public Trie()
        {
            Root = new TrieNode();
        }
        public void Clear()
        {
            Root.Word = false;
            Root = null;
        }
        public void Insert(int[] b)
        {
            foreach(var num in b)
            {
                string binary = Convert.ToString(num, 2);
                binary = binary.PadLeft(32, '0');
                Insert(binary);
            }
        }
        public void Insert(string b)
        {
            TrieNode temp = Root;
            foreach (var l in b)
            {
                if (temp.Children.ContainsKey(l))
                {
                    temp = temp.Children[l];
                }
                else
                {
                    temp.Children.Add(l, new TrieNode(l));
                    temp = temp.Children[l];    
                }
            }
        }
        

    }
}
