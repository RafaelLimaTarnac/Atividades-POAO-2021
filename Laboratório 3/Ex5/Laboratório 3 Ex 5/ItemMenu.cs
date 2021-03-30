using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_5
{
    class ItemMenu
    {
        public string Nome { get; protected set; }
        public double[] Preco { get; protected set; }

        public void ImprimirNome()
        {
            Console.Write(Nome);
        }
        public void ImprimirPreço()
        {
            
            // se for bebida, saem 3 preços como resultado
            for (int i = 0;i <= Preco.Length - 1 ;i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write(" R$" + Preco[i]);
                        break;
                    case 1:
                        Console.Write("| " + Nome +" Médio(a) R$"+Preco[i]);
                        break;
                    case 2:
                        Console.Write("| " + Nome +" Grande R$"+ Preco[i]);
                        break;
                }
            }
            
            // pula linha
            Console.WriteLine("\n");
        }
    }
}
