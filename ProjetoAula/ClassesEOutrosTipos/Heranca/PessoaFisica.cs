namespace ProjetoAula.ClassesEOutrosTipos.Heranca
{
    public class PessoaFisica : Pessoa // SUB CLASSE  
    {
        public string Cpf { get; set; }

        public PessoaFisica()
        {

        }
        public PessoaFisica(
            int id, 
            string endereco, 
            string cidade, 
            string cep, 
            string cpf)
        {
           Id = id;
           Endereco = endereco;
           Cidade = cidade;
           Cep = cep;
           Cpf = cpf;
        }

        public void ImprimirCpf()
        {
            Console.WriteLine($"CPF: {Cpf}");
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }
}
