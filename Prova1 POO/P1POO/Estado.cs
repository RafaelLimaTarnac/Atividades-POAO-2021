using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Estado
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        
        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

    }
}
