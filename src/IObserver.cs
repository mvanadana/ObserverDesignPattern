﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPttern.src
{
    public interface IObserver
    { 
        void Update(int randomNumber);
    }
}
