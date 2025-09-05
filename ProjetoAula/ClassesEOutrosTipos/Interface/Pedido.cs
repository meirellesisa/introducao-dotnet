namespace ProjetoAula.ClassesEOutrosTipos.Interface
{
    public class Pedido : INotificacao, ILogar, IImprimir
    {
        public string Descricao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public void Log(string message)
        {
            Console.WriteLine("Pedido: 1, Valor: 20, VendidoPor: isabella");
        }

        public void Noticar()
        {
            throw new NotImplementedException();
        }
    }
}
