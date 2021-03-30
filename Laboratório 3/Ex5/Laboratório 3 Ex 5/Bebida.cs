using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_5
{
    class Bebida : ItemMenu
    {
        // construtor
        public Bebida(string nome,double precoPeq,double precoMed, double precoGra)
        {
            Nome = nome;
            Preco = new double[3] {precoPeq,precoMed,precoGra};
        }
    }
}
