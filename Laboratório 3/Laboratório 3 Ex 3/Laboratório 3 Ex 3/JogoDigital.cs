using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3_Ex_3
{
    class JogoDigital : Produto
    {
        public string Console { get; set; }

        public JogoDigital(string Console, string Titulo, double Preço)
        {
            this.Console = Console;
            this.Titulo = Titulo;
            this.Preço = Preço;
        }
        public void InformarDescrição()
        {
            string Prefixo = "Console:";
            InformarDescrição(Prefixo, Console);
        }
        public void InformarPreço()
        {
            base.InformarPreço();
        }
    }
}
