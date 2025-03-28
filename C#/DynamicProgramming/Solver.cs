using System.Numerics;

namespace C_Sharp.DynamicProgramming
{
    public static class Solver
    {
        public static Tuple<List<T>, T> MaxSum<T>(IList<T> list) where T : INumber<T>
        {
            var curSum = list[0];
            var maxSum = list[0];
            int startIdx = 0;
            int endIdx = 0;
            int currStart = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]  >= (list[i] + curSum))
                {
                    curSum = list[i];
                    currStart = i;
                }
                else
                {
                    curSum += list[i];
                }


                if(maxSum < curSum)
                {
                    maxSum = curSum;
                    startIdx = currStart;
                    endIdx = i;
                }
            }

            var res = list.Skip(startIdx).Take(endIdx - startIdx + 1).ToList();

            return Tuple.Create(res, maxSum);
        }

    }
}
