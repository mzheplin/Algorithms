using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(ref IList<T> collection, int size)
        {
            MergeSort(ref collection, 0, size - 1);
        }

        private void MergeSort(ref IList<T> collection, int p, int r)
        {
            if (p >= r) return;

            var q = p + (r - p) / 2; 

            MergeSort(ref collection, p, q);
            MergeSort(ref collection, q + 1, r);

            Merge(ref collection, p, q, r);
        }

        private void Merge(ref IList<T> collection, int p, int q, int r)
        {
            if (collection[q].CompareTo(collection[q + 1]) < 0) return;

            var nL = q - p + 1;
            var nR = r - q;

            var L = collection.Skip(p).Take(nL).ToList();
            var R = collection.Skip(q + 1).Take(nR).ToList();

            int i = 0, j = 0, k = p;

            while (i < nL && j < nR)
            {
                if (L[i].CompareTo(R[j]) <= 0) 
                {
                    collection[k] = L[i];
                    i++;
                }
                else
                {
                    collection[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < nL)
            {
                collection[k] = L[i];
                i++;
                k++;
            }

            while (j < nR)
            {
                collection[k] = R[j];
                j++;
                k++;
            }
        }
    }

}
