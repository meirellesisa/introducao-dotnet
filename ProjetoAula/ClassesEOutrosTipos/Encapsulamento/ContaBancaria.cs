namespace ProjetoAula.ClassesEOutrosTipos.Encapsulamento
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(string titular, decimal saldoInicial = 0)
        {
            if (string.IsNullOrWhiteSpace(titular))
            {
                throw new ArgumentNullException("Titular obrigatorio");
            }

            if (saldoInicial < 0)
            {
                throw new ArgumentException("Saldo inicial não pode ser negativo");
            }

            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor deve ser positivo");
            }

            //Saldo = Saldo + valor;
            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (valor < 0)
            {
                return false;
            }

            if (valor > Saldo)
            {
                return false;
            }

            //Saldo = Saldo - valor;
            Saldo -= valor;
            return true;
        }
    }
}
