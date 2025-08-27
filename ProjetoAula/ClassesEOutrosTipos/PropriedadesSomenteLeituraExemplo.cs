namespace ProjetoAula.ClassesEOutrosTipos
{
    public class PropriedadesSomenteLeituraExemplo
    {
    }

    public class Produto
    {
        //Atributor 
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; } // dessa forma eu declaro que nosso atributo será apenas de leitura

        //public readonly int Saldo; // dessa forma eu declaro que nosso atributo será apenas de leitura
    
        public Produto() // Construtor padrão que não recebe valores
        {
           Estoque = 10;

        }

        //Construtor personalizado que recebe valores
        public Produto(string nome, string descricao, int estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }
    }

}
