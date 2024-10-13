namespace _15Factorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] robotsInput = Console.ReadLine().Split("|");
            List<Robot> robots = new List<Robot>();
            foreach (string robotString in robotsInput)
            {
                string[] robotData = robotString.Split("-");
                robots.Add(new Robot(robotData[0], int.Parse(robotData[1])));
            }

            string[] startTime = Console.ReadLine().Split(":");
            int startHour = int.Parse(startTime[0]);
            int startMinute = int.Parse(startTime[1]);
            int startSecond = int.Parse(startTime[2]);
            int currentTime = startHour * 3600 + startMinute * 60 + startSecond;

            Queue<string> products = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                products.Enqueue(input);

                while (products.Count > 0)
                {
                    currentTime++;
                    string currentProduct = products.Dequeue();
                    bool isProcessed = false;

                    foreach (var robot in robots)
                    {
                        if (currentTime >= robot.AvailableAt)
                        {
                            Console.WriteLine($"{robot.Name} - {currentProduct} [{currentTime / 3600 % 24:D2}:{currentTime / 60 % 60:D2}:{currentTime % 60:D2}]");
                            isProcessed = true;
                            robot.AvailableAt = currentTime + robot.ProcessTime;
                            break;
                        }
                    }
                    if (!isProcessed)
                    {
                        products.Enqueue(currentProduct);
                    }
                }

                

            }
        }

        class Robot
        {
            public string Name { get; set; }
            public int ProcessTime { get; set; }
            public int AvailableAt { get; set; } = 0;

            public Robot(string name, int processTime)
            {
                Name = name;
                ProcessTime = processTime;
            }
        }
    }
}
