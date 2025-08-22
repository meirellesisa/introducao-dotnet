using System.Security.Cryptography.X509Certificates;

namespace ProjetoAula.EstruturaDeDados
{
    public class ArrayTipadoExemplo
    {
        public void Executar()
        {
            Console.WriteLine("Introduzindo Arrays Tipados");

            //var arrayTipado = new int[3] { 1, 2, "3" }; -> exemplo de erro 

            //Criando um array tipado 
            var arrayTipadoExemplo = new int[3];

            //Criando um array tipado e já inicializando com valores
            var arrayTipado = new int[3] { 1, 2, 3 };

            //Acessando os valores do array tipado
            Console.WriteLine(arrayTipado[0]);
            Console.WriteLine(arrayTipado[1]);
            Console.WriteLine("---------");

            //Atribuindo valores através do indice
            arrayTipado[1] = 10;

            //Aumentando a capacidade do array tipado
            Array.Resize(ref arrayTipado, 10);
            arrayTipado[9] = 100;

            //Acessando dados 
            foreach (var item in arrayTipado)
            {
                Console.WriteLine("Array exemplo " + item);
            }

            Console.WriteLine("---------");

            // Criando um array tipado de string
            var arrayTipado2 = new string[3];

            // Aumentando a capacidade do array tipado de string
            Array.Resize(ref arrayTipado2, 5);

            // Atribuindo valores atarvés do indice
            arrayTipado2[0] = "Tv";
            arrayTipado2[1] = "Notbook";
            arrayTipado2[2] = "Celular";
            arrayTipado2[3] = "Tablet";

            // Um array não permite remoção de dados como vimos 
            // o exemlo do RemoveaAt()

            foreach (var item in arrayTipado2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------- FIM");

            
        }

        public int Soma(int numero1, int numero2)
        {
            return 0;
        }
    }
}
