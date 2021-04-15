using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    interface iItem_relatório // interface
    {
        void MostrarDescrição();
        string MostrarQuantidadeEstoque();
        void DiminuirEstoque(int Qnt);
    }
}
