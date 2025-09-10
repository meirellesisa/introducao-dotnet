namespace ProjetoAula.TrabalhandoComDatas
{
    public static class RecuperandoDiaDaSemanaExemplos
    {
        public static void Executar()
        {
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfWeek);
        }
    }
}
