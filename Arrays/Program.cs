namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            MergeTwoSortedArraysSolution();
        }

        static void RemoveEvenIntegersSolution()
        {
            int[] arr = { 1, 2, 4, 5, 10, 6, 3 };
            arr = RemoveEvenIntegers.Solution(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void MergeTwoSortedArraysSolution()
        {
            int[] arr1 = { 1, 3, 4, 5 };
            int[] arr2 = { 2, 6, 7, 8 };
            int[] arr3 = MergeTwoSortedArrays.Solution(arr1, arr2);
            //int[] arr3 = MergeTwoSortedArrays.CourseSolution(arr1, arr2);
            foreach (int num in arr3)
            {
                Console.Write(num + " ");
            }
        }
    }
}