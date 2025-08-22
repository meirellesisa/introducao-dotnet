namespace ProjetoAula.EstruturasDeControle
{
    public class SwitchExemplos
    {
        public void Executar()
        {

            var diaDaSemana = 1;

            switch (diaDaSemana)
            {
                case 0:
                    {
                        Console.WriteLine("Hoje é domingo");
                        break;
                    }


                case 1:
                    Console.WriteLine("Hoje é segunda");
                    break;
            }

            switch (diaDaSemana < 1)
            {
                case true:
                    {
                        Console.WriteLine("essa expressão é verdadeira");
                        break;
                    }

                case false:
                    Console.WriteLine("essa expressão é falsa");
                    break;
            }



        }
    }
}
