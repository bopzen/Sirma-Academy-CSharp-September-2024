namespace _08CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length-1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i+1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
