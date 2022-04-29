using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public class Newsletter : ISubject
    {
        public List<IObserver> Observers { get; set; }

        private IObserver[] observers;

        public List<string> Mensagens { get; set; }

        public void NotifyObserver()
        {
            foreach (var observador in this.Observers)
            {
                observador.update(this.Mensagens[0]);
            }
        }

        public void AdicionaMensagem(List<IObserver> observers)
        {
            //this.Mensagens = mensagens;
            //this.Mensagens.Add(mensagens[mensagens.Count-1]);

            this.Observers = observers;
            this.NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            //this.Observers = observer;
            this.Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            foreach (var observador in this.Observers)
            {
                if (observador.Equals(observer))
                {
                    this.Observers.Remove(observador);
                    Console.WriteLine("Observer removido: {0}", observer.GetNome());
                }
            }
        }
    }
}
