using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaJuridica : Cliente
    {
        private string ramo;

        public PessoaJuridica(string nome, string genero, string cpf, string rg, bool clienteVip, string ramo) : base(nome, genero, cpf, rg, clienteVip)
        {
            this.ramo = ramo;
        }

        public string getRamo()
        {
            return ramo;
        }
        public void setRamo(string ramo)
        {
            this.ramo = ramo;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Ramo: " + ramo);
        }

    }
}
