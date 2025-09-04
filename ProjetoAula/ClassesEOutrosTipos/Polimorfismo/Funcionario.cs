namespace ProjetoAula.ClassesEOutrosTipos.Polimorfismo
{
    public abstract class Funcionario
    {
        //Atributos 
        public string Nome { get; set; }
        public decimal SalarioBase {  get; set; }

        public Funcionario(string nome, decimal salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        //Comportamentos ou Metodos ou Funcoes
        public abstract decimal CalcularBonus();

    }
}
