using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(ref IList<T> collection, int size)
        {
            if (size > collection.Count()) size = collection.Count();

            for (int i = 0; i < size - 1; i++) 
            {
                var min = collection[i];
                var minIndex = i;

                for (int j = i + 1; j < size; j++)
                {
                    if(collection[j].CompareTo(min) < 0)
                    {
                        min = collection[j];
                        minIndex = j;
                    }
                }

                collection[minIndex] = collection[i];
                collection[i] = min;
            }
        }
    }
}
