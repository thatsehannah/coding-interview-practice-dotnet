using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Arrays
{
    public class FindSmallestInArray
	{
        //Implement a function thats takes an array arr and returns the smallest number in the given array.
        public static int Solution(int[] arr)
        {
            //Array.Sort(arr); ----> my original solution
            //return arr[0];

            int smallest = arr[0]; //set smallest initially to the first element of the array
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest) //check if the element at the current index i is smaller than the current value of smallest
                {
                    smallest = arr[i]; //set smallest equal to arr[i]
                }
            }

            return smallest;
        }
    }
}

