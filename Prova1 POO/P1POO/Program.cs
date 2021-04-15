using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Cadastro do catálogo de produtos;
            //-Controle da movimentação(compra/ venda) dos produtos.
            bool ProgramaAtivo = true;
            int acao = 0;
            Cadastro programa = new Cadastro();
            // intancias para teste do professor
            Bairro BairroBob = new Bairro("Bairro Jardim das Oliveiras");
            Estado EstadoBob = new Estado("Distrito Federal", "DF");
            Cidade CidadeBob = new Cidade("Brasília", EstadoBob);
            Endereco EnderecoBob = new Endereco(23, "Rua das Classes", BairroBob, CidadeBob);
            programa.Clientes.Add(new PessoaFisica("Bob Nelson", EnderecoBob, "bobNelson@gmail.com", "111.222.333-99", 100, false));
            Bairro BairroTes = new Bairro("Bairro Operarios");
            Estado EstadoTes = new Estado("Goiás", "GO");
            Cidade CidadeTes = new Cidade("Rio Verde", EstadoTes);
            Endereco EnderecoTes = new Endereco(4, "Avenida Abstrata", BairroTes, CidadeTes);
            programa.Clientes.Add(new PessoaFisica("Testolfo Rocha", EnderecoTes, "testolfoRocha26@gmail.com", "444.555.666-11", 200, true));
            Bairro BairroBel = new Bairro("Bairro Monges Unidos");
            Estado EstadoBel = new Estado("Mato Grosso", "MG");
            Cidade CidadeBel = new Cidade("Belo Horizonte", EstadoBel);
            Endereco EnderecoBel = new Endereco(26, "Rua das Classes", BairroBel, CidadeBel);
            programa.Clientes.Add(new PessoaFisica("Belo Teste", EnderecoBel, "Testebelo@gmail.com", "999.888.777-72", 300, true));
            Bairro BairroLiv = new Bairro("Copacabana");
            Estado EstadoLiv = new Estado("Rio de Janeiro", "RJ");
            Cidade CidadeLiv = new Cidade("Rio de Janeiro", EstadoLiv);
            Endereco EnderecoLiv = new Endereco(45, "Vale das Heranças", BairroLiv, CidadeLiv);
            programa.Fornecedores.Add(new PessoaJuridica("Livros Associados", EnderecoLiv, "faleconosco@associados.com", "999.888.777-72", 300));
            Livro Dom = new Livro(100,programa.Fornecedores[0],19.99f,31.99f,70,"DomCasmurro",Genero.ficcão,"Machado de Assis", "Universal");
            Livro Uni = new Livro(150,programa.Fornecedores[0],10.99f,25.99f,50, "Unity: design e desenvolvimento de jogos",Genero.games, "William Pereira Alves","Universal");
            programa.LivrosLoja.Add(Dom);
            programa.LivrosLoja.Add(Uni);
            Caderno cem = new Caderno(170, programa.Fornecedores[0],10.99f,25.99f, 30, 100);
            programa.CadernosLoja.Add(cem);

            while (ProgramaAtivo)
            {
                Console.Clear();
                Console.WriteLine("LIVRARIA OBJETOLÂNDIA\nbem vindo!\n\n" +
                    "o que deseja fazer?\n\nescreva úm número e dê enter para determinada ação.\n\n" +
                    "1 - Relacionar clientes\n2 - Relacionar fornecedores\n" +
                    "3 - Adicionar cliente\n4 - Remover cliente\n5 - " +
                    "Adicionar fornecedor\n6 - Remover fornecedor\n7 - Adicionar uma nova série de livros\n8 - Venda / Compra de livros\n9 - Venda / Compra de Cadernos" +
                    "\n10 - Mostrar Livros\n11 - Mostrar Cadernos\n\n12 - Sair do Programa");
                acao = int.Parse(Console.ReadLine());
                switch (acao)
                {
                    case 1:
                        Console.Clear();
                        programa.RelacionarClientes();
                        continuar();
                        break;
                    case 2:
                        Console.Clear();
                        programa.RelacionarFornecedores();
                        continuar();
                        break;
                    case 3:
                        Console.Clear();
                        programa.AdicionarCliente();
                        continuar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Insira o ID do cliente que deseja remover");
                        int IdCliente = int.Parse(Console.ReadLine());
                        programa.RemoverCliente(IdCliente);
                        continuar();
                        break;
                    case 5:
                        Console.Clear();
                        programa.AdicionarFornecedor();
                        continuar();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Insira o ID do Fornecedor que deseja remover");
                        int IdFornecedor = int.Parse(Console.ReadLine());
                        programa.RemoverFornecedor(IdFornecedor);
                        continuar(); ;
                        break;
                    case 7:
                        Console.Clear();
                        programa.AdicionarSerieLivros();
                        continuar();
                        break;
                    case 8:
                        Console.Clear();
                        programa.VendaOuCompraLivros();
                        continuar();
                        break;
                    case 9:
                        Console.Clear();
                        programa.VendaOuCompraCadernos();
                        continuar();
                        break;
                    case 10:
                        Console.Clear();
                        programa.MostrarLivros();
                        continuar();
                        break;
                    case 11:
                        Console.Clear();
                        programa.MostrarCadernos();
                        continuar();
                        break;
                    case 12:
                        ProgramaAtivo = false;
                        break;
                }
            }
            void continuar()
            {
                Console.WriteLine("\n\n Clique enter para continuar");
                Console.ReadLine();
            }
        }
    }
}
