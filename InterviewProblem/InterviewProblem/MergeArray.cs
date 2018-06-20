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
            if (array1.Length >= array2.Length)
            {
                var counter = 0;
                char[] newArray = new char[array1.Length + array2.Length];
                for (var i = 0; i < array1.Length; i++)
                {
                    newArray[counter] = array1[i];
                    counter++;

                    if ((i<array2.Length) && !array2[i].Equals(null))
                    {
                        newArray[counter] = array2[i];
                        counter++;

                    }
                }
                return newArray;
            }
        
            else
            {
                var counter = 0;
                char[] newArray = new char[array1.Length + array2.Length];
                for (var i = 0; i < array2.Length; i++)
                {
                    newArray[counter] = array2[i];
                    counter++;

                    if ((i < array1.Length) && !array1[i].Equals(null))
                    {
                        newArray[counter] = array1[i];
                        counter++;

                    }
                }
                return newArray;
            }
            
           
            
            throw new NotImplementedException();
        }
    }
}
