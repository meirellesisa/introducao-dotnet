namespace ProjetoAula.ClassesEOutrosTipos.Polimorfismo
{
    public class Vendedor : Funcionario
    {
        public decimal TaxaComissao {  get; set; }
        public Vendedor(string nome, decimal salarioBase, decimal taxaComissao) : base(nome, salarioBase)
        {
            TaxaComissao = taxaComissao;
        }

        public override decimal CalcularBonus()
        {
           return SalarioBase * TaxaComissao;
        }

        public static double SomarSalario(double a, double b)
        {
            return a + b;
        }

        public int SomarSalario(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
