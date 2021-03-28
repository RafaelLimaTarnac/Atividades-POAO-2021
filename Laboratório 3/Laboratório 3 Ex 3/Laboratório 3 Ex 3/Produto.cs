using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_3
{
    class Produto
    {
        
        public string Titulo { get; protected set; }
        public double Preço { get; protected set; }

        protected void InformarDescrição(string Prefixo, string Informação)
        {
            Console.WriteLine("{0}{1}\nTítulo:{2}", Prefixo, Informação, Titulo);
        }
        protected void InformarPreço()
        {
            Console.WriteLine("Preço do '{0}':R${1}\n", Titulo, Preço);
        }
    }
}
