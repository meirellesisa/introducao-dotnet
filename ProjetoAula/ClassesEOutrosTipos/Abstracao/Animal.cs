namespace ProjetoAula.ClassesEOutrosTipos.Abstracao
{
   // Não pode ser instânciada 
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string ObterInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome do animal: {Nome}");
            Console.WriteLine($"Informações do animal: {ObterInformacoes()}");
        }
    }
}
