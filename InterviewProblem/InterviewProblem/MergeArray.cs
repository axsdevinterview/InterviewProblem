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
            var actualMergedArray = array1.Union(array2).ToArray();

            return actualMergedArray;
        }
    }
}
