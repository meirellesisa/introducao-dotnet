namespace ProjetoAula.TrabalhandoComDatas
{
    public static class DateOnlyExemplos
    {
        public static void Executar()
        {
            var data = DateOnly.Parse("2025/01/01");
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("dd-MM-yyyy"));

            Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm:ss"));
        }
    }
}
