﻿using System;

namespace ExercicioImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
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
