internal class Program
{

    static void Main(string[] args) // main method which runs program
    {
        Console.WriteLine("\t\t----- Practical-6 ----- Events -----");
        ProcessBusinessLogic pbl = new ProcessBusinessLogic();
        Subscriber sub = new Subscriber(); 
        pbl.ProcessCompleted += sub.bl_ProcessComplete;// assigning the event handler
        pbl.startProcess();
        Console.WriteLine("\tHello from Main");
    }
}
