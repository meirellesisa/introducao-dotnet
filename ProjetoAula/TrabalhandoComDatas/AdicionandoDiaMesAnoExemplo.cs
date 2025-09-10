namespace ProjetoAula.TrabalhandoComDatas
{
    public static class AdicionandoDiaMesAnoExemplo
    {
        public static void Executar()
        {
            DateTime hoje = DateTime.Today;
            Console.WriteLine($"Hoje: {hoje}");

            Console.WriteLine(hoje.AddDays(10).ToString("dd-MM-yyyy"));
            Console.WriteLine(hoje.AddMonths(2));
            Console.WriteLine(hoje.AddYears(-1));
        }
    }
}
