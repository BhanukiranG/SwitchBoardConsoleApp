using SwitchBoardConsoleApp.Models;
using SwitchBoardConsoleApp.Services;
using SwitchBoardConsoleApp.Utils;

namespace SwitchBoardConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var switchBoard = new SwitchBoardService();

            int fans = ConsoleHelper.ReadInt("Enter number of Fans: ");
            int acs = ConsoleHelper.ReadInt("Enter number of ACs: ");
            int bulbs = ConsoleHelper.ReadInt("Enter number of Bulbs: ");

            switchBoard.AddAppliances(fans, ApplianceType.Fan);
            switchBoard.AddAppliances(acs, ApplianceType.AC);
            switchBoard.AddAppliances(bulbs, ApplianceType.Bulb);

            while (true)
            {
                switchBoard.DisplayMainMenu();
                switchBoard.HandleSelection();
            }
        }
    }
}