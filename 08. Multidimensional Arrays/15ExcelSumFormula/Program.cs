namespace _15ExcelSumFormula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int m = size[0];
            int n = size[1];
            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            string[] input = Console.ReadLine().Split(":");
            string start = input[0];
            string end = input[1];
            int startRow = GetRowNumber(start);
            int startCol = GetColumnNumber(start);
            int endRow = GetRowNumber(end);
            int endCol = GetColumnNumber(end);

            int sum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }
        public static int GetColumnNumber(string cell)
        {
            int columnNumber = 0;

            foreach (var letter in cell)
            {
                if (char.IsLetter(letter))
                {
                    int letterNumber = (int)letter - 64;
                    columnNumber = columnNumber * 26 + letterNumber;
                }
            }
            return columnNumber-1;
        }

        public static int GetRowNumber(string cell)
        {
            string numberString = "";
            foreach (var letter in cell)
            {
                if (char.IsDigit(letter))
                {
                    numberString += letter;
                }
            }
            return int.Parse(numberString)-1;
        }
    }
}
