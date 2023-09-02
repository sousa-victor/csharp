using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaFisica : Cliente
    {
        private int idade;
        public PessoaFisica(string nome, string genero, string cpf, string rg, bool clienteVip, int idade) : base(nome, genero, cpf, rg, clienteVip)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Idade: " + this.idade);
        }
    }
}
