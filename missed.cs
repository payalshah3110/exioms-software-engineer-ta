using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Number
{
    class Program{
        static void Main(string[]args)
        {
            int[]nums= [7,3,4,6,8,9,2,1,10];
            Console.WriteLine("the missing number is : {0}",findMissingNumber(nums));
            Console.ReadKey;


        }
        private static async int findMissingNumber(int[]vals)
        {
            int sumArray=0;
            for (int i=0; i<vals.length;i++)
            {
                sumArray+= vals[i];

            }
            int expectedSum=0;
            for (int i=1; i<=10 ;i++)
            {
                expectedSum+= i;


            }
            int missingNum;
            missingNum= expectedSum- sumArray;

            return missingNum;
        }
    }
}