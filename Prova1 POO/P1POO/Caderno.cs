using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Caderno : ItemLoja , iItem_relatório
    {
        public int QuantidadeFolhas { get; private set; }

        public Caderno(long iD, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque, int quantidadeFolhas) : base(iD, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            ID = iD;
            Fornecedor = fornecedor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
            QuantidadeFolhas = quantidadeFolhas;
        }

        public void MostrarDescrição()
        {
            Console.WriteLine($"ID - {ID}\nQuantidade Folhas - {QuantidadeFolhas}\nPreço Venda - {PrecoVenda}\nPreço Compra {PrecoCompra}" +
            $"\nFornecedor - {Fornecedor.Nome}\n{MostrarQuantidadeEstoque()}\n\n");
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
}
