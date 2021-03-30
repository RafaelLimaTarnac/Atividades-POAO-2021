using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_5
{
    class Aperitivo : ItemMenu
    {
        // construtor
        public Aperitivo(string nome)
        {
            Nome = nome;
            Preco = new double[1] {10};
        }
    }
}
