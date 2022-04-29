using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public class Email
    {
        public static void EnviarEmail(IObserver observer, string mensagem)
        {
            Console.WriteLine("Email enviado para...{0} {1}", observer.GetNome(), observer.GetEmail());
            Console.WriteLine("Mensagem: {0}", mensagem);
        }
    }
}
