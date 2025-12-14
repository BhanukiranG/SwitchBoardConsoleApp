namespace SwitchBoardConsoleApp.Utils
{
    public static class ConsoleHelper
    {
        public static int ReadInt(string message)
        {
            Console.Write(message);
            _ = int.TryParse(Console.ReadLine(), out int value);
            return value;
        }
    }
}