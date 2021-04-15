using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Cidade
    {
        public string Nome { get; private set; }
        public Estado Estado { get; private set; }
        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }
    }
}
