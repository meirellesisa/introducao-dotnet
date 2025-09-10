namespace ProjetoAula.TrabalhandoComDatas
{
    public static class AdicionandoHoraMinutoSegundoExemplos
    {
        public static void Executar()
        {
            DateTime dataAtual = DateTime.Now;

            Console.WriteLine($"Data Atual: {dataAtual}");
            Console.WriteLine($"Apenas horario atual: {dataAtual.ToString("HH:mm:ss")}");
            Console.WriteLine(dataAtual.AddHours(1).ToString("HH:mm:ss"));
            Console.WriteLine(dataAtual.AddMinutes(15).ToString("HH:mm"));
            Console.WriteLine(dataAtual.AddSeconds(10).ToString("HH:mm:ss"));
        }
    }
}
