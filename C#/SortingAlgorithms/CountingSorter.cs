using SortingAlgorithms;

namespace C_Sharp.SortingAlgorithms
{
    public class CountingSorter : ISorter<int>
    {
        public void Sort(ref IList<int> collection, int size)
        {
            var B = new List<int>(new int[size]);
            var k = collection.Max();
            var C = new int[k + 1];

            
            for (int i = 0; i < size; i++)
            {
                C[collection[i]] += 1;
            }

            for (int i = 1; k >= i; i++)
            {
                C[i] = C[i] + C[i - 1];
            }


            for (int j = size - 1; j >= 0; j--)
            {
                B[C[collection[j]] - 1] = collection[j];
                C[collection[j]] -= 1;
            }

            for (int i = 0; i < size; i++)
            {
                collection[i] = B[i];
            }

        }
    }
}
