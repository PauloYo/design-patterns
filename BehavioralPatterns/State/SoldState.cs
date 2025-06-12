namespace BehavioralPatterns.State
{
    public class SoldState : IState
    {
        public void Handle(VendingMachine machine)
        {
            Console.WriteLine("Product dispensed.");
            machine.SetState(new NoCoinState());
        }
    }
}