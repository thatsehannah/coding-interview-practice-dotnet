using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Arrays
{
    public class FindSmallestInArray
	{
        //Implement a function thats takes an array arr and returns the smallest number in the given array.
        public static int Solution(int[] arr)
        {
            //Array.Sort(arr);
            //return arr[0];

            int smallest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            return smallest;
        }
    }
}

