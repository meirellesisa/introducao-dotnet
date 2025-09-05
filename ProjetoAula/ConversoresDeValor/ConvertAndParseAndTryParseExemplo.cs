namespace ProjetoAula.ConversoresDeValor
{
    public class ConvertAndParseAndTryParseExemplo
    {
        public void CovertAndParseExecutar()
        {
            int numero = int.Parse("1");
            Console.WriteLine(numero);

            int numero2 = Convert.ToInt32("2");
            Console.WriteLine(numero2);

            //int numero3 = int.Parse("abc"); // isso lança uma excessão do tipo FormatException
            //Console.WriteLine(numero);

            int problemaComNull = Convert.ToInt32(null);
            Console.WriteLine(problemaComNull);

            //int numero3 = int.Parse(null);
            //Console.WriteLine(numero3);

            bool verdadeiro = bool.Parse("true");
            Console.WriteLine(verdadeiro);

            //bool verdadeiro2 = bool.Parse("verdadeiro");
            //Console.WriteLine(verdadeiro2);

        }

        public void TryParseExecutar()
        {
            var numero = "12345";
            var letras = "abcd";
            var boleano = "true";
            var boleanoInvalido = "verdadeiro";

            if (int.TryParse(numero, out int numeroConvertido))
            {
                Console.WriteLine("Valor convertido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível converter!");
            }
            Console.WriteLine(numeroConvertido);


            if (int.TryParse(letras, out int letraConvertida))
            {
                Console.WriteLine("Valor convertido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível converter!");
            }
            Console.WriteLine(letraConvertida);


            if (bool.TryParse(boleano, out bool boleanoConvertido))
            {
                Console.WriteLine("Valor convertido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível converter!");
            }

            Console.WriteLine(boleanoConvertido);


            if (bool.TryParse(boleanoInvalido, out bool boleanoConvertidoInvalido))
            {
                Console.WriteLine("Valor convertido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível converter!");
            }


            Console.WriteLine(boleanoConvertidoInvalido);

            //bool.TryParse();
            //long.TryParse();
            //char.TryParse();
        }
    }
}