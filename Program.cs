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
                // Change for something substring
                List<string> list = line.Split("    ").ToList();
                //int number1 = list[0];
                firstList.Add(int.Parse(list[0]));
                secondList.Add(int.Parse(list[1]));
            }
            Console.WriteLine("First list: \n");
            Console.WriteLine(firstList);
            Console.WriteLine("\nSecond list: ");
            Console.WriteLine(secondList);
        }
    }
}
