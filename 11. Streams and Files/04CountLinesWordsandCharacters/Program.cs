namespace _04CountLinesWordsandCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\input.txt";
            int linesCount = 0;
            int wordsCount = 0;
            int charactersCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    linesCount++;
                    wordsCount += line.Split(" ").ToArray().Length;
                    charactersCount += line.Length;
                }
            }
            Console.WriteLine(linesCount);
            Console.WriteLine(wordsCount);
            Console.WriteLine(charactersCount);
        }
    }
}
