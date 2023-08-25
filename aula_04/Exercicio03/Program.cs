namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inferior = 0, superior = 0, entradas=0;
            
            while(entradas >= 0)
            {
                Console.Write("Digite uma idade: ");
                entradas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (entradas < 21 && entradas >0)
                {
                    inferior++;
                }
                else if (entradas > 50)
                {
                    superior++;
                }
            }
            Console.Write("Total de pessoas menores de 21 anos: " + inferior);
            Console.Write("\nTotal de pessoas mairoes de 50 anos: " + superior);
        }
    }
}