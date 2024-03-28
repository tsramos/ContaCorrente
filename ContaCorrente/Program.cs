using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa o titular da conta.");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o numero da conta com até quatro digitos.");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja realizar um depósito inicial ? \n 1) Sim \n 2) Não");
            int resposta = int.Parse(Console.ReadLine());
            Conta c1;

            if (resposta == 1)
            {
                Console.WriteLine("Inform o valor do deposito inicial:");
                double saldoInicial = double.Parse(Console.ReadLine());
                c1 = new Conta(numeroConta, nome, saldoInicial);
                
            }
            else
            {
                c1 = new Conta(numeroConta, nome);      
            }

            Console.Clear();

            Console.WriteLine("Informe o valor do deposito");
            double valor = double.Parse(Console.ReadLine());
            c1.Deposito(valor);

            Console.WriteLine("Informe o valor do saque");
            valor = double.Parse(Console.ReadLine());
            c1.Saque(valor);

        }
    }
}
