using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public static void IncluirProduto()
        {
            Console.Clear();
            Console.Write("Quantos produtos deseja incluir? ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Clear();

            var produto = new List<Produto>();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Clear();
                Console.WriteLine($"Cadastre o Produto {i}");
                Console.WriteLine("-----------------------");
                Console.Write("Código do Produto: ");
                int codigoProduto = int.Parse(Console.ReadLine());
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                decimal precoProduto = decimal.Parse(Console.ReadLine());

                produto.Add(new Produto(codigoProduto, nomeProduto, precoProduto));

                EditarProduto(produto);

                Console.Clear();
                Console.WriteLine("Produto Cadastrado com Sucesso!");
                Thread.Sleep(2000);
            }

            Thread.Sleep(2000);

            Program.Menu(produto);
        }

        public static void EditarProduto(List<Produto> produto)
        {
            Console.Clear();

            Console.Write("Digite o código do produto a ser editado: ");
            int codigoProduto = int.Parse(Console.ReadLine());

            foreach (Produto prod in produto)
            {
                if (prod.Id == codigoProduto)
                {
                    Console.WriteLine("Dados do Produto");
                    Console.WriteLine("----------------");
                    Console.WriteLine($"Código do Produto: {prod.Id}");
                    Console.WriteLine($"Nome do Produto: {prod.Nome}");
                    Console.WriteLine($"Preço do Produto: {prod.Preco}");
                    Console.WriteLine("------------------");
                    Console.WriteLine();

                    Console.Write("Novo Nome: ");
                    string novoNome = Console.ReadLine();
                    Console.Write("Novo Preço: ");
                    decimal novoPreco = decimal.Parse(Console.ReadLine());

                    produto.Add(new Produto(novoNome, novoPreco));
                }
                else
                {
                    Console.WriteLine("Produto não localizado!");
                }
            }
        }
    }
}
