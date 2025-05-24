using SortingAlgorithms;
using C_Sharp.Divide_Conquer;
using System.Diagnostics;
using System.Collections.Generic;
using C_Sharp.SortingAlgorithms;



IList<int> originalList = new List<int>();
var random = new Random();
for (int i = 0; i < 10; i++)
{
    originalList.Add(random.Next(0,10));
}

foreach (int i in originalList)
{
    Console.Write(i);
    Console.Write('\t');
}
Console.WriteLine( );

ISorter<int> sorter = new CountingSorter();

sorter.Sort(ref originalList, originalList.Count);

foreach (int i in originalList)
{
    Console.Write(i);
    Console.Write('\t');
}
Console.WriteLine();


// Helper method to measure execution time of a Sorter
static long MeasureExecutionTime(ISorter<int> sorter)
{
    // Clone the list to ensure each sort works on the same unsorted data
    IList<int> originalList = new List<int>();
    var random = new Random();
    for (int i = 0; i < 5000; i++)
    {
        originalList.Add(i);
    }

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    sorter.Sort(ref originalList, originalList.Count);
    stopwatch.Stop();

    return stopwatch.ElapsedMilliseconds;
}