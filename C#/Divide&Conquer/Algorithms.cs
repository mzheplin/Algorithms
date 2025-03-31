
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


        public static int[,]? MultiplyMatrices(int[,] A, int[,] B)
        {
            if (A.GetLength(1) != B.GetLength(0)) return null;
                
            if( A.GetLength(0)%2 != 0 
             || A.GetLength(1)%2 != 0
             || B.GetLength(0)%2 != 0 
             || B.GetLength(1)%2 != 0
             || A.GetLength(0) != A.GetLength(1))
            {
                return MultiplyMatricesNested(A,B);
            }

            return MultiplyMatricesStrassens(A,B);
        }

        private static int[,] MultiplyMatricesNested(int[,] A, int[,] B)
        {
            int ar = A.GetLength(0);
            int al = A.GetLength(1);
            int br = B.GetLength(0);
            int bl = B.GetLength(1);

            int[,] C = new int[ar, bl];
            for( int i = 0; i< ar; i++)
            {
                for (int j = 0; j < bl; j++)
                {
                    for (int k = 0; k < al; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }

        private static int[,] MultiplyMatricesStrassens(int[,] A, int[,] B)
        {
            if (A.GetLength(0) == 1) return new int[1,1]{ { A[0, 0] * B[0, 0] } };

            int[,] A11, A12, A21, A22;

            SplitSquareMatrix(A, out A11, out A12, out A21, out A22);

            int[,] B11, B12, B21, B22;

            SplitSquareMatrix(B, out B11, out B12, out B21, out B22);

            var M1 = MultiplyMatricesStrassens(AddMatrices(A11, A22), AddMatrices(B11, B22));
            var M2 = MultiplyMatricesStrassens(AddMatrices(A21, A22), B11);
            var M3 = MultiplyMatricesStrassens(A11, SubtractMatrices(B12, B22));
            var M4 = MultiplyMatricesStrassens(A22, SubtractMatrices(B21, B11));
            var M5 = MultiplyMatricesStrassens(AddMatrices(A11, A12), B22);
            var M6 = MultiplyMatricesStrassens(SubtractMatrices(A21, A11), AddMatrices(B11, B12));
            var M7 = MultiplyMatricesStrassens(SubtractMatrices(A12, A22), AddMatrices(B21, B22));

            var C11 = AddMatrices(AddMatrices(M1, M4), SubtractMatrices(M7, M5));
            var C12 = AddMatrices(M3,M5);
            var C21 = AddMatrices(M2, M4);
            var C22 = AddMatrices(AddMatrices(M1, M3), SubtractMatrices(M6, M2));

            int[,] C;

            MergeSquareMatrix(out C, C11, C12, C21, C22);

            return C;

        }


        private static void SplitSquareMatrix(int[,] A, out int[,] A11, out int[,] A12, out int[,] A21, out int[,] A22)
        {
            int n = A.GetLength(0) / 2;

            A11 = new int[n, n];
            A12 = new int[n, n];
            A21 = new int[n, n];
            A22 = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A11[i, j] = A[i, j];               // Top-left
                    A12[i, j] = A[i, j + n];           // Top-right
                    A21[i, j] = A[i + n, j];           // Bottom-left
                    A22[i, j] = A[i + n, j + n];       // Bottom-right
                }
            }
        }

        private static void MergeSquareMatrix( out int[,] A, int[,] A11, int[,] A12, int[,] A21, int[,] A22)
        {
            int n = A11.GetLength(0);
            A = new int[n*2, n*2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = A11[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j + n] = A12[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i + n, j] = A21[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i + n, j + n] = A22[i, j];
                }
            }
        }

        private static int[,] AddMatrices(int[,] A, int[,] B)
        {
            int n = A.GetLength(0) / 2;

            int[,] C = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i,j] = A[i,j]+ B[i,j];
                }
            }
            return C;
        }

        private static int[,] SubtractMatrices(int[,] A, int[,] B)
        {
            int n = A.GetLength(0) / 2;

            int[,] C = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
            return C;
        }
    }
}
