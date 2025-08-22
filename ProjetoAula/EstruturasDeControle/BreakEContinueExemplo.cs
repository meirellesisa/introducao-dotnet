namespace ProjetoAula.EstruturasDeControle
{
    public class BreakEContinueExemplo
    {
        public void Executar()
        {
            var i = 0;

            while(i < 5)
            {
                Console.WriteLine($"var i = {i}");// ou $"var i = {i}"
                i++;

                if(i == 2)
                {
                    Console.WriteLine("Variável i é igual a 2");
                    break;
                }
            }

            while (i < 5)
            {
                if(1 < 2)
                {
                    Console.WriteLine("Continue");
                    // continue; // Pula para a próxima iteração do loop, sem executar o restante do código abaixo
                    break;
                }

                Console.WriteLine($"var i = {i}");// ou $"var i = {i}"
                i++;

                if (i == 2)
                {
                    Console.WriteLine("Variável i é igual a 2");
                    break;
                }
            }
        }
    }
}
