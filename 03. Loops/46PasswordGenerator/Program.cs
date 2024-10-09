namespace _46PasswordGenerator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int l = int.Parse(Console.ReadLine());
			string password = "";
			for (int first = 1; first <= n; first++)
			{	
				for (int second = 1; second <= n; second++)
				{
					for (int third = 1; third <= l; third++)
					{
						for (int fourth	= 1 ; fourth <= l; fourth++)
						{
							for(int fifth = 1 ; fifth <= n; fifth++)
							{
								if (fifth > first && fifth > second)
								{
									password = first.ToString() + second.ToString() + (char)(third + 96) + (char)(fourth + 96) + fifth.ToString();
									Console.WriteLine(password);
								}							
							}
						}
					}
				}
			}
		}
	}
}
