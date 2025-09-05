namespace ProjetoAula.TrabalhandoComStrings
{
    // Serve para transformar uma cadeia de caracteres em letras minúsculas
    public static class ToLowerExemplo 
    {
        public static void Executar()
        {
            Console.Write("Digite uma informação: ");
            var valor = Console.ReadLine();
            Console.WriteLine(valor.ToLower());
        }
    }
}
