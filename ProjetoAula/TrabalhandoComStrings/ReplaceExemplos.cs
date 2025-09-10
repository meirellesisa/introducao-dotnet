namespace ProjetoAula.TrabalhandoComStrings
{
    public static class ReplaceExemplos
    {
        public static void Executar()
        {
            string frase = "Eu gosto de Java";
            Console.WriteLine(frase);
            Console.WriteLine(frase.Replace("Java", "C#"));
            Console.WriteLine(frase.Replace(" ", ","));

            string frase2 = "Eu gosto de maça";
            var novaFrase = frase2.Replace("maça", "morango");
            Console.WriteLine(novaFrase);
            Console.WriteLine(novaFrase.Replace("a", "o"));
        }
    }
}
