﻿using System.Runtime.CompilerServices;

namespace Exercicio01_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            int menu = 0;

            do
            {
                Console.WriteLine("\n*********************************************************\n");
                Console.WriteLine("         1 - Adicionar Cliente na Fila");
                Console.WriteLine("         2 - Listar todos os Clientes na fila");
                Console.WriteLine("         3 - Retirar Clientes da Fila");
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
                        clientes.Enqueue(Console.ReadLine());
                        Console.WriteLine("Fila:\n");
                        foreach (string nome in clientes)
                        {
                            Console.WriteLine(nome);
                        }
                        Console.WriteLine("\nCliente adicionado!");
                        break;

                    case 2:
                        Console.WriteLine("\nLista de Clientes na Fila:\n");
                        foreach (string nome in clientes)
                        {
                            Console.WriteLine(nome);
                        }
                        break;

                    case 3:
                        if (clientes.Count() != 0)
                        {
                            clientes.Dequeue();
                            Console.WriteLine("Fila:\n");
                            foreach (string nome in clientes)
                            {
                                Console.WriteLine(nome);
                            }
                            Console.WriteLine("\nO Cliente foi chamado!");
                        }
                        else
                        {
                            Console.WriteLine("A Fila está vazia!");
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