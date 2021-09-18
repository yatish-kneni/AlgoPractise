using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Knapsack
    {
        public int NoRepetition(int[] weights, int[] values, int capacity)
        {
            int items = weights.Length;
            int[,] result = new int[items + 1, capacity + 1];

            for (int i = 0; i <= capacity; i++)
            {
                result[0, i] = 0;
            }

            for (int i = 0; i <= items; i++)
            {
                result[i, 0] = 0;
            }

            for (int i = 1; i <= items; i++)
            {

            }

            return 0;
        }

        public int ElectoralVotes(int[] populations, int[] votes, int Z)
        {
            var states = populations.Length;
            HashSet<int> sendValues = new HashSet<int>();
            int[,] table = new int[states + 1, Z + 1];
            table[0, 0] = 0;
            for (int i = 1; i <= Z; i++)
            {
                table[0, i] = int.MaxValue;
            }
            for (int i = 1; i <= states; i++)
            {
                table[i, 0] = int.MaxValue;
            }

            for (int i = 1; i <= states; i++)
            {
                int totalVotes = 0;
                for (int k = 0; k < i; k++)
                {
                    totalVotes += votes[k];
                }
                for (int j = 1; j <= Z; j++)
                {
                    if (j <= totalVotes)
                    {
                        sendValues.Add(votes[i - 1]);
                        if (j <= votes[i - 1])
                        {
                            table[i, j] = Math.Min(populations[i - 1], table[i - 1, j]);
                        }
                        else
                        {
                            table[i, j] = Math.Min(populations[i - 1] + table[i - 1, j - votes[i - 1]], table[i - 1, j]);
                        }
                    }
                    else
                    {
                        table[i, j] = table[i - 1, j];
                    }

                }

            }
            return table[states, Z];
        }
    }
}
