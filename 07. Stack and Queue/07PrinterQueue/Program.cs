namespace _07PrinterQueue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<string> queue = new Queue<string>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "print")
				{
					break;
				}
				if (input == "cancel")
				{
					if (queue.Count > 0)
					{
						Console.WriteLine($"Cancelled {queue.Dequeue()}");
					}
					else
					{
						Console.WriteLine("Standby");
					}
				}
				else
				{
					queue.Enqueue(input);
					Console.WriteLine(input);
				}

			}
		}
	}
}
