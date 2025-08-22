namespace ProjetoAula.EstruturaDeDados
{
    public class DicionarioExemplo
    {
        public void Executar()
        {
            Console.WriteLine("Introduzindo Dicionários");

            // Criando um dicionário
            var dicionario = new Dictionary<int, string>();

            // Adicionando dados ao dicionário
            dicionario.Add(1, "Isabella");
            dicionario.Add(2, "Jader");
            dicionario[50] = "Curso";

            // Acessando dados do dicionário
            Console.WriteLine(dicionario[1]);
            Console.WriteLine(dicionario[50]);

            Console.WriteLine("---------");

            foreach (var item in dicionario)
            {
                Console.WriteLine($"A chave do meu dado é {item.Key} e o valor dessa chave é {item.Value}");
            };

            Console.WriteLine("---------");

            // Exemplo do uso de interpolação de strings
            //Console.WriteLine($"Calculando 1 + 2 = {1 + 2}");

            var novoDicionario = new Dictionary<string, int>()
            {
                {"Quantidade de imagens", 10},
                {"Quantidade de vídeos", 5},
                {"Quantidade de áudios", 3},
                {"Quantidade de documentos", 8}
            };

            foreach (var item in novoDicionario)
            {
                Console.WriteLine($" {item.Key} = {item.Value}");
            };

            //Removendo dados de um dicionario é passado como parâmetro
            //a chave do dado que se deseja remover
            novoDicionario.Remove("Quantidade de vídeos");

            Console.WriteLine("---------");


            foreach (var item in novoDicionario)
            {
                Console.WriteLine($" {item.Key} = {item.Value}");
            };

            Console.WriteLine("--------- FIM");
        }
    }
}
