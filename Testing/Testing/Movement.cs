using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Movement
    {
        public int Move(int n)
        {
            int[,] table = new int[n + 1, n + 1];
            table[0, 0] = 0;
            table[1, 1] = 1;
            for (int i = 1; i <= n; i++)
            {
                table[i, 0] = 0;
            }
            for (int i = 1; i <= n; i++)
            {
                table[0, i] = 0;
            }
            for (int i = 2; i <= n; i++)
            {
                table[i, 1] = 0;
            }
            for (int i = 2; i <= n; i++)
            {
                table[1, i] = 0;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    table[i, j] = table[i - 1, j - 2] + table[i - 2, j - 1];
                }
            }
            return table[n, n];
        }
    }
}
