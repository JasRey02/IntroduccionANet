public class HibridoLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
        File.WriteAllText("logHibrido.txt",message);
    }
}