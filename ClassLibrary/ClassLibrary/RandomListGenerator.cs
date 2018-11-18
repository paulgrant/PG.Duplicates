using System;
using System.Collections.Generic;
using System.Text;

namespace PG.Duplicates.Service
{
    public class RandomListGenerator: IRandomListGenerator
    {
        public List<int> GenerateListWithNElements(int value)
        {
            var randomList = new List<int>();
            for (var i = 0; i < (value+1); i++)
            {
                var rnd = new System.Random();
                var randomValue = rnd.Next(1, value + 1);
                randomList.Add(randomValue);
            }
            return randomList;
        }
    }
}
