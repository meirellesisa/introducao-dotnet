namespace ProjetoAula.EstruturaDeDados
{
    public class ListaGenericaExemplo
    {
        public void Executar()
        {
            Console.WriteLine("Introduzindo Lista Genérica");

            // Criando uma lista
            var lista = new List<string>(7) { "Isabella", "Jader", "Marco" };

            //Adicioando dados
            lista.Add("Maria");
            lista.Add("João");

            //lista.Add(1); -> exemplo de erro ao adicionar um tipo diferente
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------");

            // Acessando dados através do índice
            var dado = lista[0];

            Console.WriteLine(dado);
            Console.WriteLine("---------");

            //Removendo dado de uma lista
            lista.RemoveAt(2);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");

            var qtdItens = lista.Count; // Obtém a quantidade de itens na lista
            Console.WriteLine($"Quantidade de itens na lista: {qtdItens}");

            Console.WriteLine("---------");

            lista.Capacity = 10; // Aumenta a capacidade da lista para 10 elementos
            lista.Add("Novo Item"); // Adiciona um novo item
            lista.Add("Outro Item"); // Adiciona outro item
            lista.Add("Mais um Item"); // Adiciona mais um item
            lista.Add("Novo Item"); // Adiciona um novo item
            lista.Add("Outro Item"); // Adiciona outro item
            lista.Add("Mais um Item"); // Adiciona mais um item
            lista.Add("Novo Item"); // Adiciona um novo item
            lista.Add("Outro Item"); // Adiciona outro item
            lista.Add("Mais um Item"); // Adiciona mais um item

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------- FIM");

            // Mesmo a capacidade sendo de 10, caso você queira adicioanar
            // mais itens, a lista irá aumentar a sua capacidade automaticamente.
        }
    }
}
