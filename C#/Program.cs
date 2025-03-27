using SortingAlgorithms;
using C_Sharp.Divide_Conquer;
using System.Diagnostics;
using System.Collections.Generic;



IList<int> originalList = new List<int>();
var random = new Random();
for (int i = 0; i < 20000; i++)
{
    originalList.Add(Math.Max(200000 - i, 1));
}
var sorted = originalList.OrderByDescending(x => x).ToList();

/*foreach (int i in sorted)
{
    Console.Write(i);
    Console.Write('\t');
}*/


Stopwatch stopwatch1 = new Stopwatch();
stopwatch1.Start();
int hIdx1 = Algorithms.FindHIndex(sorted);
stopwatch1.Stop();

Console.WriteLine(hIdx1);


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