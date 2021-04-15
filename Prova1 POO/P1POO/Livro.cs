using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Livro : ItemLoja , iItem_relatório
    {
        public string Titulo { get; private set; }
        public Genero Genero { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }

        public Livro(long iD, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque, 
            string titulo, Genero genero, string autor, string editora) : base(iD, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            ID = iD;
            Fornecedor = fornecedor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
            Titulo = titulo;
            Genero = genero;
            Autor = autor;
            Editora = editora;
        }

        public void MostrarDescrição()
        {
            Console.WriteLine($"ID - {ID}\nTítulo - {Titulo}\nGênero - {Genero}\nAutor - {Autor}" +
                $"\nFornecedor - {Fornecedor.Nome}\nEditora - {Editora}\n" +
                $"{MostrarQuantidadeEstoque()}\n\n");
        }
        public string MostrarQuantidadeEstoque()
        {
            return $"Quantidade em estoque - {QuantidadeEstoque}";
        }
        public void DiminuirEstoque(int Qnt)
        {
            QuantidadeEstoque -= Qnt;
            if (QuantidadeEstoque <= 0)
            {
                QuantidadeEstoque = 0;
            }
        }
    }
    enum Genero
    {
        ficcão = 1,
        informática,
        games,
        negócios
    }
}
