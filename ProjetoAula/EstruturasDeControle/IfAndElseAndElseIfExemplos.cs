namespace ProjetoAula.EstruturasDeControle
{
    public class IfAndElseAndElseIfExemplos
    {
        public void Executar()
        {
            var diaDaSemana = 10;
            var diaDeTrabalho = false;

            if (diaDaSemana == 0 && diaDeTrabalho == true)
            {
                Console.WriteLine("Hoje é domingo");
            }
            else
            {
                Console.WriteLine("Hoje não é domingo");
            }

            Console.WriteLine("------------");

            if (diaDaSemana == 0 && diaDeTrabalho == true)
            {
                Console.WriteLine("Hoje é domingo");

            }
            else if (diaDaSemana == 0 && diaDeTrabalho == false)
            {
                Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
            }
            else
            {
                Console.WriteLine("Hoje não é domingo");
            }


            Console.WriteLine("------------");
            if (diaDaSemana == 0)
            {
                Console.WriteLine("Hoje é domingo");

            }
            else if (diaDaSemana == 1)
            {
                Console.WriteLine("Hoje é segunda");
            }
            else if (diaDaSemana == 2)
            {
                Console.WriteLine("Hoje é terça");

            }
            else if (diaDaSemana == 3)
            {
                Console.WriteLine("Hoje é quarta");
            }
            else if (diaDaSemana == 4)
            {
                Console.WriteLine("Hoje é quinta");
            }
            else if (diaDaSemana == 5)
            {
                Console.WriteLine("Hoje é sexta");
            }
            else if (diaDaSemana == 6)
            {
                Console.WriteLine("Hoje é sabado");
            }
            else
            {
                Console.WriteLine("Dia da semana inválido");
            }

        }
    }
}
