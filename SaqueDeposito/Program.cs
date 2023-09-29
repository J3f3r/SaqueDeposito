using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SaqueDeposito
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;// instanciando conta do tipo ContaBancaria para uso global
            
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);//deposito inicial corresponde saldo 
                conta = new ContaBancaria(numero, titular, depositoInicial);//caso tenha um deposito inicial saldo recebera este deposito
            }
            else
            {
                conta = new ContaBancaria(numero, titular);//jogara zero para o saldo
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);// vai imprimir os dados da conta

            Console.WriteLine();
            Console.Write("Entre com o valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// poderia ser a palavra deposito mas como se trata da quantia fica mais claro
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// sem o tipo porque ja foi declarada acima
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);
        }
    }
}
