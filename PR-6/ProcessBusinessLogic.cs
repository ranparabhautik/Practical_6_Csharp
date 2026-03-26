class ProcessBusinessLogic
{
    public event EventHandler ProcessCompleted; // event declaration
    public void startProcess() // method which invokes the event
    {
        Console.WriteLine("\tProcess Has Started\n");
        Thread.Sleep(2000);
        OnProcessCompleted();
    }
    protected virtual void OnProcessCompleted() // virtual is used here just for make method overridable in derived class , as there is not such mention of derived class in practical to override the method.
    {
        ProcessCompleted?.Invoke(this, EventArgs.Empty);
    }
}
