using System;

namespace task02
{
    internal static class Program
    {
        private static void Main()
        {
            var workers = new Worker[] { };
            for (var i = 0; i < 5; i++)
            {
                var worker = new Worker();
                Console.WriteLine("Worker {0}:", i + 1);
                Console.WriteLine("First name: ");
                worker.FirstName = Console.ReadLine();
                Console.WriteLine("Initials: ");
                worker.Initials = Console.ReadLine();
                Console.WriteLine("Position: ");
                worker.Position = Console.ReadLine();
                try
                {
                    Console.WriteLine("Start year:");
                    worker.StartYear = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                Array.Resize(ref workers, workers.Length + 1);
                workers[^1] = worker;
            }

            Array.Sort(workers, (worker, worker1) => worker.StartYear);
            //workers = workers.OrderBy(i => i.FirstName).ToArray();

            Console.WriteLine("Start year threshold:");
            var startYearThreshold = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            foreach (var item in workers)
            {
                if (item.StartYear > startYearThreshold)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
        }
    }
}