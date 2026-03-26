internal class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\t\t----- Practical-6 ----- Events -----");
        ProcessBusinessLogic pbl = new ProcessBusinessLogic();
        Subscriber sub = new Subscriber();
        pbl.ProcessCompleted += sub.bl_ProcessComplete;
        pbl.startProcess();
        Console.WriteLine("\tHello from Main");
    }
}