namespace BehavioralPatterns.State
{
    public class HasCoinState : IState
    {
        public void Handle(VendingMachine machine)
        {
            Console.WriteLine("Product selected.");
            machine.SetState(new SoldState());
        }
    }
}