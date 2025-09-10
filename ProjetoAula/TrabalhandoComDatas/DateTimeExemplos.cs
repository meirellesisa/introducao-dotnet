namespace ProjetoAula.TrabalhandoComDatas
{
    public static class DateTimeExemplos
    {
        public static void Executar()
        {

            var data = new DateTime(2025, 09, 09, 20, 20, 23);
            Console.WriteLine($"Data: {data}");

            var data2 = new DateTime(2025, 09, 09);
            Console.WriteLine($"Data2: {data2}");

            var data3 = DateTime.Parse("2025/09/21 20:20:23");
            Console.WriteLine($"Data3: {data3}");

            DateTime hoje = DateTime.Today;
            Console.WriteLine($"Hoje: {hoje}");

            var dataAtual = DateTime.Now;
            Console.WriteLine($"Data e hora atual: {dataAtual}");

            DateTime nascimento = new DateTime(1990, 5, 23);
            Console.WriteLine($"Data de nascimento: {nascimento}");

            Console.WriteLine("Data formatada para o padrão americano: " + nascimento.ToString("yyyy-MM-dd"));
            Console.WriteLine("Data + hora e minuto: " + data3.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine("Data + hora e minuto: " + data3.ToString("dd-MM-yyyy HH:mm"));
           

            var dateTimeOffset = new DateTimeOffset(2025, 09, 09, 20, 20, 23, TimeSpan.Zero);
            Console.WriteLine("TimeStamp Zerado: " +dateTimeOffset);

            var dateTimeOffset2 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dateTimeOffset2);

            Console.WriteLine(dateTimeOffset.LocalDateTime);
            Console.WriteLine(dateTimeOffset.UtcDateTime);
        }
    }
}
