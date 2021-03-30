using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_3
{
    class Livro : Produto
    {
        public string Autor { get; set; }

        public Livro(string Autor, string Titulo, double Preço)
        {
            this.Autor = Autor;
            this.Titulo = Titulo;
            this.Preço = Preço;
        }
        public void InformarDescrição()
        {
            string Prefixo = "Autor:";
            InformarDescrição(Prefixo,Autor);
        }
        public void InformarPreço()
        {
            base.InformarPreço();
        }
    }
}
