using System.Diagnostics.CodeAnalysis;

namespace AoC24_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            var lines = File.ReadLines("AoC-01-input.txt");

            foreach (var line in lines)
            {
                // exempel rad: 70740   98650
                // each number column per row turned into a int
                int number1 = int.Parse(line.Substring(0, 5));
                int number2 = int.Parse((line.Substring(8)));
                // each number added to each list
                firstList.Add(number1);
                secondList.Add(number2);
            }

            // now sort the lists in ascending order
            firstList.Sort();
            secondList.Sort();

            // a new list containing the differences in distance
            List<int> deltaList = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                // used absolute to make sure that we don't get any negative numbers
                // negative numbers would mess up our sum
                int deltaNumber = System.Math.Abs(firstList[i] - secondList[i]);
                // Add the number to the deltaList
                deltaList.Add(deltaNumber);
            }
            // Sum up the deltaList
            int sum = deltaList.Sum();
            Console.WriteLine($"The sum of all distances: {sum}");
        }
    }
}
