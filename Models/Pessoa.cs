using System;
using System.Collections.Generic;
using System.Text;

namespace FormacaoNetDio.Models
{
    class Pessoa
    {

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public Pessoa()
        {

        }

        public string  Nome { get; set; }
        public int  Idade { get; set; }
       
    }
}
