using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InsertSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(ref IList<T> collection, int size)
        {
            if(size > collection.Count()) size = collection.Count();

            for (int i = 1; i < size; i++) 
            {
                var current = collection[i];

                var j = i - 1;

                while (j >= 0 && collection[j].CompareTo(current) > 0)
                {
                    collection[j + 1]= collection[j];
                    j--;
                }

                collection[j + 1] = current;
            }

        }
    }
}
