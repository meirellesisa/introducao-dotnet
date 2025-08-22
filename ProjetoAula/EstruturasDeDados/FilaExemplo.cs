namespace ProjetoAula.EstruturaDeDados
{
    public class FilaExemplo
    {
        public void Executar()
        {
            Console.WriteLine("Introduzindo Fila/Queue");
            // Criando uma fila
            var fila = new Queue<string>();

            //Inserindo dados na fila   
            fila.Enqueue("Isabella"); // primeiro item a entrar na fila
            fila.Enqueue("Jader"); // segundo item a entrar na fila
            fila.Enqueue("Marco"); // terceito item a entrar na fila

            // Acessando dados da fila
            foreach(var item in fila)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");

            // Acessando dados através do índice não é possível em uma fila
            // pois a fila é uma estrutura FIFO (First In, First Out)
            // para apenas visualizar o primeiro dado a sair da fila , usamos o método Peek()
            var dado1 = fila.Peek();
            var dado2 = fila.Peek();

            Console.WriteLine(dado1);
            Console.WriteLine(dado2);

            Console.WriteLine("--------------------------");
            // Para visualizar e remover/desempilhar o dados da fila, usamos o método Dequeue()
            var dado3 = fila.Dequeue();
            var dado4 = fila.Dequeue();
            Console.WriteLine(dado3);
            Console.WriteLine(dado4);

            Console.WriteLine("--------- FIM");
        }
    }
}
