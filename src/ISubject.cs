

using ObserverDesignPttern.src;

namespace ObserverDesignPttern
{
        public interface ISubject
        {
            void AddObserver(IObserver observer);
            void RemoveObserver(IObserver observer);
            void NotifyObservers();
        }
}
