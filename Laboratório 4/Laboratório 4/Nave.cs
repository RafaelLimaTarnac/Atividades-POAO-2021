using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_4
{
    abstract class Nave
    {
        //atributos
        public string Nome { get; protected set; }
        public int NivelCombustivel { get; protected set; }
        public int Energia { get; protected set; }
        public int Velocidade { get; protected set; }
        public int[] Posição { get; protected set; }
        public bool Vivo { get; protected set; }
        public bool EInimigo { get; protected set; }
        public void Morte()
        {
            Vivo = false;
        }
    }
}
