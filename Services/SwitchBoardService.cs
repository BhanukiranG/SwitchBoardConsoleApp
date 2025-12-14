using SwitchBoardConsoleApp.Interfaces;

namespace SwitchBoardConsoleApp.Services
{
    public class SwitchBoardService
    {
        private readonly List<IAppliance> _appliances = [];

        public void AddAppliance(IAppliance appliance)
        {
            _appliances.Add(appliance);
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
                Environment.Exit(0); // Exit the application immediately when the user selects 0

            var appliance = _appliances[choice - 1];
            ShowDeviceMenu(appliance);
        }

        private static void ShowDeviceMenu(IAppliance appliance)
        {
            Console.Clear();
            Console.WriteLine($"1. Switch {appliance.Name} {appliance.Id} {(appliance.IsOn ? "Off" : "On")}");
            Console.WriteLine("2. Back");

            Console.Write("\nChoose option: ");
            var input = Console.ReadLine();

            if (input == "1")
                appliance.Toggle();
        }
    }
}