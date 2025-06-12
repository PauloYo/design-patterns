namespace BehavioralPatterns.State
{
    public class VendingMachine
    {
        private IState _currentState;

        public VendingMachine()
        {
            _currentState = new NoCoinState();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void InsertCoin()
        {
            _currentState.Handle(this);
        }

        public void SelectProduct()
        {
            _currentState.Handle(this);
        }

        public void DispenseProduct()
        {
            _currentState.Handle(this);
        }
    }
}