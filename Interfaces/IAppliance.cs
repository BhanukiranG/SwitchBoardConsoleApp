using SwitchBoardConsoleApp.Models;

namespace SwitchBoardConsoleApp.Interfaces
{
    public interface IAppliance
    {
        int Id { get; }
        ApplianceType Type { get; }
        bool IsOn { get; }
        void Toggle();
        string GetStatus();
    }
}