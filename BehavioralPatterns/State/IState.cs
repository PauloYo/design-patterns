namespace BehavioralPatterns.State
{
    public interface IState
    {
        void Handle(VendingMachine machine);
    }
}