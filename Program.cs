using System;

namespace ExercicioImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int resultado = numero % 2;
            /*variavel inteira o resultado é igual a variavel numero dividido por dois*/
            bool comparacao = resultado == 0;
            /*variavel boleana comparacao é igual a variavel resultado comparado ao numero zero*/

            if(comparacao)
            {
                Console.WriteLine($"O número {numero} é par.");   
            }
            else
            {
                Console.WriteLine($"O número {numero} é impar.");   
            }
        }
    }
}
