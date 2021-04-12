using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_4
{
    class NaveDeTransporte : Nave , iNave
    {
        //contrutor
        public NaveDeTransporte(string nome, int nivelCombustivel, int energia, int velocidade, int posiçãoX, int posiçãoY)
        {
            Nome = nome;
            NivelCombustivel = nivelCombustivel;
            Energia = energia;
            Velocidade = velocidade;
            Posição = new int[2] { posiçãoX, posiçãoY };

            Vivo = true;
        }
        //métodos
        public void VerCarga()
        {

        }
        public void MoverCima()
        {
            throw new NotImplementedException();
        }
        public void MoverBaixo()
        {
            throw new NotImplementedException();
        }
        public void MoverDireita()
        {
            throw new NotImplementedException();
        }
        public void MoverEsquerda()
        {
            throw new NotImplementedException();
        }
        public void VerificarDanos()
        {
            throw new NotImplementedException();
        }
    }
}
