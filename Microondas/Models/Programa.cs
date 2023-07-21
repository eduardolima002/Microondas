using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Microondas.Models
{
    public class Programa
    {
        public string nome { get; set; }
        public string alimento { get; set; }

        public float tempo { get; set; }

        public int potencia { get; set; }

        public char charAquecimento { get; set; }

        public string stringDeAquecimento { get; set; }

        public Programa(string nome, string alimento, float tempo, int potencia, char charAquecimento, string stringAquecimento)
        {
            this.nome = nome;
            this.alimento = alimento;
            this.tempo = tempo;
            this.potencia = potencia;
            this.charAquecimento = charAquecimento;
            this.stringDeAquecimento = stringAquecimento;
        }

        public Programa(string nome, string alimento, float tempo, int potencia, char charAquecimento)
        {
            this.nome = nome;
            this.alimento = alimento;
            this.tempo = tempo;
            this.potencia = potencia;
            this.charAquecimento = charAquecimento;
            this.stringDeAquecimento = "";
        }
    }
}
