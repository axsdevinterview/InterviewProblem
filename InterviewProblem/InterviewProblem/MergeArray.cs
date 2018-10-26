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
            List<char> array3 = new List<char>();
            for (int i=0; i < array1.Length; i++)
            {
                for(int j=0; j<array2.Length; j++)
                {
                    array3.Add(array1[i]);
                    array3.Add(array2[j]);
                    i++;
                }
            }
            return array3.ToArray();


        }
    }
}
