using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_4
{
    interface iNave
    {
        //métodos
        void MoverCima();
        void MoverBaixo();
        void MoverDireita();
        void MoverEsquerda();
        string VerificarDanos();
        void LevarDano(int dano);
    }
}
