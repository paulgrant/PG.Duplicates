# PG.Duplicates

To run the console app - open a console and type the following:

dotnet consoleApp.dll

You will then be asked to enteran integer value, which will then be processed and duplicates shown.


PERFORMANCE CONSIDERATIONS:

I have used linq to find the duplicates by grouping and then counting. This is very performant - 140ms for single digit duplicate finding, 2 secs for default (1,000,000) value to find duplicates.

An alternative to Linq would be to use a HashSet.  Given the initial overhead in generating the Hashset and then looping through all items evaluating the IsDuplicate property.
