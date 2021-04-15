using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class PessoaFisica : Pessoa
    {
        public string Cpf { get; private set; }
        public bool Vip { get; private set; }
        public PessoaFisica(string nome, Endereco endereco, string email, string cpf, long id, bool vip) : base(nome, endereco, email, id)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Cpf = cpf;
            ID = id;
            Vip = vip;
        }
    }
}
