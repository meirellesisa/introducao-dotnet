namespace ProjetoAula.ClassesEOutrosTipos.Polimorfismo
{
    public class Gerente : Funcionario
    {
        public decimal Multiplicador { get; set; }
        public Gerente(string nome, decimal salarioBase, decimal multiplicador) : base(nome, salarioBase)
        {
            Multiplicador = multiplicador;
        }

        public override decimal CalcularBonus()
        {
            return SalarioBase * Multiplicador;
        }
    }
}
