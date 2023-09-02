using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Rafael", "masculino", "1234", "4321", false);
            c1.Visualizar();

            Cliente c2 = new Cliente("Jacque", "feminino", "9876", "6789", true);
            c2.Visualizar();
            
            PessoaFisica pf1 = new PessoaFisica("Daniel", "Masculino", "4567", "7654", false, 24);
            pf1.Visualizar();

            PessoaFisica pf2 = new PessoaFisica("Victor", "Masculino", "1199", "15107", true, 26);
            pf2.Visualizar();
            

            PessoaJuridica pj1 = new PessoaJuridica("Tonhão peças", "masculino", "32154", "9867", false, "Automotivo");
            pj1.Visualizar();

            PessoaJuridica pj2 = new PessoaJuridica("Marie Madeleine", "feminino", "666", "999", false, "moda");
            pj2.Visualizar();

        }
    }
}