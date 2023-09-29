using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace SaqueDeposito
{
    class ContaBancaria
    {
        public int Numero { get; private set; }// numero pode ser acessado(get) mas não alterado (set)
        public string Titular { get; set; }
        public double Saldo { get; private set; }// mesmo caso do numero

        public ContaBancaria(int numero, string titular)// construtor com dois argumentos, vc poderia inicializar saldo com zero porem ja vem com zero por padrao
        {
            Numero = numero;   //cria conta bancaria sem saldo inicial 
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)// esta aproveitando os dados do construtor acima
        {
            Saldo = saldo;   //cria conta com saldo inicial 
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;// descontando a taxa de saque
        }

        public override string ToString()
        {
            return "Conta" 
                  + Numero  
                  + "; Titular: " 
                  + Titular 
                  + "; Saldo: $" 
                  + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }



}
