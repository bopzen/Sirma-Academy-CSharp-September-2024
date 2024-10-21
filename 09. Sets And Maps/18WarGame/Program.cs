namespace _18WarGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] playerOne = Console.ReadLine().Split(" ").Select(int.Parse).Distinct().ToArray();
			int[] playerTwo = Console.ReadLine().Split(" ").Select(int.Parse).Distinct().ToArray();

			Queue<int> playerOneCards = new Queue<int>(playerOne);
			Queue<int> playerTwoCards = new Queue<int>(playerTwo);	

			for (int i = 0; i < 50; i++)
			{
				int playerOneHand = playerOneCards.Dequeue();
				int playerTwoHand = playerTwoCards.Dequeue();

				if (playerOneHand > playerTwoHand)
				{
					if (!playerOneCards.Contains(playerOneHand))
					{
                        playerOneCards.Enqueue(playerOneHand);
                    }
					if (!playerOneCards.Contains(playerTwoHand))
					{
						playerOneCards.Enqueue(playerTwoHand);
					}
				}
				else if (playerTwoHand > playerOneHand)
				{
					if (!playerTwoCards.Contains(playerTwoHand))
					{
                        playerTwoCards.Enqueue(playerTwoHand);
                    }
					if (!playerTwoCards.Contains(playerOneHand))
					{
                        playerTwoCards.Enqueue(playerOneHand);
                    }				
				}
				else
				{
					playerOneCards.Enqueue(playerOneHand);
					playerTwoCards.Enqueue(playerTwoHand);
				}

				if (playerOneCards.Count == 0 || playerTwoCards.Count == 0)
				{
					break;
				}
			}

			if (playerOneCards.Count < playerTwoCards.Count) 
			{
				Console.WriteLine("Second player wins!");
			} 
			else if (playerOneCards.Count > playerTwoCards.Count)
			{
                Console.WriteLine("First player wins!");
            }
			else
			{
				Console.WriteLine("Draw!");
			}
		}
	}
}
