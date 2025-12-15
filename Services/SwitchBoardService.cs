using SwitchBoardConsoleApp.Interfaces;
using SwitchBoardConsoleApp.Models;

namespace SwitchBoardConsoleApp.Services
{
    public class SwitchBoardService
    {
        private readonly List<IAppliance> _appliances = new();

        public void AddAppliances(int count, ApplianceType type)
        {
            for (int i = 1; i <= count; i++)
            {
                _appliances.Add(new Appliance(i, type));
            }
        }

        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("==== Switch Board ====");

            for (int i = 0; i < _appliances.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_appliances[i].GetStatus()}");
            }

            Console.WriteLine("0. Exit");
        }

        public void HandleSelection()
        {
            Console.Write("\nSelect device number: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > _appliances.Count)
                return;

            if (choice == 0)
                Environment.Exit(0);

            ShowDeviceMenu(_appliances[choice - 1]);
        }

        private void ShowDeviceMenu(IAppliance appliance)
        {
            Console.Clear();

            Console.WriteLine($"1. Switch {appliance.Type} {appliance.Id} {(appliance.IsOn ? "Off" : "On")}");
            Console.WriteLine("2. Back");

            Console.Write("\nChoose option: ");
            if (Console.ReadLine() == "1")
                appliance.Toggle();
        }
    }
}