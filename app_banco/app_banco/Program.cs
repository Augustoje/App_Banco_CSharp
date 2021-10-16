using System;

namespace app_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Augusto Jesus", "000.000.000-00", "Desenvolvedor");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("###  Conta Corrente Criada  ###");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R${0}, obrigado por criar sua conta!", conta.getSaldo());

            // //Efetuar deposito pelo Console
            double valorDeposito;

            Console.WriteLine("Digite o valor do deposito: ");
            valorDeposito = Convert.ToInt32(Console.ReadLine());
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            double valorSaque;
            Console.WriteLine("digite o valor do Saque: ");
            valorSaque = Convert.ToInt32(Console.ReadLine());
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            Cliente clienteSimone = new Cliente("Simone Gomes", "000.000.000-00", "Administradora");

            ContaCorrente contaSimone = new ContaCorrente(clienteSimone, 01, 0002);

            double valorPix = 100;
            conta.Pix(valorPix, contaSimone);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaSimone.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);


            Console.WriteLine("Conta Poupanca Criada");
            Console.WriteLine("titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agencia: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());
        }
    }
}