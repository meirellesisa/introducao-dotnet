namespace ProjetoAula.EstruturaDeDados
{
    public class PilhaExemplo
    {
        public void Executar()
        {
            Console.WriteLine("Introduzindo Pilha");

            //Criando uma pilha
            var pilha = new Stack<string>();

            //Inserindo dados na pilha
            pilha.Push("Isabella"); // primeiro item a entrar na pilha
            pilha.Push("Meirelles"); // segundo item a entrar na pilha
            pilha.Push("Jeferson"); // terceiro item a entrar na pilha
            pilha.Push("Silva"); // quarto item a entrar na pilha

            // Acessando dado 
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------");

            // Obtendo o primeiro dado a sair da pilha
            // e removendo
            var dado = pilha.Pop();
            var dado1 = pilha.Pop();
            Console.WriteLine(dado);
            Console.WriteLine(dado1);

            Console.WriteLine("------------");
            // Obtendo o primeiro dado sem tira-lo da pilha
            var dado2 = pilha.Peek();
            var dado3 = pilha.Peek();
            Console.WriteLine(dado2);
            Console.WriteLine(dado3);

            Console.WriteLine("--------- FIM");
        }
    }
}
