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
            int maxLength = Math.Max(array1.Length, array2.Length);

            char[] result = new char[array1.Length + array2.Length];

            int index = 0;
            for (int i = 0; i < maxLength; i++)
            {
             
                if (i < array1.Length)
                {
                    result[index++] = array1[i];
                }

                if (i < array2.Length)
                {
                    result[index++] = array2[i];
                }
            }
                       
            return result;
        }
    }
}
