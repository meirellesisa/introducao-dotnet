namespace ProjetoAula.EstruturasDeControle
{
    public class ForeachExemplo
    {
        public void Executar()
        {
            var lista = new List<string>() { "Isabella", "Cuso", "CSharp" };

            var listaDeInteiros = new List<int>() { 1, 2, 3, 4, 5 };

            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }

            foreach (int item in listaDeInteiros)
            {
                Console.WriteLine(item);
            }

            foreach(var letra in "Isabella Meirelles")
            {
                Console.WriteLine(letra);
            }
        }
    }
}
