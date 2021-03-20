using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_2
{
    class Program // classe teste
    {
        static void Main(string[] args)
        {
            Corrente u1 = new Corrente("Bob Nelson", 123456);
            Poupança u2 = new Poupança("Testolfo Rocha", 717171);
            Corrente u3 = new Corrente("Lisa Leite", 654321);
            Console.WriteLine("Contas:");
            ResultadoContas();

            u1.Depositar(5000);
            u3.Depositar(2000);
            u2.Depositar(1500);
            u1.Transferir(u2,600);
            u3.Sacar(250);
            u3.Transferir(u2, 400);
            u2.Transferir(u1,1000);
            u1.Sacar(900);
            u1.Transferir(u3,1500);
            u2.Transferir(u3, 1200);
            u1.Sacar(2000);
            u3.Depositar(100);
            u2.Transferir(u1, 700);

            Console.WriteLine("Contas após operações:");
            ResultadoContas();

            Console.ReadLine();

            
            
            void ResultadoContas()
            {
                u1.VerificarConta();
                u2.VerificarConta();
                u3.VerificarConta();
            }
        }
    }
}
