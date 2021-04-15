using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; private set; }
        public PessoaJuridica(string nome, Endereco endereco, string email, string cnpj, long id) : base(nome, endereco, email, id)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Cnpj = cnpj;
            ID = id;
        }
    }
}
