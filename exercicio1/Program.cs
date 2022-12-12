using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha umas das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Listar Qtd de Produtos Total no Estoque");
                Console.WriteLine("4 - Sair");
                int opcao = 0;
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        criarProduto(produtos);
                        break;

                    case 2:
                        listarProduto(produtos);
                        break;

                    case 3:
                        calcularQtdProdutos(produtos);
                        break;

                    case 4:
                        return;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção não existe!");
                        Thread.Sleep(1300);
                       break;
                }
                
                
            }
        }

        private static void criarProduto(List<Produto> produtos)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do Produto");
            string nomeProduto = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("Digite a quantidade de " + nomeProduto);
            int qtd = 0;
            int.TryParse(Console.ReadLine(), out qtd);
            Produto produto = new Produto(0, nomeProduto, qtd);
            produtos.Add(produto);
            Console.Clear();
            Console.WriteLine($"Produto [ {produto.Nome} ], cadastrado com sucesso!");
            Thread.Sleep(1500);    
        }
        private static void listarProduto(List<Produto> produtos)
        {
            Console.Clear();
            if(produtos.Count != 0)
            {
                Console.WriteLine("===========================");
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine("\nID........: " + produto.Id);
                    Console.WriteLine("Nome......: " + produto.Nome);
                    Console.WriteLine("Quantidade: " + produto.qtd+"\n");
                }
                Console.WriteLine("===========================");
                Console.WriteLine("\nAperte ENTER para voltar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não há produtos cadastrados");
                Thread.Sleep(1000);
            }

        }

        private static void calcularQtdProdutos(List<Produto> produtos)
        {
            Console.Clear();
            int qtdTotal = 0;
            foreach(Produto produto in produtos)
            {
                qtdTotal += produto.qtd;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("A quantidade de produtos total no estoque é: "+qtdTotal);
            Console.WriteLine("=========================================================");
            Console.WriteLine("\nAperte ENTER para voltar");
            Console.ReadLine();
        }
    }
}
