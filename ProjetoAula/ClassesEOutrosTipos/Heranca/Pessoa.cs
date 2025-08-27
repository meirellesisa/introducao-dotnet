namespace ProjetoAula.ClassesEOutrosTipos.Heranca
{
    public class Pessoa // SUPER CLASSE
    {
        //Atributos 
        public int Id {  get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirNoConsole()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Cep: {Cep}");
        }
    }
}
