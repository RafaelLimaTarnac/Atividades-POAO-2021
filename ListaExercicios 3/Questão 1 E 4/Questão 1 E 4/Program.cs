using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1_E_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Uma atividade livre, conscientemente tomada como “não-séria” e exterior" +
                " à vida habitual, mas ao mesmo tempo capaz de absorver o jogador de maneira " +
                "intensa e total. É uma atividade desligada de todo e qualquer interesse material, " +
                "com a qual não se pode obter qualquer lucro, praticada dentro de limites espaciais" +
                " e temporais próprios, segundo um certa ordem e certas regras.Promove a formação " +
                "de grupos sociais com tendência a rodearem - se de segredo e a sublinharem sua " +
                "diferença em relação ao resto do mundo por meio de disfarces ou outros meios " +
                "semelhantes.";

            Console.WriteLine("\nnúmero total de palavras: " + NumeroPalavrasDiferentes(texto));

            Console.ReadLine();
        }
        static int NumeroPalavrasDiferentes(string texto)
        {
            string[] palavrasTexto = texto.Split(' ', ',', ';', '.', '-', '“', '"', '”');
            Dictionary<string, bool> palavras = new Dictionary<string, bool>();
            int numPalavras = 0;
            bool haPalavra = true;

            foreach (string v in palavrasTexto)
            {
                if (v.Length > 0)
                {
                    if (!palavras.TryGetValue(v, out haPalavra))
                    {
                        palavras[v] = haPalavra;
                        numPalavras++;
                        Console.WriteLine(v + " " + numPalavras);
                    }
                }
            }

            return numPalavras;
        }
    }
}
