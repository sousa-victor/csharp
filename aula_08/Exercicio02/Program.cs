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
        }
    }
}