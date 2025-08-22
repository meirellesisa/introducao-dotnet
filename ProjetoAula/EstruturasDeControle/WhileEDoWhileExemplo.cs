namespace ProjetoAula.EstruturasDeControle
{
    public class WhileEDoWhileExemplo
    {
        public void Executar()
        {
            var i = 3;
            while (i < 5)
            {
                Console.WriteLine($"Valor de i: {i}");
                i++; // Incrementa o valor de i em 1 a cada iteração
                
            }


            Console.WriteLine("-------------------------");

            var j = 3;
            do
            {
                Console.WriteLine($"Valor de j: {j}");
                j++; // Incrementa o valor de j em 1 a cada iteração
            } while (j < 5);

        }   
    }
}
