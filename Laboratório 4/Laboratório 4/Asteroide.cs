using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_4
{
    class Asteroide
    {
        //atributos
        public int Dano { get; private set; }
        public int[] Posição { get; private set; }
        //métodos
        public Asteroide(int dano, int posiçãoX, int posiçãoY)
        {
            Dano = dano;
            Posição = new int[2] { posiçãoX, posiçãoY };
        }
    }
}
