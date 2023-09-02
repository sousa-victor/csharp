using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class Terrestre : Transporte
    {
        private int rodas;
        private int velocidade;

        public Terrestre(int capacidade, int rodas, int velocidade) : base(capacidade) //Não é necessário informar capacidade novamente porque já pego
        {                                                                               //os detalhes herdados da superclasse
            this.rodas = rodas;
            this.velocidade = velocidade;
        }
        public int GetRodas()
        {
            return rodas;
        }
        public void SetRodas(int rodas)
        {
            this.rodas = rodas;
        }
        public int GetVelocidade()
        {
            return velocidade;
        }
        public void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public override void Visualizar() //polimorfismo de sobrescrita
        {
            base.Visualizar();
            Console.WriteLine($"Número de Rodas: {rodas}");
            Console.WriteLine($"Velocidade: {velocidade}");
        }
    }
}
