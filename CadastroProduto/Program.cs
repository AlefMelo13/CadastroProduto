using System.Security.Cryptography.X509Certificates;

namespace CadastroProduto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu(List<Produto> produro)
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Incluir Produto");
            Console.WriteLine("2 - Editar Produto");
            Console.WriteLine("3 - Consultar Produto");
            Console.WriteLine("4 - Excluir Produto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------");
            Console.Write("Resposta: ");

            int resposta = int.Parse(Console.ReadLine());

            switch(resposta)
            {
                case 1: Produto.IncluirProduto(); break;
                case 2: Produto.EditarProduto(produro); ; break;
                case 3: ConsultarProduto(); break;
                case 4: ExcluirProduto(); break;
                case 0: Console.Clear();
                    Console.WriteLine("Aplicação Finalizada!");
                    Environment.Exit(0); break;
                default: Console.WriteLine("Aplicação Finalizada!"); break;
            }
        }

        public static void ExcluirProduto()
        {
            Console.WriteLine();
        }

        public static void ConsultarProduto()
        {
            Console.WriteLine();
        }
    }
}