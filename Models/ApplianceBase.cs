using SwitchBoardConsoleApp.Interfaces;

namespace SwitchBoardConsoleApp.Models
{
    public abstract class ApplianceBase(int id, string name) : IAppliance
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public bool IsOn { get; private set; } = false;

        public void Toggle()
        {
            IsOn = !IsOn;
        }

        public string GetStatus()
        {
            return $"{Name} {Id} is {(IsOn ? "On" : "Off")}";
        }
    }
}