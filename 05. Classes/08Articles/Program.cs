namespace _08Articles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] articleInput = Console.ReadLine().Split(", ");
			Article article = new Article(articleInput[0], articleInput[1], articleInput[2]);
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] command = Console.ReadLine().Split(": ");
				string action = command[0];
				string newData = command[1];
				if (action == "Edit")
				{
					article.Content = newData;
				}
				else if (action == "ChangeAuthor")
				{
					article.Author = newData;
				}
				else if (action == "Rename")
				{
					article.Title = newData;
				}
			}

			Console.WriteLine(article);
		}
	}

	public class Article
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Author { get; set; }

		public Article(string title, string content, string author)
		{
			Title = title;
			Content = content;
			Author = author;
		}

		public void Edit(string newContent)
		{
			Content = newContent;
		}
		public void ChangeAuthor(string newAuthor)
		{
			Author = newAuthor;
		}
		public void Rename(string newTitle)
		{
			Title = newTitle;
		}
		public override string ToString()
		{
			return $"{Title} - {Content}: {Author}";
		}
	}


}
