namespace ProjetoAula.TrabalhandoComStrings
{
    // Serve para transformar uma cadeia de caracteres em letras MAIUSCULAS
    public static class ToUpperExemplo
    {
        public static void Executar()
        {
            Console.Write("Digite uma informação: ");
            var valor = Console.ReadLine();
            Console.WriteLine(valor.ToUpper());
        }
    }
}
