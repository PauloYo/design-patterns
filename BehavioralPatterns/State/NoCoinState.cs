namespace BehavioralPatterns.State
{
    public class NoCoinState : IState
    {
        public void Handle(VendingMachine machine)
        {
            Console.WriteLine("Coin inserted.");
            machine.SetState(new HasCoinState());
        }
    }
}