using System;
using System.Collections.Generic;
using System.Text;

namespace FormacaoNetDio
{
    internal class Array_listas
    {

        string[] nomes = { "lucas", "Anastacia", "Antonella" };
        public void listas(int n)
        {

            int[] numeros = new int[n];

            for (int i = 0; i <numeros.Length; i++)
            {
                Console.WriteLine($"Digite {i} numero");

                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        public void listarNumeros()
        {

            int[] numeros = { 1 ,2 , 3};

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i} numero = {numeros[i]}");

             
            }
        }


        public void MostraLiat()
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"O {i} nome é: {nomes[i]}");
            }
        }
    }
}
