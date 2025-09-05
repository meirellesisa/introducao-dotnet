namespace ProjetoAula.TrabalhandoComStrings
{
    public static class RangeExemplo
    {
        public static void Executar()
        {
            string nomeDoArquivo = "2025_09_04_backup.bak";
            string ano = nomeDoArquivo[..4];
            string extensao = nomeDoArquivo[^3..];
            var nome = nomeDoArquivo[11..^4];
            var apenasNome = nomeDoArquivo[..^4];
            Console.WriteLine(ano);
            Console.WriteLine(extensao);
            Console.WriteLine(nome);
            Console.WriteLine(apenasNome);
        }
    }
}
