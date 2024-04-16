using System;
using System.Collections.Generic;
using System.Text;

namespace FormacaoNetDio
{
    internal class Lista_array
    {
        public List<string> nomes = new List<string>();

        public void ListDNomes()
        {
            nomes.Add("Lucas");
            nomes.Add("Anastacia");
            nomes.Add("Antonella");

            int ctr = 0;
            foreach (string str in nomes)
            {
                Console.WriteLine($"O {ctr} - nome é:{str}");
                ctr++;
            }

            Console.WriteLine("Usando o for:");

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine($"O {i} - nome é:{nomes[i]}");
            }
        }
    }
}
