class Subscriber // instead of creating the static method , here class object will used to call the bl_ProcessComplete Method
{
    public void bl_ProcessComplete(object sender, EventArgs e)
    {
        Console.WriteLine("\tMethod Invoked\n");
    }
}