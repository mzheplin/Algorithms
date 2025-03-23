using Algorithms;
using System.Diagnostics;



// Measure execution time for MergeSorter
var timeMergeSort = MeasureExecutionTime(new MergeSorter<int>());
Console.WriteLine($"MergeSort execution time: {timeMergeSort} ms");

// Measure execution time for SelectionSorter
var timeSelectionSort = MeasureExecutionTime(new SelectionSorter<int>());
Console.WriteLine($"SelectionSort execution time: {timeSelectionSort} ms");

// Measure execution time for InsertSorter
var timeInsertSort = MeasureExecutionTime(new SelectionSorter<int>());
Console.WriteLine($"InsertSort execution time: {timeInsertSort} ms");


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