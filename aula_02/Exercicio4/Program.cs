namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1,n2,n3,n4, diferenca;
            Console.WriteLine("numero1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("numero2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("numero3: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("numero4: ");
            n4 = float.Parse(Console.ReadLine());
            diferenca = (n1 * n2) - (n3 * n4);
            Console.WriteLine($"Diferença: {diferenca:F1}");
        }
    }
}