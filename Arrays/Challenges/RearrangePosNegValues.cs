using System;
using System.Drawing;

namespace Arrays
{
	public class RearrangePosNegValues
	{
		public static int[] Solution(int[] arr)
		{
			int[] newArray = new int[arr.Length];
			int positiveIndex = 0;
			int negativeIndex = arr.Length - 1;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 0)
				{
					newArray[positiveIndex++] = arr[i];
				} else
				{
					newArray[negativeIndex--] = arr[i];
				}
			}

			return newArray;
		}

		public static int[] CourseSolution(int[] arr)
		{
            int[] newArray = new int[arr.Length];
            int newArray_index = 0;

            //Fill newArray with negative values first.
            //Then fill it with positive values.
            //In the end, insert every element of newArray back into the original array, arr.
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    newArray[newArray_index++] = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] >= 0)
                    newArray[newArray_index++] = arr[i];
            }

			return newArray;
        }
	}
}

