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
           // char[] newArray = new char[array1.Length+array2.Length];
            List<char> charArray = new List<char>();
            for (int i = 0; i < array1.Length; i++)
            {
                charArray.Add(array1[i]);
                charArray.Add(array2[i]);
                //arr[i] = array1[i];
               // arr[i + 1] = array2[i];
                    }
            
            return charArray.ToArray();
        }
    }
}
