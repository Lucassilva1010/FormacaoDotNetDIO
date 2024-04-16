using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FormacaoNetDio.Models
{
    class LerArquivos
    {
        public void LendoArquivos()
        {
            try
            {
                // Especifique o caminho do arquivo que você deseja ler
                string caminhoArquivo = @"C:\Users\pc3co\source\repos\FormacaoNetDio\teste\ArquivoLeitura.txt";

                // Crie um objeto StreamReader para ler o arquivo
                using (StreamReader leitor = new StreamReader(caminhoArquivo))
                {
                    // Leia todo o conteúdo do arquivo
                    string conteudo = leitor.ReadToEnd();

                    // Exibe o conteúdo do arquivo no console
                    Console.WriteLine(conteudo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {e.Message}");
            }

            // Aguarde até que o usuário pressione uma tecla antes de sair
            Console.ReadLine();
        }
    }
}
