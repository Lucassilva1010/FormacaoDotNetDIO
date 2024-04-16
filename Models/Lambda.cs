using System;
using System.Collections.Generic;
using System.Text;

namespace FormacaoNetDio.Models
{
    class Lambda
    {
        public void MostraCalculo()
        {
            int numero = 15;
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O numero {numero} é par!");
            }
            else
            {

                Console.WriteLine($"O numero {numero} é Impar!");
            }

            Console.WriteLine("Usando o ternario:");

            bool resultado = numero % 2 == 0;
            Console.WriteLine($"O numero: {numero} é ->" + (resultado ? "PAR" : "Impar"));

        }
    }
}
