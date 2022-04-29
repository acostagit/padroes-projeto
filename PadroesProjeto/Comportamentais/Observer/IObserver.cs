using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public interface IObserver
    {
        public void update(string mensagem);
        public string GetNome();
        public string GetEmail();
    }
}
