using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string conta = "1+ (5 +3 - (8-5)*4 - ((3+7)*(3-1)))";
            Console.WriteLine(VerificarExpressao(conta));
            Console.ReadLine();
        }
        static bool VerificarExpressao(string conta)
        {
            Stack<char> elementos = new Stack<char>();
            int comparador = 0;

            for (int i = 0; i < conta.Length; i++)
            {
                elementos.Push(conta[i]);
            }

            foreach (char v in elementos)
            {
                if (v == ' ')
                {

                }
                else
                {
                    if (v == '(')
                    {
                        comparador++;
                    }
                    else if(v == ')' && comparador > 0)
                    {
                        comparador--;
                    }
                }
            }
            if (comparador != 0)
            {
                return false;
            }

            return true;
        }
    }
}
