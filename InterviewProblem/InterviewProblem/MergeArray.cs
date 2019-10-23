using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblem
{
    public class MergeArray
    {
        public static char[] Merge(char[] array1, char[] array2)
        {
            char[] mergedArray = new char[array1.Length + array2.Length];
            int minLength = Math.Min(array1.Length, array2.Length);

            for (int i = 0, k = 0; k < minLength; i+=2, k++)
            {
                mergedArray[i] = array1[k];
                mergedArray[i + 1] = array2[k];
            }

            char[] longerArray = array1.Length > array2.Length ? array1 : array2;
            for(int k = minLength * 2, i = minLength; k < mergedArray.Length; k++, i++)
            {
                mergedArray[k] = longerArray[i];
            }
            return mergedArray;
        }
    }
}
