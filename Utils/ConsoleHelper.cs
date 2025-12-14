namespace SwitchBoardConsoleApp.Utils
{
    public static class ConsoleHelper
    {
        public static int ReadInt(string message)
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out int value);
            return value;
        }
    }
}