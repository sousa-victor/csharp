namespace Exercicio03_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> entrada = new HashSet<int>();
            for (int i = 0; i< 10;  i++)
            {
                entrada.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int elemento in entrada)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}