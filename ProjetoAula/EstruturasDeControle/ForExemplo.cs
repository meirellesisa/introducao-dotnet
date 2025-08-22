namespace ProjetoAula.EstruturasDeControle
{
    public class ForExemplo
    {
        public void Executar()
        {
            var lista = new List<string>() { "Isabella", "Cuso", "CSharp" };

            for (var i = 0; i < lista.Count(); i++) // i = i + 1
            {
                Console.WriteLine(lista[i]);
            }


        }
    }
}
