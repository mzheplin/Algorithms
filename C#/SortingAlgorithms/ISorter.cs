using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    interface ISorter<T> where T : IComparable<T>
    {
        public void Sort(ref IList<T> collection, int size);
    }
}
