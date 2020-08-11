using System;

using VendasConsole.DAL;
using VendasConsole.View;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            
            Dados.Inicializar();
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.WriteLine(" *** PROJETO DE VENDAS CONSOLE *** \n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Cadastrar vendedor");
                Console.WriteLine("4 - Listar vendedores");
                Console.WriteLine("5 - Cadastrar produto");
                Console.WriteLine("6 - Listar produtos");
                Console.WriteLine("7 - Cadastrar venda");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                      //  Console.WriteLine("  -- Cadastro de Cliente--  \n");
                       // Console.WriteLine("Digite o nome do cliente");
                       // string nome = Console.ReadLine();
                       // Console.WriteLine("Digite o CPF do cliente");
                       // string cpf = Console.ReadLine();

                         CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                       CadastrarVendedor.Renderizar();
                        break;
                    case 4:
                       ListarVendedores.Renderizar();
                        break;
                    case 5:
                       CadastrarProduto.Renderizar();
                        break;
                    case 6:
                       ListarProdutos.Renderizar();
                        break;
                    case 7:
                       CadastrarVenda.Renderizar();
                        break;
                    case 0:
                       Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
