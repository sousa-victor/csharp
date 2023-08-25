namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, continua = "S";
            int idade, esporte;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o esporte. (1-Fut/2-Volei/3-Basquete/4-Outros");
                    esporte = Convert.ToInt32(Console.ReadLine());
                }
                while (esporte < 1 || esporte > 4);

                Console.WriteLine("Deseja Continuar? (S/N)");
                continua = Console.ReadLine().ToUpper();
            }
            while (continua.Equals("S"));
        }
    }
}