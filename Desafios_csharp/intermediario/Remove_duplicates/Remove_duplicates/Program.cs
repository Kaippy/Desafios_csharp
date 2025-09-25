namespace Remove_duplicates
{
    public static class Program
    {
        public static void Main()
        {
            int[] numbers = new int[10];

            List<int> newNumbers = new List<int>();

            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!newNumbers.Contains(numbers[i]))
                {
                    newNumbers.Add(numbers[i]);
                }

            }
            foreach (int num in newNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
