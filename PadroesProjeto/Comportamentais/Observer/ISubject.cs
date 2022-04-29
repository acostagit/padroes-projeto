using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObserver();

    }
}
