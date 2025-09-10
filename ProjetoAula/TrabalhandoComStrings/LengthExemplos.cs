namespace ProjetoAula.TrabalhandoComStrings
{
    public static class LengthExemplos
    {
        public static void Executar()
        {
            Console.Write("Digite uma frase: ");
            string teste = Console.ReadLine();
            Console.WriteLine(teste);
            Console.WriteLine($"Tamanho da nossa fase é: {teste.Length}");
        }
    }
}
