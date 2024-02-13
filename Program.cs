using ObserverDesignPttern.src;
using System;

namespace ObserverDesignPttern
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberGenerator numberGenerator = new NumberGenerator();

           
            NumberObserver observer1 = new NumberObserver(3);
            NumberObserver observer2 = new NumberObserver(7);

            // Register observers
            numberGenerator.AddObserver(observer1);
            numberGenerator.AddObserver(observer2);

            // Start generating random numbers
            numberGenerator.StartGeneratingNumbers(5);

            Console.ReadLine();
        }
    }
}
