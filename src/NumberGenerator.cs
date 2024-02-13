using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using ObserverDesignPttern.src;

namespace ObserverDesignPttern.src
{
    public class NumberGenerator : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private Random random = new Random();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            int randomNumber = random.Next(1, 11); // Generating a random number between 1 and 10
            Console.WriteLine($"Generated random number: {randomNumber}");

            foreach (var observer in observers)
            {
                observer.Update(randomNumber);
            }
        }

        public void StartGeneratingNumbers(int numberOfGenerations)
        {
            for (int i = 0; i < numberOfGenerations; i++)
            {
                NotifyObservers();
                System.Threading.Thread.Sleep(1000); // Delay for better observation
            }
        }
    }
}
