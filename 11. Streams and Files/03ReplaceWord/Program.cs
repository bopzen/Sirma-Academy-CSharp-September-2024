using System.Text;

namespace _03ReplaceWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileInputPath = @"..\..\..\input.txt";
            string fileOutputPath = @"..\..\..\output.txt";
            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(fileInputPath))
            {
                string line = reader.ReadLine();
                string[] replaceText = line.Split(" -> ");
                string oldText = replaceText[0];
                string newText = replaceText[1];

                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(oldText, newText);
                    sb.Append(line);
                }
            }
            using (FileStream stream = new FileStream(fileOutputPath, FileMode.Create, FileAccess.Write))
            {
                byte[] data = Encoding.UTF8.GetBytes(sb.ToString());
                stream.Write(data, 0, data.Length);
            }
        }
    }
}
