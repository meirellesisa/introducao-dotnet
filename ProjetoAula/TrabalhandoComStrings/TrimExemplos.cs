namespace ProjetoAula.TrabalhandoComStrings
{
    public static class TrimExemplos
    {
        public static void Executar()
        {
            string texto = " Olá, mundo! ";
            Console.WriteLine($"TRIM: {texto.Trim()}");

            string texto2 = "* *Isabella Meirelles**";
            Console.WriteLine($"TRIM: {texto2.Trim('*')}");

            Console.WriteLine($"TRIM START: {texto2.TrimStart('*')}");
            
            Console.WriteLine($"TRIM END: {texto2.TrimEnd('*')}");
        }
    }
}
