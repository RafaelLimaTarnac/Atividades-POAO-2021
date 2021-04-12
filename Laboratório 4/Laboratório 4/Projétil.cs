using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_4
{
    class Projétil
    {
        //atributos
        public int PotenciaTiro { get; private set; }
        public int VelocidadeTiro { get; private set; }
        public int[] Posição { get; private set; }
        //construtor
        public Projétil(int potenciaTiro,int velocidadeTiro,int posiçãoX,int posiçãoY)
        {
            PotenciaTiro = potenciaTiro;
            VelocidadeTiro = velocidadeTiro;
            Posição = new int[2] { posiçãoX, posiçãoY };
        }
        //métodos
        public void MovimentaçãoProjétil()
        {
            Posição[1] += VelocidadeTiro;
        }
    }
}
