using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Arrays
{
    //Implement a function that takes an array arr as input and returns the second maximum element in the array.

    public class FindSecondLargest
    {
        public static int Solution(int[] arr)
		{
            //Array.Sort(arr); --------> Original Solution
            //return arr[arr.Length - 2];

            //first find the largest element's index so we can get it out of the way
            int largestIndex = 0;
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > arr[largestIndex])
				{
					largestIndex = i;
				}
			}

			arr[largestIndex] = int.MinValue; //set the largest element to smallest element possible
			int secondLargest = arr[0];

			//now that the largest element is out of the way, the second largest element will now be the largest,
			//so we can just simply search for the largest element
			for (int i = 1; i < arr.Length; i++)
			{
                if (arr[i] > secondLargest)
                {
                    secondLargest = arr[i];
                }
            }

			return secondLargest;

		}

		public static int CourseSolution(int[] arr)
		{
            int max = int.MinValue;
            int secondmax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                // If ith element is greater than max
                // Then update both max and secondmax
                if (arr[i] > max)
                {
                    secondmax = max;
                    max = arr[i];
                }
                // If the ith element is in between max and secondmax
                // Then update secondmax
                else if (arr[i] > secondmax && arr[i] != max)
                    secondmax = arr[i];
            }

            return secondmax;
        }
	}
}

