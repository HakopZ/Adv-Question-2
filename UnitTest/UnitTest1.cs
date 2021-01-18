using Advanced_Question_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;
namespace UnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new [] {3, 10, 5 , 2, 25 , 8}, 28)]
        public void TestIfItWorks(int[] x, int expected)
        {
               
            int result = XORFind.FindingMaximumXORWithTrie(x);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckSpeedWithRandomData()
        {
            Random rand = new Random();
            const int MaximumSpeed = 2;
            List<int> temp = new List<int>();
            for(int i = 0; i < 100000; i++)
            {
                temp.Add(rand.Next(0, 100000));
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            XORFind.FindingMaximumXORWithTrie(temp.ToArray());
            sw.Stop();
            Assert.True(MaximumSpeed > sw.Elapsed.TotalSeconds);
        }
    }
}
