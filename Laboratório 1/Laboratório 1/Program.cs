using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando 1 novo usuário
            Console.WriteLine("Digite respectivamente: Seu nome, sua idade, sua altura(com ponto no lugar da vírgula) e seu peso");
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            float peso = float.Parse(Console.ReadLine());
            //Botando todos os 4 usuários em array
            var usuario1 = new Usuario("Bob Nelson",37,1.70,78);
            var usuario2 = new Usuario("Testolfo Rocha", 43, 1.65, 60);
            var usuario3 = new Usuario("Lisa Leite", 22, 1.72, 92);
            var usuario4 = new Usuario(nome,idade,altura,peso);
            Usuario[] Usuarios;
            Usuarios = new Usuario[4] {usuario1,usuario2,usuario3,usuario4};
            // Resultado:
            Console.WriteLine("USUÁRIOS: \n");
            foreach (Usuario membroAcademia in Usuarios)
            {
                double imc = membroAcademia.imc;
                Console.WriteLine("NOME:{0}\nIDADE:{1}\nALTURA:{2}\nPESO:{3}\nIMC:{4}",membroAcademia.nome,membroAcademia.idade,membroAcademia.altura,membroAcademia.peso,membroAcademia.imc);
                if (imc < 25)
                    Console.WriteLine(membroAcademia.nome+ " Está com peso normal\n\n");
                else if (imc > 24.9 && imc < 30)
                    Console.WriteLine(membroAcademia.nome + " Está com sobrepeso\n\n");
                else if (imc > 29.9 && imc < 35)
                    Console.WriteLine(membroAcademia.nome + " Está com obesidade grau 1\n\n");
                else if (imc > 34.9 && imc < 40)
                    Console.WriteLine(membroAcademia.nome + " Está com obesidade grau 2\n\n");
                else
                    Console.WriteLine(membroAcademia.nome + " Está com obesidade grau 3 ou mórbida\n\n");
            }
            Console.ReadLine();
        }
    }
}
