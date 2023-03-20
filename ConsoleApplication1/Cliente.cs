using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLL
{
    public class Cliente
    {
        public string Codigo { get; private set; }
        public string Nome{ get; private set; }
        public string Saldo{ get; private set; }
        public List<Movimentacso> Movimentacoes { get; set; }

        public Cliente()
        {
            Movimentacoes = new List<Movimentacao>();
        }
        public Cliente(string Codigo, string nome) : this()
        {
            Nome = nome;
            Codigo = codigo; 
        }
        public void RealizarSaque()
        {
            if (Saldo > valor)
            {
                decimal valorMenosTaxa = DescontarTaxa(valor);
                Saldo = saldo - valor;
                AdicionarMovimentacao("SAQUE", valorMenosTaxa);
                Console.WriteLine($"Saque realizado com sucesso. Saldo: "{ Saldo};
            }
            else
                Console.WriteLine("Valor insuficiente");
        }
    }

}
