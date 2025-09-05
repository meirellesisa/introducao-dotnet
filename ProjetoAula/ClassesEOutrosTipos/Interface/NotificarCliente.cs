namespace ProjetoAula.ClassesEOutrosTipos.Interface
{
    public class NotificarCliente : INotificacao
    {
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }

        public void Noticar()
        {
            Console.WriteLine("Notificar cliente");
        }
    }
}
