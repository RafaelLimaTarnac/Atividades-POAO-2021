using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_2
{
    class Conta
    {
        protected int numeroIdent;
        protected string nome;
        protected float saldo;

        protected virtual void Depositar(int adicionado)
        {
            saldo += adicionado;
            
            Console.WriteLine("{0} adicinou {1} à sua conta\n", nome, adicionado);
        }
        protected void Transferir(Conta receptor, float quantia, float imposto)
        {
            if (saldo - (quantia + (quantia * imposto)) > 0)
            {
                saldo -= quantia;
                quantia -= quantia * imposto;
                receptor.saldo += quantia;
                Console.WriteLine("{0} transferiu {1}(valor com impostos) para {2}, restando: {3}\n", nome,quantia,receptor.nome,saldo);
            }
            else
            {
                Console.WriteLine("{0} não tem saldo para realizar a tranferência, saldo: {1}, transferência: {2}\n", nome, saldo, quantia);
            }

        }
        protected void Informações()
        {
            Console.WriteLine("\nNome:{0}\nNúmero da conta:{1}\nSaldo:{2}\n",nome,numeroIdent,saldo);
        }
        protected void Sacar(float removido, float imposto)
        {
            if (saldo - (removido + (removido * imposto)) > 0)
            {
                removido -= removido * imposto;
                saldo -= removido;
                Console.WriteLine("{0} sacou {1}(valor com impostos), restando: {2}\n", nome, removido,saldo);
            }
            else
            {
                Console.WriteLine("{0} não tem saldo para realizar a operação de saque, saldo: {1}, saque: {2}\n", nome,saldo,removido);
            }

        }
    }
}
