using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public class Cliente: IObserver
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public ISubject Subject { get; set; }

        public Cliente(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
          //  this.Subject = subject; // nao funciona
          //  IObserver cliente = new Cliente("Jose", "jose@jose.com");
          // this.Subject.RegisterObserver(this);

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
