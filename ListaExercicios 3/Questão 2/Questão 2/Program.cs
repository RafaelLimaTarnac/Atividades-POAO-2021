using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
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

            Dictionary<string, int> palavras = ContagemDePalavras(texto);

            foreach (var v in palavras)
            {
                Console.WriteLine($"Palavra: '{v.Key}'\nQuantidade: '{v.Value}'\n");
            }

            Console.ReadLine();
        }
        static Dictionary<string, int> ContagemDePalavras(string texto)
        {
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
            string[] palavrasTexto = texto.Split(' ', ',', ';', '.', '-', '“', '"', '”');

            foreach (string v in palavrasTexto)
            {
                if (v.Length > 0)
                {
                    int quantidadePalavras;
                    if (dicionario.TryGetValue(v, out quantidadePalavras))
                    {
                        dicionario[v] = quantidadePalavras + 1;
                    }
                    else
                    {
                        quantidadePalavras = 1;
                        dicionario[v] = quantidadePalavras;
                    }
                }
            }

            return dicionario;
        }
    }
}
