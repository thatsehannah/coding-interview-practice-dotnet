namespace Arrays
{
    //Implement a function that takes an array arr and rotates it right by 1.
    //This means that the rightmost element will appear at the leftmost position in the array.

    public class ShiftArrayToRight
    {
        public static void Solution(int[] arr)
        {
            int currentIndex = 0; //storing the current index
			int nextValue = arr[0]; //this will hold the element that will be inserted at currentIndex + 1
            while (currentIndex <= arr.Length - 1) //
			{
				if (currentIndex == arr.Length - 1) //if currentIndex is equal to the last element, we're at the end 
                {
					arr[0] = nextValue; //store that last element which will be saved in nextValue in the first position
                    break;
				} else
				{
					int temp = arr[currentIndex + 1]; //store the element at currentIndex + 1 in temp before we swap
                    arr[currentIndex + 1] = nextValue; //setting currentIndex + 1 equal to the value ahead of it
					nextValue = temp; //nextValue now stores currentIndex + 1's previous value
                    currentIndex++; //incrementing currentIndex to keep it moving
                }
			}
		}

		//way simplier than my solution
		//they went backwards, I went forwards
		public static void CourseSolution(int[] arr)
		{
            //Store the last element of the array.
            //Start from the last index and right shift the array by one.
            //Make the last element stored to be the first element of the array.
            int lastElement = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }
	}
}

