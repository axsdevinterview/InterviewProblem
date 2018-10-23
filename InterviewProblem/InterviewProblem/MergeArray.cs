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
            foreach (char char1 in array1)
            {
                Console.WriteLine(char1);
            }
            foreach (char char1 in array2)
            {
                Console.WriteLine(char1);
            }

            var list = new List<char>();
            list.AddRange(array1);
            list.AddRange(array2);
            char[] array3 = list.ToArray();
            Console.WriteLine(array3);

            Array.Sort
                foreach (char i in array3)
            {
                if(i )
            }
            return array3;


        }
    }
}
