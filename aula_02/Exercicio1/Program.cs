namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Salário:");
            float salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o Abono:");
            float abono = Convert.ToSingle(Console.ReadLine());
            float NovoSalario = salario + abono;
            Console.WriteLine($"O novo salário é de: R$ {NovoSalario:F2}");

        }
    }
}