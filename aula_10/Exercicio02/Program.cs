using Exercicio02.Model;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario f1 = new Funcionario(123, "rh", "psicologo", true, false);
            f1.Visualizar();
            Funcionario f2 = new Funcionario(321, "limpeza e manutencao", "faxineiro", false, true);
            f2.Visualizar();
            
            Gerente g1 = new Gerente(412, "Vendas", "Gerente geral", true, false, 10);
            g1.Visualizar();
            Gerente g2 = new Gerente(593, "Alimenticio", "Gerente de qualidade", true, false, 5);
            g2.Visualizar();
            
            Vendedor v1 = new Vendedor(4657, "RH", "Psicólogo", true, true, 35.7f);
            v1.Visualizar();

            Vendedor v2 = new Vendedor(1205, "Automotivo", "Vendedor", true, false, 7.6666);
            v2.Visualizar();
        }
    }
}