using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_2
{
    class Corrente : Conta
    {
        public Corrente(string nome , int numeroIdent)
        {
            this.nome = nome;
            this.numeroIdent = numeroIdent;
            saldo = 0;
        }
        public void Sacar(float removido)
        {
            Sacar(removido,0.0037f);
        }
        public void Transferir(Conta receptor, float quantia)
        {
            Transferir(receptor, quantia, 0.001f);
        }
        public void VerificarConta()
        {
            Informações();
        }
        public void Depositar(int adicionado)
        {
            base.Depositar(adicionado);
        }
    }
}