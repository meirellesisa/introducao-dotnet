namespace ProjetoAula.ClassesEOutrosTipos.Interface
{
    public class NotificarFuncionario : INotificacao
    {
        public string Descricao { get ; set; }

        public void Noticar()
        {
            Console.WriteLine("Notificando Funcionário");
        }
    }
}
