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
            Console.WriteLine("Part 1: ");
            Console.WriteLine($"The sum of all distances: {sum}");



            // Part 2 Similarity score
            // number1 = How often each number from the left list appears in the right list. 
            // multiply number of instances in other list with number...

            List<int> similarityFactor = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                int number = firstList[i];
                int result = 0;
                // if second list contains number, count how many times and set that to result
                if (secondList.Contains(number))
                {
                    result = secondList.Where(x => x.Equals(number)).Sum();
                }
                similarityFactor.Add(result);
            }

            List<int> similarityResult = new List<int>();

            // multiply similarityFactor with firstList
            for (int i =0; i < firstList.Count;i++) 
            {
                int similarity = 0;
                // don't even bother multiplying if its 0 tho
                if (similarityFactor[i] != 0)
                {
                    similarity = similarityFactor[i] * firstList[i];
                }
                similarityResult.Add(similarity);
            }

            // sum the similarityFactor and present it :)

            Console.WriteLine("Part 2");
            Console.WriteLine($"The similarity score is: {similarityFactor.Sum()}");

        }
    }
}
