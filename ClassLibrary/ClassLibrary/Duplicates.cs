using System;
using System.Collections.Generic;
using System.Linq;

namespace PG.Duplicates.Service
{
    public class Duplicates : IDuplicates
    {
        private readonly IRandomListGenerator _randomListGenerator;

        public Duplicates(IRandomListGenerator listGenerator)
        {
            _randomListGenerator = listGenerator;
        }

        public Duplicates()
        {
            _randomListGenerator = new RandomListGenerator();
        }

        public int[] findDuplicates(int? value)
        {
            if(value == null)
            {
                value = 1000000;
            }

            if (value < 1)
            {
                return null;
            }

            
            var valueList = _randomListGenerator.GenerateListWithNElements(value.Value);
            var result = findDuplicatesInList(valueList);
            return result.ToArray();
        }

        public IEnumerable<int> findDuplicatesInList(List<int> valueList)
        {
            var returnList = valueList.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);

            return returnList;
        }
    }
}
