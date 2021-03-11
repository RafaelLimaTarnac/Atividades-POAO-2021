using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_1
{
    class Usuario
    {
        // Atributos
        public string nome { get; }
        public int idade { get; set; }
        public double altura { get; set; }
        public float peso {get; set;}
        public double imc { get;}
        // Construtor
        public Usuario(string nome, int idade, double altura, float peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            imc = peso / (altura * altura);
        }
    }
}
