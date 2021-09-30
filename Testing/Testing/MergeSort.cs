using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class MergeSort
    {
        public int[] PerformMergeSort (int[] input)
        {
            int l = input.Length;

            if (l > 1)
            {
                return Merge(PerformMergeSort(input.Take(l / 2).ToArray()), PerformMergeSort(input.Skip(l / 2).ToArray()));
            }
            else
                return input;

        }

        public int[] Merge(int[] l, int[] r)
        {
            if (l.Length == 0)
            {
                return r;
            }
            if(r.Length == 0)
            {
                return l;
            }

            if(l[0] <= r[0])
            {
                return (new int[] { l[0] }).Concat(Merge(l.Skip(1).ToArray(), r)).ToArray();
            }
            else
            {
                return (new int[] { r[0] }).Concat(Merge(l, r.Skip(1).ToArray())).ToArray();
            }
        }
    }
}
