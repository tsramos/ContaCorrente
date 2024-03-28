using System;

namespace ContaCorrente
{
    public class Conta
    {
        private double _taxaJuros;

        public double TaxaJuros
        {
            get
            {
                return _taxaJuros;
            }

            set
            {
                _taxaJuros = value;
            }
        }

        public void SetTaxaJuros(double valor)
        {
            _taxaJuros = valor;
        }

        public double GetTaxaJuros(){
            return _taxaJuros;
        }

        public int NumeroConta {get; private set;}
        public string Nome {get; set;}
        public double Saldo {get; private set;}

        public Conta(int numeroConta , string nome)
        {   
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
            ImprimeDados();
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - (valor + 5.00);
            ImprimeDados();
        }

        private void ImprimeDados()
        {
            Console.WriteLine($"Numero: {NumeroConta}\nTitular: {Nome}\n Saldo: {Saldo}");            
        }
    }
}