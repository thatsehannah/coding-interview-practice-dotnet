using System;
namespace Arrays
{
    public class TwoNumbersEqualValue
    {
        //Implement a function that takes an array arr and a number value as input and returns an array of two numbers that add up to value.

        public static int[] Solution(int[] arr, int value)
        {
            int[] valueArr = new int[2];

            foreach(int num in arr)
            {
                int difference = value - num;
                int found = Array.Find(arr, target => target == difference);

                if (found != 0)
                {
                    valueArr[0] = num;
                    valueArr[1] = difference;
                    break;
                }
            }

            return valueArr;
        }
    }
}

