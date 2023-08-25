using System;
namespace Arrays
{
	public class FindFirstUnique
	{

		//Implement a function that takes an array and returns the first unique integer in the array. Return -1 if no unique number is found

		public static int Solution(int[] arr)
		{
			int leftPointer = 0;
			int rightPointer = arr.Length - 1;

			while (leftPointer != rightPointer) //using pointers instead of two for loops for time complexity
			{
				if (arr[rightPointer] == arr[leftPointer]) //if the element at arr[rightPointer] element equals arr[leftPointer] then there's a duplicate element
				{
					leftPointer++; //move the leftPointer to the right one
					rightPointer = arr.Length - 1; //reset the rightPointer to the end of the list
				} else
				{
                    rightPointer--; //if there is no match, then move rightPointer to the left one
                }
            }

            if (leftPointer != arr.Length - 1) //if leftPointer is equal to the index of the last element, this means that the entire array was traversed and no unique element was found
			{
				return arr[leftPointer];
			}

			return -1;
		}
	}
}

