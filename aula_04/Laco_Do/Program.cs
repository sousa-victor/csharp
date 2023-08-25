namespace Laco_Do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, contador = 1;
            do
            {
                Console.WriteLine("Digite um número inteiro");
                numero = Convert.ToInt32(Console.ReadLine());

                resultado = numero * 5;

                Console.WriteLine($"O resultado da multiplicação é {resultado}");
                
            }
            while (contador <= 2);
        }
    }
}