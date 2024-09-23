namespace _09Calculate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numOne = int.Parse(Console.ReadLine());
			int numTwo = int.Parse(Console.ReadLine());
			Console.WriteLine($"The sum is: {numOne + numTwo}");
			Console.WriteLine($"The difference is: {numOne - numTwo}");
			Console.WriteLine($"The product is: {numOne * numTwo}");
			Console.WriteLine($"The average is: {(double)(numOne + numTwo)/2:F5}");
		}
	}
}
