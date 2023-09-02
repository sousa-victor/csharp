using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Gerente : Funcionario
    {
        public int subordinados;
        public Gerente(int matricula, string setor, string cargo, bool ensinoSuperior, bool terceirizado, int subordinados) : base(matricula, setor, cargo, ensinoSuperior, terceirizado)
        {
            this.subordinados = subordinados;
        }

        public int GetSubordinados()
        {
            return subordinados;
        }
        public void SetSubordinados(int subordinados)
        {
            this.subordinados = subordinados;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Subordinados: " + subordinados);
        }
    }
}
