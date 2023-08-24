namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            int codigo;
            Console.WriteLine("Digite o 1º número");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            numero2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Operação: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine($"{numero1:F1} + {numero2:F1} = {(numero1+numero2):F1}");
                    break;

                case 2:
                    Console.WriteLine($"{numero1:F1} - {numero2:F1} = {(numero1 - numero2):F1}");
                    break;

                case 3:
                    Console.WriteLine($"{numero1:F1} * {numero2:F1} = {(numero1 * numero2):F1}");
                    break;

                case 4:
                    Console.WriteLine($"{numero1:F1} / {numero2:F1} = {(numero1 / numero2):F1}");
                    break;

                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }
        }
    }
}