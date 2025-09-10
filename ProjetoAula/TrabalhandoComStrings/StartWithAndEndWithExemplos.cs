namespace ProjetoAula.TrabalhandoComStrings
{
    public static class StartWithAndEndWithExemplos
    {
        public static void Executar()
        {
            string nome = "Isabella Meirelles";
            Console.WriteLine($"INICIO: {nome.StartsWith("Isabella")}");

            Console.WriteLine($"FIM: {nome.EndsWith("Meirelles")}");

            Console.WriteLine($"FIM: {nome.EndsWith("Curso")}");
        }
    }
}
