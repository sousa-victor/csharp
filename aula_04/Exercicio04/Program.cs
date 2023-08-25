namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, genero, stack;
            int devsBackend = 0, mulheresFrontend=0, homensMobile40mais=0, fullstackNb30Menos=0, participantes=0, somaIdades=0;
            float media;
            string continuar = "S";

            while (continuar.Equals("S")) {
                Console.Write("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                somaIdades += idade;
                participantes++;

                Console.Write("Identidade de Gênero: ");
                genero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Pessoa Desenvolvedora: ");
                stack = Convert.ToInt32(Console.ReadLine());

                if (stack == 1)
                {
                    devsBackend++;
                } 
                else if ((genero == 1 || genero == 4) && stack == 2)
                {
                    mulheresFrontend++;
                }

                else if ((genero == 2 || genero == 5) && stack == 3 && idade > 40)
                {
                    homensMobile40mais++;
                }

                else if (genero == 3 && stack == 4 && idade < 30)
                {
                    fullstackNb30Menos++;
                }

                Console.Write("\n\nDeseja continuar (S/N): ");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
                Console.WriteLine("\n");
            }

            Console.Write("Total de pessoas desenvolvedoras Backend: " + devsBackend);
            Console.Write("\nTotal de mulheres Cis e Trans desenvolvedoras Frontend: " + mulheresFrontend);
            Console.Write("\nTotal de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: " + homensMobile40mais);
            Console.Write("\nTotal de Pessoas Não Binárias desenvolvedoras FullStack menores de 30 anos: " +  fullstackNb30Menos);
            Console.Write("\nO número total de pessoas que responderam à pesquisa: " + participantes);
            media = somaIdades / (float)participantes;
            Console.Write($"\nA média de idade das pessoas que responderam à pesquisa: {media:F2}");
        }
    }
}