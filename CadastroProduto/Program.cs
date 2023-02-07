namespace CadastroProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
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

            int resposta = int.Parse(Console.ReadLine());

            switch(resposta)
            {
                case 1: IncluirProduto(); break;
                case 2: EditarProduto(); break;
                case 3: ConsultarProduto(); break;
                case 4: ExcluirProduto(); break;
                case 0: Console.Clear();
                    Console.WriteLine("Aplicação Finalizada!");
                    Environment.Exit(0); break;
                default: Console.WriteLine("Aplicação Finalizada!"); break;
            }
        }

        static void IncluirProduto()
        {
            Console.Clear();
            Console.Write("Código do Produto: ");
            int codigoProduto = int.Parse(Console.ReadLine());
            Console.Write("Nome do Produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            decimal precoProduto = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Produto Cadastrado com Sucesso!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Código do Produto: {codigoProduto}");
            Console.WriteLine($"Nome do Produto: {nomeProduto}");
            Console.WriteLine($"Preço do Produto: {precoProduto}");
            Thread.Sleep(2000);

            Menu();
        }

        static void EditarProduto()
        {
            Console.Clear();
            Console.Write("Código do Produto: ");

        }

        static void ExcluirProduto()
        {
            Console.WriteLine();
        }

        static void ConsultarProduto()
        {
            Console.WriteLine();
        }
    }
}