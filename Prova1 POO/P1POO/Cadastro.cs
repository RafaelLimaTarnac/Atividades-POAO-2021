using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1POO
{
    class Cadastro
    {

        public List<PessoaFisica> Clientes { get; private set; }
        public List<PessoaJuridica> Fornecedores { get; private set;}
        public List<Livro> LivrosLoja { get; private set; }
        public List<Caderno> CadernosLoja { get; private set; }

        public Cadastro()
        {
            Clientes = new List<PessoaFisica>();
            Fornecedores = new List<PessoaJuridica>();
            LivrosLoja = new List<Livro>();
            CadernosLoja = new List<Caderno>();

        }

        public void RelacionarClientes()
        {
            foreach (PessoaFisica elemento in Clientes)
            {
                if (elemento.Vip)
                {
                    Console.WriteLine($"Id- {elemento.ID}\nNome- " +
                    $"{elemento.Nome}\nEmail- {elemento.Email}\n" +
                    $"Cpf- {elemento.Cpf}\nBairro- {elemento.Endereco.Bairro.Nome}\nEstado- " +
                    $"{elemento.Endereco.Cidade.Estado.Nome}- {elemento.Endereco.Cidade.Estado.Sigla}\n" +
                    $"Cidade- {elemento.Endereco.Cidade.Nome}\nEndereço-Rua {elemento.Endereco.Rua}, Número-" +
                    $" {elemento.Endereco.Numero}\nÉ Vip\n\n");
                }
                else
                {
                    Console.WriteLine($"Id- {elemento.ID}\nNome- " +
                    $"{elemento.Nome}\nEmail- {elemento.Email}\n" +
                    $"Cpf- {elemento.Cpf}\nBairro- {elemento.Endereco.Bairro.Nome}\nEstado- " +
                    $"{elemento.Endereco.Cidade.Estado.Nome}- {elemento.Endereco.Cidade.Estado.Sigla}\n" +
                    $"Cidade- {elemento.Endereco.Cidade.Nome}\nEndereço-Rua {elemento.Endereco.Rua}, Número-" +
                    $" {elemento.Endereco.Numero}\nnão é Vip\n\n");
                }
            }
            //return "";
        }
        public void RelacionarFornecedores()
        {
            foreach (PessoaJuridica elemento in Fornecedores)
            {
                Console.WriteLine($"Id- {elemento.ID}\nNome- " +
                $"{elemento.Nome}\nEmail- {elemento.Email}\n" +
                $"Cnpj- {elemento.Cnpj}\nBairro- {elemento.Endereco.Bairro.Nome}\nEstado- " +
                $"{elemento.Endereco.Cidade.Estado.Nome}- {elemento.Endereco.Cidade.Estado.Sigla}\n" +
                $"Cidade- {elemento.Endereco.Cidade.Nome}\nEndereço-Rua {elemento.Endereco.Rua}, Número-" +
                $" {elemento.Endereco.Numero}\n\n");
            }
        }
        public void AdicionarCliente()
        {
            Console.WriteLine("\nInsira completo do cliente");
            string Nome = Console.ReadLine();
            Console.WriteLine($"\nInsira Email de {Nome}");
            string Email = Console.ReadLine();
            Console.WriteLine($"\nInsira o Cpf de {Nome}, desta forma = XXX-XXX-XXX.XX");
            string Cpf = Console.ReadLine();
            Console.WriteLine($"\nInsira o bairro de {Nome}");
            string BairroNome = Console.ReadLine();
            Bairro bairro = new Bairro(BairroNome);
            Console.WriteLine($"\nInsira o Estado(em extenso) de {Nome}");
            string EstadoNome = Console.ReadLine();
            Console.WriteLine($"\nInsira Sigla do estado de {Nome}");
            string EstadoSigla = Console.ReadLine();
            Estado estado = new Estado(EstadoNome,EstadoSigla);
            Console.WriteLine($"\nInsira a cidade de {Nome}");
            string CidadeNome = Console.ReadLine();
            Cidade cidade = new Cidade(CidadeNome,estado);
            Console.WriteLine($"\nInsira o número do endereço de {Nome}");
            long EnderecoNumero = long.Parse(Console.ReadLine());
            Console.WriteLine($"\nInsira a rua do endereço de {Nome}");
            string EnderecoRua = Console.ReadLine();
            Endereco endereco = new Endereco(EnderecoNumero,EnderecoRua,bairro,cidade);
            Console.WriteLine($"{Nome} é Vip na livraria? (sim ou não)");
            bool vip = false;
            bool respondeu = false;
            while(respondeu == false)
            {
                string eVip = Console.ReadLine();
                if (eVip == "sim")
                {
                    vip = true;
                    respondeu = true;
                }
                else if (eVip == "não")
                {
                    vip = false;
                    respondeu = true;
                }
                else
                    Console.WriteLine("Por favor, digite corretamente!");
            }
            
            long id = 1;
            if(Clientes.Count > 0)
                id = Clientes[Clientes.Count - 1].ID + 1;

            Clientes.Add(new PessoaFisica(Nome,endereco,Email,Cpf,id,vip));

            if (vip == true)
            {
                Console.WriteLine($"\n\nNovo cliente adicionado!\nId- {id}\nNome- {Nome}\nEmail- {Email}\n" +
                $"Cpf- {Cpf}\nBairro- {BairroNome}\nEstado- {EstadoNome}- {EstadoSigla}\n" +
                $"Cidade- {CidadeNome}\nEndereço-Rua {EnderecoRua}, Número- {EnderecoNumero}\n{Nome} É Vip!");
            }

            else
            {
                Console.WriteLine($"\n\nNovo cliente adicionado!\nId- {id}\nNome- {Nome}\nEmail- {Email}\n" +
                $"Cpf- {Cpf}\nBairro- {BairroNome}\nEstado- {EstadoNome}- {EstadoSigla}\n" +
                $"Cidade- {CidadeNome}\nEndereço-Rua {EnderecoRua}, Número- {EnderecoNumero}\n{Nome} não é Vip!");
            }

        }
        public void RemoverCliente(long id)
        {
            foreach(PessoaFisica elemento in Clientes)
            {
                if (elemento.ID == id)
                {
                    Clientes.Remove(elemento);
                    return;
                }
            }
        }
        public void AdicionarFornecedor()
        {
            Console.WriteLine("\nInsira completo do fornecedor");
            string Nome = Console.ReadLine();
            Console.WriteLine($"\nInsira Email de {Nome}");
            string Email = Console.ReadLine();
            Console.WriteLine($"\nInsira o Cnpj de {Nome},");
            string Cnpj = Console.ReadLine();
            Console.WriteLine($"\nInsira o bairro de {Nome}");
            string BairroNome = Console.ReadLine();
            Bairro bairro = new Bairro(BairroNome);
            Console.WriteLine($"\nInsira o Estado(em extenso) de {Nome}");
            string EstadoNome = Console.ReadLine();
            Console.WriteLine($"\nInsira Sigla do estado de {Nome}");
            string EstadoSigla = Console.ReadLine();
            Estado estado = new Estado(EstadoNome, EstadoSigla);
            Console.WriteLine($"\nInsira a cidade de {Nome}");
            string CidadeNome = Console.ReadLine();
            Cidade cidade = new Cidade(CidadeNome, estado);
            Console.WriteLine($"\nInsira o número do endereço de {Nome}");
            long EnderecoNumero = long.Parse(Console.ReadLine());
            Console.WriteLine($"\nInsira a rua do endereço de {Nome}");
            string EnderecoRua = Console.ReadLine();
            Endereco endereco = new Endereco(EnderecoNumero, EnderecoRua, bairro, cidade);

            long id = 1;
            if (Fornecedores.Count > 0)
                id = Fornecedores[Fornecedores.Count - 1].ID + 1;

            Fornecedores.Add(new PessoaJuridica(Nome, endereco, Email, Cnpj, id));

            Console.WriteLine($"\n\nNovo fornecedor adicionado!\nId- {id}\nNome- {Nome}\nEmail- {Email}\n" +
            $"Cnpj- {Cnpj}\nBairro- {BairroNome}\nEstado- {EstadoNome}- {EstadoSigla}\n" +
            $"Cidade- {CidadeNome}\nEndereço-Rua {EnderecoRua}, Número- {EnderecoNumero}\n");

        }
        public void RemoverFornecedor(long id)
        {
            foreach (PessoaJuridica elemento in Fornecedores)
            {
                if (elemento.ID == id)
                {
                    Fornecedores.Remove(elemento);
                    return;
                }
            }
        }
        public void AdicionarSerieLivros()
        {
            Console.WriteLine("Adicione o ID do fornecedor");
            int id = int.Parse(Console.ReadLine());
            Genero genero = Genero.ficcão;
            PessoaJuridica fornecedor = Fornecedores[0];
            foreach (PessoaJuridica elemento in Fornecedores)
            {
                if (elemento.ID == id)
                {
                    fornecedor = elemento;
                }
            }
            Console.WriteLine("Adicione o Preço de compra");
            float precoCompra = float.Parse(Console.ReadLine());
            Console.WriteLine("Adicione o Preço de venda");
            float precoVenda = float.Parse(Console.ReadLine());
            Console.WriteLine("Adicione a quantidade comprada no estoque");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o título da obra");
            string titulo = Console.ReadLine();
            Console.WriteLine("insira o gênero e tecle enter\n1 - Ficção\n2 - Informática" +
                "\n3 - Games\n4 - Negócios\n");
            bool escolheu = false;
            while (!escolheu)
            {
                int numGenero = int.Parse(Console.ReadLine());
                switch (numGenero)
                {
                    case 1:
                        escolheu = true;
                        break;
                    case 2:
                        genero = Genero.informática;
                        escolheu = true;
                        break;
                    case 3:
                        genero = Genero.games;
                        escolheu = true;
                        break;
                    case 4:
                        genero = Genero.negócios;
                        escolheu = true;
                        break;
                    default:
                        Console.WriteLine("Por favor, digite novamente");
                        break;
                }

            }
            Console.WriteLine("Insira o autor da obra");
            string autor = Console.ReadLine();
            Console.WriteLine("Insira a editora da Obra");
            string editora = Console.ReadLine();

            LivrosLoja.Add(new Livro(1,fornecedor,precoCompra,precoVenda,quantidade,titulo,
                genero,autor,editora));

            Console.WriteLine("Novo livro adicionado!\n");
            LivrosLoja[LivrosLoja.Count - 1].MostrarDescrição();
        }
        public void VendaOuCompraLivros()
        {
            bool vender = false;
            Console.WriteLine("escolha a opção e tecle enter:\n1 - venda\n2 - compra");
            int opcao = 3;
            while (opcao < 1 || opcao > 2)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        vender = true;
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("digita novamnt");
                        break;
                }
            }
            Console.WriteLine("Insira a quantidade");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Id do livro");
            long id = long.Parse(Console.ReadLine());
            // compra
            if (vender == false)
                quantidade *= -1;

            foreach (Livro elemento in LivrosLoja)
            {
                if (elemento.ID == id)
                {
                    elemento.DiminuirEstoque(quantidade);
                    Console.WriteLine($"\n\nEstoque Restante - {elemento.QuantidadeEstoque}");
                }
            }
        }
        public void VendaOuCompraCadernos()
        {
            bool vender = false;
            Console.WriteLine("escolha a opção e tecle enter:\n1 - venda\n2 - compra");
            int opcao = 3;
            while (opcao < 1 || opcao > 2)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        vender = true;
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Por favor, digite novamente");
                        break;
                }
            }
            Console.WriteLine("Insira a quantidade");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Id do cadernos");
            long id = long.Parse(Console.ReadLine());
            // compra
            if (vender == false)
                quantidade *= -1;

            foreach (Caderno elemento in CadernosLoja)
            {
                if (elemento.ID == id)
                {
                    elemento.DiminuirEstoque(quantidade);
                    Console.WriteLine($"\n\nEstoque Restante - {elemento.QuantidadeEstoque}");
                }
            }
        }
        public void MostrarLivros()
        {
            foreach (Livro elemento in LivrosLoja)
            {
                elemento.MostrarDescrição();
            }
        }
        public void MostrarCadernos()
        {
            foreach (Caderno elemento in CadernosLoja)
            {
                elemento.MostrarDescrição();
            }
        }
    }
}
