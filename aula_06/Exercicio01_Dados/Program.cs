using System.Runtime.CompilerServices;

namespace Exercicio01_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livros = new Stack<string>();
            int menu = 0;

            do
            {
                Console.WriteLine("\n*********************************************************\n");
                Console.WriteLine("         1 - Adicionar Livro na pilha");
                Console.WriteLine("         2 - Listar todos os Livros");
                Console.WriteLine("         3 - Retirar Livro da pilha");
                Console.WriteLine("         0 - Sair");
                Console.WriteLine("\n*********************************************************");

                Console.WriteLine("Digite uma opção: ");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        break;

                    case 1:
                        Console.Write("\nDigite o nome: \n");
                        livros.Push(Console.ReadLine());
                        Console.WriteLine("Pilha:\n");
                        foreach (string nome in livros)
                        {
                            Console.WriteLine(nome);
                        }
                        Console.WriteLine("\nLivro adicionado!");
                        break;

                    case 2:
                        Console.WriteLine("\nLista de Livros na Pilha::\n");
                        foreach (string nome in livros)
                        {
                            Console.WriteLine(nome);
                        }
                        break;

                    case 3:
                        if (livros.Count() != 0)
                        {
                            livros.Pop();
                            Console.WriteLine("Fila:\n");
                            foreach (string nome in livros)
                            {
                                Console.WriteLine(nome);
                            }
                            Console.WriteLine("\nUm Livro foi retirado da pilha!");
                        }
                        else
                        {
                            Console.WriteLine("A Pilha está vazia!");
                        }
                        break;

                    default:
                        Console.WriteLine("Insira uma opção válida");
                        break;
                }

            }
            while (menu != 0);
            Console.WriteLine("Programa Finalizado!");
        }
    }
}