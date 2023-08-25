namespace Tabuada_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tabuada");
            int tabuada = Convert.ToInt32 (Console.ReadLine());
            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine($"{tabuada} x {contador} = {tabuada*contador}");
                contador++;
            }
        }
    }
}