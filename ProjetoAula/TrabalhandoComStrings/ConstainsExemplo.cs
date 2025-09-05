namespace ProjetoAula.TrabalhandoComStrings
{
    public static class ConstainsExemplo
    {
        public static void Executar()
        {
            string nomeDoArquivo = "2025_09_04_backup.bak";

            Console.WriteLine($"Contem o nome:{nomeDoArquivo.Contains("Isabella")}");

            if (nomeDoArquivo.Contains("Meirelles"))
            {
                Console.WriteLine("Palavra encontrada!");
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }
        }
    }
}
