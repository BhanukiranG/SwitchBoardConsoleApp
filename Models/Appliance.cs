using SwitchBoardConsoleApp.Interfaces;

namespace SwitchBoardConsoleApp.Models
{
    public class Appliance : IAppliance
    {
        public int Id { get; }
        public ApplianceType Type { get; }
        public bool IsOn { get; private set; }

        public Appliance(int id, ApplianceType type)
        {
            Id = id;
            Type = type;
            IsOn = false;
        }

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