namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Código do produto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtde = Convert.ToInt32(Console.ReadLine());
            int unitario = 0;
            string produto = "";
            switch (codigo)
            {
                case 1:
                    unitario = 10;
                    produto = "Cachorro quente";
                    break;
                case 2:
                    unitario = 15;
                    produto = "X-Salada";
                    break;
                case 3:
                    unitario = 18;
                    produto = "X-Bacon";
                    break;
                case 4:
                    unitario = 12;
                    produto = "Bauru";
                    break;
                case 5:
                    unitario = 8;
                    produto = "Refrigerante";
                    break;
                case 6:
                    unitario = 13;
                    produto = "Suco de laranja";
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
            Console.WriteLine("Produto: " + produto);
            Console.WriteLine($"Valor total: R$ {(unitario * qtde):F2}");

        }
    }
}