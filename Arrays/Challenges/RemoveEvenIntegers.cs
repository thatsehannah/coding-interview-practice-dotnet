using System;
namespace Arrays
{
	public class RemoveEvenIntegers
	{
        //Challenge: Implement a function that takes an array arr and removes all the even elements from the given array.

        public static int[] Solution(int[] arr)
        {
            //This variable will serve two purposes:
            //1. will be used so I can put the odd numbers at the front of the array
            //2. will also serve as the size of the new array that I will be returning which will contain all of the odd numbers from 0 up to indexForOddNum
            int indexForOddNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[indexForOddNum] = arr[i]; //moving the odd numbers to the front of the arr array for easier access later
                    indexForOddNum++; //increasing the index
                }
            }

            int[] tempArray = new int[indexForOddNum]; //creating a new array with a fixed size equal to indexForOddNum since this also indicates how many odd numbers we have in the array

            for (int i = 0; i < indexForOddNum; i++)
            {
                tempArray[i] = arr[i];
            }

            return tempArray;
        }
    }
}

