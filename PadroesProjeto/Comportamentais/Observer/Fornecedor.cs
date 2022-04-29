using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Observer
{
    public class Fornecedor: IObserver
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public ISubject Subject { get; set; }

        public Fornecedor(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
            //this.Subject = subject;
            //this.Subject.RegisterObserver(this);
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
