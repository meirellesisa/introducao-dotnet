namespace ProjetoAula.TrabalhandoComDatas
{
    public static class SubtraindoDatasExemplo
    {
        public static void Executar()
        {
            DateTime inicio = new DateTime(2025, 9, 7);
            DateTime fim = DateTime.Today;

            var diferenca = fim - inicio;


            Console.WriteLine($"Dias entre as datas: {diferenca.Days}");
            Console.WriteLine($"Dias entre as datas: {diferenca.TotalDays}");
            Console.WriteLine($"Dias entre as datas: {diferenca.TotalHours}");
            Console.WriteLine($"Dias entre as datas: {diferenca.TotalMinutes}");

            var diff = fim.Subtract(inicio);
            Console.WriteLine($"Dias entre as datas usando substract: {diferenca.TotalDays}");
            Console.WriteLine($"Dias entre as datas usando substract: {diferenca.TotalHours}");
        }
    }
}
