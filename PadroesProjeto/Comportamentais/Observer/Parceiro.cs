using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public class Parceiro: IObserver
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public ISubject Subject { get; set; }

        public Parceiro(string nome, string email, ISubject subject)
        {
            this.Nome = nome;
            this.Email = email;
            this.Subject = subject;
        }

        public void update(string mensagem)
        {
            Observer.Email.EnviarEmail(this, mensagem);
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetEmail()
        {
            return this.Email;
        }
    }
}
