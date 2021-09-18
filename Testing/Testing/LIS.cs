using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class LIS
    {
        public int Execute(int[] A)
        {
            int[] resultSet = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                resultSet[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (A[i] > A[j] && resultSet[i] < (1 + resultSet[j]))
                    {
                        resultSet[i] = 1 + resultSet[j];
                    }
                }
            }
            int maxSubSeq = 0;
            for (int i = 0; i < resultSet.Length; i++)
            {
                if (resultSet[i] > maxSubSeq)
                {
                    maxSubSeq = resultSet[i];
                }
            }
            return maxSubSeq;
        }
    }
}
