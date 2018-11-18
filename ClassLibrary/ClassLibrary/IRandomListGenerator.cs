using System.Collections.Generic;

namespace PG.Duplicates.Service
{
    public interface IRandomListGenerator
    {
        List<int> GenerateListWithNElements(int value);
    }
}