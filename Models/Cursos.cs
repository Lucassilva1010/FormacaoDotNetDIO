using System;
using System.Collections.Generic;
using System.Text;

namespace FormacaoNetDio.Models
{
    class Cursos
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeAlunos()
        {
            int qtd = Alunos.Count;
            return qtd;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            //int cont = 0;
            //    Console.WriteLine("------------Apresentar os dados ---------FOREACH::::::::");
            //foreach (Pessoa aluno in Alunos)
            //{

            //    Console.WriteLine($"Esse foi o {cont} Aluno de Nome: {aluno.Nome} Idade: {aluno.Idade} cadastrado.");
            //    cont++;
            //}

            //Poderia ser mostrado de outra forma, usando o for
            Console.WriteLine("-------------Nova Forma de Apresentar os dados ---------FOR::::::::");
            for (int i = 0; i< Alunos.Count; i++)
            {
               
                Console.WriteLine($"Nº {i+1} - {Alunos[i].Nome} - {Alunos[i].Idade} ");
            }
        }
    }
}
