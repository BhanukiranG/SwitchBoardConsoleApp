using SwitchBoardConsoleApp.Interfaces;

namespace SwitchBoardConsoleApp.Models
{
    public abstract class ApplianceBase : IAppliance
    {
        public int Id { get; }
        public string Name { get; }
        public bool IsOn { get; private set; }

        protected ApplianceBase(int id, string name)
        {
            Id = id;
            Name = name;
            IsOn = false;
        }

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