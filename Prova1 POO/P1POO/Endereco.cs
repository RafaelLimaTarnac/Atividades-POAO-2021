using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Endereco
    {
        public long Numero { get; private set; }
        public string Rua { get; private set; }
        public Bairro Bairro { get; private set; }
        public Cidade Cidade { get; private set; }

        public Endereco(long numero, string rua, Bairro bairro, Cidade cidade)
        {
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
