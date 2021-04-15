using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    abstract class Pessoa
    {
        public long ID { get; protected set; }
        public string Nome { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public string Email { get; protected set; }

        protected Pessoa(string nome, Endereco endereco, string email, long id)
        {
            ID = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }
    }
}
