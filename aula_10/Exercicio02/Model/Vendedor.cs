using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Vendedor : Funcionario
    {
        double comissao;
        public Vendedor(int matricula, string setor, string cargo, bool ensinoSuperior, bool terceirizado, double comissao) : base(matricula, setor, cargo, ensinoSuperior, terceirizado)
        {
            this.comissao = comissao;
        }

        public double GetComissao()
        {
            return comissao;
        }
        public void SetComissao(double comissao)
        {
            this.comissao = comissao;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Comissão: " + comissao.ToString("F2") + "%");
        }
    }
}
