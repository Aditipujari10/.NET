using System;
using System.Threading.Tasks;

class Program
{
    // Asynchronous method
    public static async Task LongTask()
    {
        Console.WriteLine("Task started...");

        // Simulate long running task
        await Task.Delay(3000);

        Console.WriteLine("Task completed after 3 seconds.");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("EXP_05");
        Console.WriteLine("Program started");

        // Calling async method
        await LongTask();

        Console.WriteLine("Program finished");

        Console.ReadLine();
    }
}