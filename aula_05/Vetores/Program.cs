﻿namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = {1,2,3,4,5,6,7,8,9,10};
            int[] vetor02 = new int[5];

            for(int indice =0; indice < 10; indice++)
            {
                Console.WriteLine($"Vetor01[{indice}] = {vetor01[indice]}");
            }

            for (int indice = 0; indice < 5; indice++)
            {
                Console.Write($"Vetor02[{indice}] = ");
                vetor02[indice] = Convert.ToInt32( Console.ReadLine() );
            }

            for (int indice = 0; indice < 5; indice++)
            {
                Console.Write($"Vetor02[{indice}] = {vetor02[indice]}");
            }
        }
    }
}