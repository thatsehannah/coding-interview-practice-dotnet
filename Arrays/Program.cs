﻿namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            FindSmallestInArraySolution();
        }

        static void FindSmallestInArraySolution()
        {
            int[] arr = { 9, 2, 3, 6 };
            int smallest = FindSmallestInArray.Solution(arr);
            Console.WriteLine($"Smallest value in array: {smallest}");
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

        static void TwoNumbersEqualValueSolution()
        {
            int[] arr = { 1, 21, 3, 14, 5, 60, 7, 6 };
            int[] result = TwoNumbersEqualValue.Solution(arr, 81);
            Console.WriteLine("Target: " + 81);
            Console.WriteLine("Num 1 is " + result[0]);
            Console.WriteLine("Num 2 is " + result[1]);
        }

        static void ProductOfAllElementsSolution()
        {
            int[] arr = {4,2,1,5,0};
            int[] result = ProductOfAllElements.Solution(arr);
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}