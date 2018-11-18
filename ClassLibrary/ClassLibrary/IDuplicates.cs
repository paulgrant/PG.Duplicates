using System.Collections.Generic;

namespace PG.Duplicates.Service
{
    public interface IDuplicates
    {
        int[] findDuplicates(int? userInput);
        IEnumerable<int> findDuplicatesInList(List<int> valueList);
    }
}