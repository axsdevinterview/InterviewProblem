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
            int arrayLength = array1.Length + array2.Length;
            char[] combinedArray = new char[arrayLength];
            
            int combinedCount= 0;
            int arrayOneCount = 0;
            int arrayTwoCount = 0;
            while (combinedCount< arrayLength)
            {
                if(combinedCount % 2 == 0)
                {
                    combinedArray[combinedCount] = array1[arrayOneCount];
                    arrayOneCount++;
                }
                else
                {
                    combinedArray[combinedCount] = array2[arrayTwoCount];
                        arrayTwoCount++;
                }
                combinedCount++;
            }

            return combinedArray;
            
        }
    }
}
