namespace ProjetoAula.TrabalhandoComDatas
{
    public static class TimeOnlyExemplo
    {
        public static void Executar()
        {
            var horario = TimeOnly.Parse("23:10:10");
            Console.WriteLine(horario);

            var outraHora = new TimeOnly(12, 23, 25, 0);
            Console.WriteLine(outraHora);

            Console.WriteLine(horario.ToString("HH:mm:ss"));
            Console.WriteLine(outraHora.ToString("HH:mm:ss"));
        }
    }
}
