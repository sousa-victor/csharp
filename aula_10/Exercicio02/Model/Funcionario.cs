using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Funcionario
    {
        private int matricula;
        private string setor;
        private string cargo;
        private bool ensinoSuperior;
        private bool terceirizado;

        public Funcionario(int matricula, string setor, string cargo, bool ensinoSuperior, bool terceirizado)
        {
            this.matricula = matricula;
            this.setor = setor;
            this.cargo = cargo;
            this.ensinoSuperior = ensinoSuperior;
            this.terceirizado = terceirizado;
        }

        public int getMatricula()
        {
            return matricula;
        }
        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public string getSetor()
        {
            return setor;
        }
        public void setSetor(string setor)
        {
            this.setor = setor;
        }
        public string getCargo()
        {
            return cargo;
        }
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }
        public bool getEnsinoSuperior()
        {
            return ensinoSuperior;
        }
        public void setEnsinoSuperior(bool ensinoSuperior)
        {
            this.ensinoSuperior = ensinoSuperior;
        }
        public bool getTerceirizado()
        {
            return terceirizado;
        }
        public void setTerceirizado(bool terceirizado)
        {
            this.terceirizado = terceirizado;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("Matrícula: " + this.matricula);
            Console.WriteLine("Setor: " + this.setor);
            Console.WriteLine("Cargo: " + this.cargo);
            Console.WriteLine("Tem ensino superior? " + (ensinoSuperior ? "Sim" : "Não"));
            Console.WriteLine("É terceirizado? " + (terceirizado ? "Sim" : "Não"));
        }
    }
}
