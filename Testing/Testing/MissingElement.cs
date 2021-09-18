using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class MissingElement
    {
        public int Missing(int[] input)
        {
            int len = input.Length;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i + 1] - input[i] > 1)
                    return input[i] + 1;
            }
            return input[len - 1] + 1;
        }
    }
}
