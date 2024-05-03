using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            nome = nome;
            sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException ("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public Pessoa(string sobrenome) 
        {
            this.Sobrenome = sobrenome;
   
        }
        public string Sobrenome {get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        

    }
    
}


