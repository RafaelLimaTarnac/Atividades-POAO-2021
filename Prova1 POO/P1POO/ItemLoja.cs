using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    abstract class ItemLoja
    {
        protected ItemLoja(long iD, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque)
        {
            ID = iD;
            Fornecedor = fornecedor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public long ID { get; protected set; }
        public PessoaJuridica Fornecedor { get; protected set; }
        public float PrecoCompra { get; protected set; }
        public float PrecoVenda { get; protected set; }
        public int QuantidadeEstoque { get; protected set; }
    }
}
