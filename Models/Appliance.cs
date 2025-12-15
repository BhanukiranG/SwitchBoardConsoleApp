using SwitchBoardConsoleApp.Interfaces;

namespace SwitchBoardConsoleApp.Models
{
    public class Appliance(int id, ApplianceType type) : IAppliance
    {
        public int Id { get; } = id;
        public ApplianceType Type { get; } = type;
        public bool IsOn { get; private set; }

        public void Toggle()
        {
            IsOn = !IsOn;
        }

        public string GetStatus()
        {
            return $"{Type} {Id} is {(IsOn ? "On" : "Off")}";
        }
    }
}