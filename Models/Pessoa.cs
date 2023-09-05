using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {

        }
       public Pessoa(string nome, string sobrenome)
       {
            Name = nome;
            Sobrenome = sobrenome;
       }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Name;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Name 
        {   
            get => _nome.ToUpper();
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vázio.");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Name} {Sobrenome}".ToUpper();

        public int Idade 
        {
            get => _idade; 
            
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }


    }
}