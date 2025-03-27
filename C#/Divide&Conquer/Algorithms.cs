
namespace C_Sharp.Divide_Conquer
{
    using System.Collections.Generic;
    using System.Linq;

    public static  class Algorithms
    {

        public static int FindHIndex(IList<int> list)
        {
            var sorted = list.OrderByDescending(x => x).ToList();

            int left  = 0, right = sorted.Count - 1; 

            return FindHIndexRecursive(sorted, left, right);
        }

        private static int FindHIndexRecursive(IList<int> list, int left, int right)
        {
            if (left >= right) return right + 1;

            var middle = left + (right - left) / 2 + 1;

            if (middle + 1 == list[middle])
            {
                return middle + 1;
            }
            else if (middle + 1 < list[middle])
            {
                return FindHIndexRecursive(list, middle, right);
            }
            else
            {
                return FindHIndexRecursive(list, left, middle - 1);
            }
        }
    }
}
