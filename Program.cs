using SwitchBoardConsoleApp.Models;
using SwitchBoardConsoleApp.Services;
using SwitchBoardConsoleApp.Utils;

namespace SwitchBoardConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var switchBoardService = new SwitchBoardService();

            int fans = ConsoleHelper.ReadInt("Enter number of Fans: ");
            int acs = ConsoleHelper.ReadInt("Enter number of ACs: ");
            int bulbs = ConsoleHelper.ReadInt("Enter number of Bulbs: ");

            for (int i = 1; i <= fans; i++)
                switchBoardService.AddAppliance(new Fan(i));

            for (int i = 1; i <= acs; i++)
                switchBoardService.AddAppliance(new AC(i));

            for (int i = 1; i <= bulbs; i++)
                switchBoardService.AddAppliance(new Bulb(i));

            while (true)
            {
                System.Console.WriteLine("\nHe he...");
                switchBoardService.DisplayMainMenu();
                switchBoardService.HandleSelection();
            }
        }
    }
}