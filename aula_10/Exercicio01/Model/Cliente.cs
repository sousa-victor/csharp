using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class Cliente
    {
        private string nome;
        private string genero;
        private string cpf;
        private string rg;
        private bool clienteVip;

        public Cliente(string nome, string genero, string cpf, string rg, bool clienteVip)
        {
            this.nome = nome;
            this.genero = genero;
            this.cpf = cpf;
            this.rg = rg;
            this.clienteVip = clienteVip;
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetGenero()
        {
            return genero;
        }
        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public string GetCpf()
        {
            return cpf;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetRg()
        {
            return rg;
        }
        public void SetRg(string rg)
        {
            this.rg = rg;
        }

        public bool GetClienteVip()
        {
            return clienteVip;
        }
        public void SetClienteVip(bool clienteVip)
        {
            this.clienteVip = clienteVip;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Gênero: " + this.genero);
            Console.WriteLine("CPF: " + this.cpf);
            Console.WriteLine("RG: " + this.rg);
            Console.WriteLine("Cliente Vip? " + (clienteVip ? "Sim" : "Não"));
        }
    }
}
