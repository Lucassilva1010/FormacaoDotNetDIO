using System;
using System.Collections.Generic;
using System.Text;

namespace FormacaoNetDio
{
    class UsandoFor
    {
 
        
        int numero = 5;

        /// <summary>
        /// Metodo que mostra um multiplicação de numeros
        /// </summary>
        public void UsaFor()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{this.numero} x {i} = {numero* i}");
            }
        }
        public void UsaWhile()
        {
            int numero = 10;

            while (numero!=0)
            {
                Console.WriteLine($"Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
            }
        }

        public void UsaDoWhile()
        {
            int numero = 0;

            do
            {
                Console.WriteLine($"Dgite um valor inteiro:");
                numero = int.Parse(Console.ReadLine());
            } while (numero != 0);
        }
    }
}
