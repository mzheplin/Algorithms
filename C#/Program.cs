using SortingAlgorithms;
using C_Sharp.Divide_Conquer;
using System.Diagnostics;
using System.Collections.Generic;



IList<int> originalList = new List<int>();
var random = new Random();
for (int i = 0; i < 10; i++)
{
    originalList.Add(random.Next(-5,5));
}

foreach (int i in originalList)
{
    Console.Write(i);
    Console.Write('\t');
}
Console.WriteLine( );

var res = C_Sharp.DynamicProgramming.Solver.MaxSum(originalList);

foreach (int i in res.Item1)
{
    Console.Write(i);
    Console.Write('\t');
}

Console.WriteLine();
Console.WriteLine(res.Item2);

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