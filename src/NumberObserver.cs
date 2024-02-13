using System;
using System.Collections.Generic;

namespace ObserverDesignPttern
{
    public class NumberObserver : src.IObserver
    {
        private int targetNumber;

        public NumberObserver(int targetNumber)
        {
            this.targetNumber = targetNumber;
        }

        public void Update(int randomNumber)
        {
            if (randomNumber == targetNumber)
            {
                Console.WriteLine($"Your number ({targetNumber}) matched!");
            }
        }
    }
}