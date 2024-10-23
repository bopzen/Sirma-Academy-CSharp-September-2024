using System.Text;

namespace _14HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string title = Console.ReadLine();
            sb.Append("<h1>\n");
            sb.Append($"    {title}\n");
            sb.Append("</h1>\n");

            string article = Console.ReadLine();
            sb.Append("<article>\n");
            sb.Append($"    {article}\n");
            sb.Append("</article>\n");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                {
                    break;
                }
                sb.Append("<div>\n");
                sb.Append($"    {input}\n");
                sb.Append("</div>\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
