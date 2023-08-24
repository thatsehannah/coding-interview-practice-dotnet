using System;
namespace Arrays
{
	public class ProductOfAllElements
	{

        //Challenge: Implement a function that takes an array arr as an input, and returns an array so that each index has a product of all the
		//numbers present in the array except the number stored at that index.

        public static int[] Solution(int[] arr)
		{
			int[] temp = new int[arr.Length]; //temp array to store the products
			for (int i = 0; i < arr.Length; i++)
			{
				int product = 1; //on each iteration, start out with the product set to 1
				for (int j = 0; j < arr.Length; j++)
				{
					if (j != i) //we don't want to include the current index that we're on in the outer loop
					{
						product *= arr[j]; //update the value of product to be its current value * arr[j]
					}
				}
                temp[i] = product; //after looping through all of the elements, the total product should be calculated
            }

			return temp;
		}
	}
}

