using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando objetos
            Bebida bebida1 = new Bebida("Suco de Polpa",5,7.5f,10);
            Bebida bebida2 = new Bebida("Vitamina", 6, 8.5f, 12);
            Bebida bebida3 = new Bebida("Drink", 8, 10.5f, 13);
            Aperitivo aperitivo1 = new Aperitivo("Iscas de peixe");
            Aperitivo aperitivo2 = new Aperitivo("Salame fatiado");
            
            // array
            ItemMenu[] Cardapio = new ItemMenu[5] { bebida1, bebida2, bebida3, aperitivo1, aperitivo2 };
            
            // teste
            Console.WriteLine("CARDÁPIO ACME's RESTAURANTE\n\n");
            foreach (ItemMenu item in Cardapio)
            {
                item.ImprimirNome();
                item.ImprimirPreço();
            }

            
            Console.ReadLine();
        }
    }
}
