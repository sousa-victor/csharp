namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            float salario, reajuste;
            int cargo;

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu cargo");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 7) / 100;
                    break;

                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;

                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }

            Console.WriteLine($"O reajuste do salário de {nome} é de: {reajuste}");
            Console.WriteLine($"O novo salário é de: {salario + reajuste}");

        }
    }
}