using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class BinarySearch
    {
        public bool BinarySearchImpl(int[] sortedInput, int right, int left, int searchTerm)
        {
            if (right >= left)
            {
                int mid = left + ((right - left) / 2);
                if (sortedInput[mid] == searchTerm)
                {
                    return true;
                }

                if (sortedInput[mid] > searchTerm)
                {
                    return BinarySearchImpl(sortedInput, mid - 1, left, searchTerm);
                }

                return BinarySearchImpl(sortedInput, right, mid + 1, searchTerm);
            }


            return false;
        }
    }
}
