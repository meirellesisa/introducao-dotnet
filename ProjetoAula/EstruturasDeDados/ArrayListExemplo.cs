using System.Collections;

namespace ProjetoAula.EstruturaDeDados
{
    public class ArrayListExemplo
    {
        public void Executar()
        {
            Console.WriteLine("Introduzindo ArrayList");
            //criando ArrayList
            var arrayList = new ArrayList();

            //Adicioando dados 
            arrayList.Add(1); // indice 0
            arrayList.Add("Isabella Meirelles"); // indice 2
            arrayList.Add(true); // indice 3
            arrayList.Add(2);
            arrayList.Add("João Marco");
            arrayList.Add(false);

            // Imprimindo no console -> acessando dados 
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------");

            // Removendo dados de um ArrayList
            arrayList.RemoveAt(3);
            arrayList.RemoveAt(4);

            // para cada item do meu arrayList/Lista
            foreach (var item in arrayList)
            {
                // faça alguma coisa 
                Console.WriteLine(item);
            }

            Console.WriteLine("---------");

            Console.WriteLine("Acessando através do índice:" + arrayList[0]);
            Console.WriteLine("Acessando através do índice:" + arrayList[1]);

            // Limpando arrayList 
            arrayList = new ArrayList();

            arrayList.Clear();

            // para cada item do meu arrayList/Lista
            foreach (var item in arrayList)
            {
                // faça alguma coisa 
                Console.WriteLine(item);
            }

            Console.WriteLine("--------- FIM");
        }
    }
}
