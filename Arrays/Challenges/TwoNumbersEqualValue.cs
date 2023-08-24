using System;
namespace Arrays
{
    public class TwoNumbersEqualValue
    {
        //Challenge: Implement a function that takes an array arr and a number value as input and returns an array of two numbers that add up to value.

        public static int[] Solution(int[] arr, int value)
        {
            int[] valueArr = new int[2];

            foreach(int num in arr)
            {
                if (num == value)
                {
                    valueArr[0] = num;
                    valueArr[1] = 0;
                    break;
                } else
                {
                    int difference = value - num; //subtract the current num from the target value to get the difference
                    int found = Array.Find(arr, target => target == difference); //looks through the array to see if the difference exists

                    if (found != 0) //if found doesn't equal 0 (default value) which means that the difference does exist in the array
                    {
                        valueArr[0] = num;
                        valueArr[1] = difference;
                        break;
                    }
                }
            }

            return valueArr;
        }
    }
}

