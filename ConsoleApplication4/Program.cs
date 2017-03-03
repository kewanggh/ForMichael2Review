using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -6, -3, 0, -8, -2 };
            int[] finalarr = new int[3];

            //sorting array
            Array.Sort<int>(arr,
                new Comparison<int>(
                    (i1, i2) => i1.CompareTo(i2)
                    ));
            //check to see if the first two numbers are both negative
            if (arr[0] < 0 && arr[1] >= 0)
            {
                finalarr[0] = arr[arr.Length - 1];
                finalarr[1] = arr[arr.Length - 2];
                finalarr[2] = arr[arr.Length - 3];
            }

            int productOfNeg2 = 0;
            int productOfPos2 = 0;

            //check if the first two numbers are negative numbers
            //calculate the product of i
            if(arr[0] < 0 && arr[1] < 0)
            {
                productOfNeg2 = Math.Abs(arr[0]) * Math.Abs(arr[1]);
                productOfPos2 = arr[arr.Length - 1] * arr[arr.Length - 2];
                if (productOfNeg2 < productOfPos2)
                {
                    finalarr[0] = arr[arr.Length - 1];
                    finalarr[1] = arr[arr.Length - 2];
                    finalarr[2] = arr[arr.Length - 3];
                }

                if (productOfNeg2 > productOfPos2)
                {
                    finalarr[0] = arr[0];
                    finalarr[1] = arr[1];
                    finalarr[2] = arr[arr.Length - 1];
                }
            }

            //check to see if all numbers are negative numbers
            bool allNeg = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    allNeg = true;
                }
            }
            if(allNeg)
            {
                finalarr[0] = arr[arr.Length - 1];
                finalarr[1] = arr[arr.Length - 2];
                finalarr[2] = arr[arr.Length - 3];  
            }

            //print it out to the screen to see the result array
            for (int i = 0; i < finalarr.Length; i++)
            {
                Console.WriteLine(finalarr[i]);
            }

            Console.ReadLine();

        }
    }
}
