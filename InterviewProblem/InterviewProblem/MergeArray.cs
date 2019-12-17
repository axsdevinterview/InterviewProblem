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
            //Input: 2 arrays of chars of unknown
            //Output: a single composed of the 2 arrays blended

            //1. declare container array to hold result. length = arary1.length + array2.length
            int length = array1.Length + array2.Length;
            char[] resultArr = new char[length];
            //2. determine a generic length

            //3. iterable variables for each array
            int i = 0, j = 0, t = 0;
            //4. while loops for if both are true, one is true, the other is true.
            int shortestArr = (array1.Length <= array2.Length ? array1.Length : array2.Length);

            while (j < shortestArr && t < shortestArr)
            {
                resultArr[i++] = array1[j++];
                resultArr[i++] = array2[t++];
            }

            while (j <  array1.Length && t >= shortestArr)
            {
                resultArr[i++] = array1[j++];
            }

            while (t < array2.Length && j >= shortestArr)
            {
                resultArr[i++] = array2[t++];
            }



            return resultArr;

        }
    }
}
