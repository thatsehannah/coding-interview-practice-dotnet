namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            RemoveEvenIntegersSolution();
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
    }
}