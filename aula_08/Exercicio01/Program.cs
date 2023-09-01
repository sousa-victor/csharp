using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Rafael", "masculino", 1234, 4321, false);
            c1.Visualizar();

            Cliente c2 = new Cliente("Jacque", "feminino", 9876, 6789, true);
            c2.Visualizar();
        }
    }
}