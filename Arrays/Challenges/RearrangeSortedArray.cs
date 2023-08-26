namespace Arrays
{
    public class RearrangeSortedArray
    {
        //Implement a function that takes a sorted array arr and will rearrange the elements of a sorted array
        //such that the first position will have the largest number, the second will have the smallest,
        //the third will have second largest, and so on.

        public static int[] Solution(int[] arr)
        {
            int largeIndex = arr.Length - 1; //pointer for the end of the array
            int smallIndex = 0; //pointer for the beginning of the array
            int currentIndex = 0;
            int[] newArray = new int[arr.Length];

            while (currentIndex < arr.Length) //as we're iterating through the array, ch
            {
                if (currentIndex % 2 == 0)
                {
                    newArray[currentIndex++] = arr[largeIndex--]; //for even indicies, push the large numbers in that particular spot in the array
                } else
                {
                    newArray[currentIndex++] = arr[smallIndex++]; //for odd indicies, push the small numbers in that particular spot in the array
                }
            }

            return newArray;
        }
    }
}

