using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double PreçoTotal = 0;
            
            Livro Livro1 = new Livro("Alexandre Dumas","O Conde de Monte Cristo", 150);
            Livro livro2 = new Livro("Malba Tahan", "O Homem que Calculava", 25.99);
            Livro livro3 = new Livro("Franz Kafka", "A Metamorfose", 11.90);
            JogoDigital Jogo1 = new JogoDigital("PS2","Time Splitters",40.50);
            JogoDigital Jogo2 = new JogoDigital("PC", "Vampire Masquerade", 34.99);
            JogoDigital Jogo3 = new JogoDigital("Nintendo 65", "Extreme-G", 60);

            Livro[] Livros;
            Livros = new Livro[3] { Livro1, livro2, livro3 };
            JogoDigital[] Jogos;
            Jogos = new JogoDigital[3] { Jogo1, Jogo2, Jogo3 };

            foreach (Livro Livro in Livros)
            {
                Livro.InformarDescrição();
                Livro.InformarPreço();
                PreçoTotal += Livro.Preço;
            }
            foreach (JogoDigital Jogo in Jogos)
            {
                Jogo.InformarDescrição();
                Jogo.InformarPreço();
                PreçoTotal += Jogo.Preço;
            }
            Console.WriteLine("Preço Total: R${0}",PreçoTotal);
            
            Console.ReadLine();
        }
    }
}
