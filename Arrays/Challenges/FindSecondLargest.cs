using System;
using System.Drawing;

namespace Arrays
{
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

            // Keep track of the maximum value, whenever the value at an array index is greater
            // than the current maximum value, then make that max value second max value and
            // make that index value maximum value 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }//end of for-loop

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > secondmax && arr[i] < max)
                    secondmax = arr[i];
            }//end of for-loop

            return secondmax;
        }
	}
}

