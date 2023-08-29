using System.Reflection.PortableExecutable;

namespace Exercicio01_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe a " + (i+1) + "ª cor.");
                cores.Add(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Listar todas as cores:\n");
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }
            cores.Sort();

            Console.WriteLine("\nOrdenar as cores:\n");
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }
        }
    }
}