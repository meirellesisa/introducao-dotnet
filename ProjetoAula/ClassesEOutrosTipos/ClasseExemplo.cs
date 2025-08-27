//namespace Financeiro;

namespace ProjetoAula.ClassesEOutrosTipos
{
    public class ClasseExemplo
    {
    }
}

namespace Cadastro
{
    public class Produto
    {
        // Atributos ou propriedades
        private int Id;

        public string Descricao { get; set; }

        // Métodos OU Funcoes 
        public void ImprimirNoConsole()
        {
            Console.WriteLine($"Id: {ObterId()}, Descrição: {Descricao}");
        }

        public void AtribuirId(int id)// usado para atribuir valor a um atributor privado
        {
            Id = id;
        }

        public int ObterId()
        {
            return Id;
        }

    }

    public static class Calculos // Exemplo de classes estáticas
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }

    }

}

