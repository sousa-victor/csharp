namespace PlanoSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a idade");
            int idade = Convert.ToUInt16(Console.ReadLine()), valor;

            if (idade <= 10)
            {
                valor = 100;
            }
            else if (idade > 10 && idade <= 29)
            {
                valor = 200;
            }
            else if (idade > 29 && idade <= 45)
            {
                valor = 300;
            }
            else if (idade > 45 && idade <= 59)
            {
                valor = 500;
            }
            else if (idade > 59 && idade <= 65)
            {
                valor = 600;
            }
            else
            {
                valor = 1000;
            }

            Console.WriteLine($"A mensalidade do plano é de R$ {valor:F2}");
        }
    }
}