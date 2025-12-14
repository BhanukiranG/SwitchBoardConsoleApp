namespace SwitchBoardConsoleApp.Interfaces
{
    public interface IAppliance
    {
        int Id { get; }
        string Name { get; }
        bool IsOn { get; }

        void Toggle();
        string GetStatus();
    }
}
