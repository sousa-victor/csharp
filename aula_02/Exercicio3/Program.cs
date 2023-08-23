namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;
            Console.WriteLine("Salário Bruto: ");
            salarioBruto = float.Parse(Console.ReadLine());
            Console.WriteLine("Adicional Noturno: ");
            adicionalNoturno = float.Parse(Console.ReadLine());
            Console.WriteLine("Horas Extras: ");
            horasExtras = float.Parse(Console.ReadLine());
            Console.WriteLine("Descontos: ");
            descontos = float.Parse(Console.ReadLine());
            salarioLiquido = salarioBruto + adicionalNoturno + (5*horasExtras) - descontos;
            Console.WriteLine($"Salário Líquido: {salarioLiquido:F2}");
        }
    }
}