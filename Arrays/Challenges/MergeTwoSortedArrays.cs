namespace Arrays
{
    public class MergeTwoSortedArrays
    {
        //Challenge: Implement a function that merges two sorted arrays into another sorted array.

        public static int[] Solution(int[] arr1, int[] arr2)
        {
			int[] mergedArray = new int[arr1.Length + arr2.Length];
			int mergedArrayIndex = 0;

			//loop through first array, add elements to mergedArray
			for (int i = 0; i < arr1.Length; i++)
			{
				mergedArray[mergedArrayIndex++] = arr1[i];
			}

            //loop through second array, add elements to mergedArray
            for (int j = 0; j < arr2.Length; j++)
			{
				mergedArray[mergedArrayIndex++] = arr2[j];
			}

			Array.Sort(mergedArray); //use the built-in .Sort() method to sort

			return mergedArray;
		}

		public static int[] CourseSolution(int[] arr1, int[] arr2)
		{
			int[] arr3 = new int[arr1.Length + arr2.Length];
			int i = 0, j = 0, k = 0;

			while (i < arr1.Length && j < arr2.Length)
			{
                // if first array element is less than second array element
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];  // copy Ist array element to the new array
                else
                    arr3[k++] = arr2[j++];  // copy 2nd array element to the new array
            }

            // Store remaining elements of the first array
            while (i < arr1.Length)
                arr3[k++] = arr1[i++];

            // Store remaining elements of the second array
            while (j < arr2.Length)
                arr3[k++] = arr2[j++];

            return arr3;
		}
	}
}

