namespace Raindrops
{
    internal class Program
    {
        public static string ConvertToRainSound(int number)
        {
            string result = "";

           
            if (number % 3 == 0)
            {
                result += "Pling";
            }
            if (number % 5 == 0)
            {
                result += "Plang";
            }
            if (number % 7 == 0)
            {
                result += "Plong";
            }
            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        static void Main()
        {
            
            int[] numbersToCheck = { 28, 30, 34 };

            foreach (int number in numbersToCheck)
            {
                string result = ConvertToRainSound(number);
                Console.WriteLine($"{number}: {result}");
            }
        }
    }
}
