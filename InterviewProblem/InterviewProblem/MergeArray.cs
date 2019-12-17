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
           
            //Two arrays same length
            //create a new array with merged arrays
            char[] arrayFinal = new char[array1.Length + array2.Length];
            int count = 0;

            for (int i = 0; i < array1.Length; i++) {
                arrayFinal[count] = array1[i];
                count += 1;
                arrayFinal[count] = array2[i];
                count += 1;
                
            } return arrayFinal;
            
        }
    }
}
