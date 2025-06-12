namespace BehavioralPatterns.Observer
{
    public class Order
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _status;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void UpdateStatus(string status)
        {
            _status = status;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_status);
            }
        }
    }
}