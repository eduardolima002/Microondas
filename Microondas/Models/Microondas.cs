using Microondas.Models.Execoes;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


namespace Microondas.Models
{
    public class Microondas
    {
        public float Tempo { get; set; }
        public int Potencia { get; set; }
        public bool Aquecimento { get; set; }
        public bool Pausado { get; set; }



        public List<Programa> ProgramasPreDefinidos { get;}
        public List<Programa> ProgramasPersonalizados { get; } = new List<Programa>();

        public Microondas() { 
            this.Potencia = 10;
            ProgramasPreDefinidos = new List<Programa>();
        }

        public Microondas(float Tempo, int Potencia)
        {
            ProgramasPreDefinidos = new List<Programa>();
            this.Tempo = Tempo;
            this.Potencia = Potencia;
        }

        public Tuple<float, int>IniciaAquecimento(float tempo, int potencia)
        {
           string? temp = (tempo > 2 || tempo < 0.1) ? throw new MicroondasExecao("digite um tempo valido") : null;
            if(temp != null && tempo > 60 && tempo > 10)
            {
                tempo = this.ConverteToMinuto(tempo);
            }
            else if(temp != null)
            {
                tempo = this.ConverteToSegundos(tempo);
            }

            if((potencia > 0) && (potencia > 10)) {
                throw new MicroondasExecao("Potencia invalida");
            }
            else
            {
                this.Potencia = potencia;
            }
            return Tuple.Create(this.Tempo, this.Potencia);
            
        }

        public Tuple<float, int> InicioRapido()
        {
            this.Potencia = 10;
            this.Tempo = 30;

            return Tuple.Create(this.Tempo, this.Potencia);
        }

        public float ConverteToMinuto(float tempo)
        {
            return tempo / 60;
        }

        public float ConverteToSegundos(float tempo)
        {
            return tempo / 100;
        }

        public void verificarAquecimento()
        {
            this.Aquecimento = (this.Aquecimento == true) ? false : true;
        }

        public string exibirString()
        {
            string label = String.Empty; 
            int quantidadeDePontos =(int)this.Tempo * this.Potencia;
            int pot = this.Potencia;
            for(int i = 0; i < quantidadeDePontos; i++)
            {
                if (i == pot)
                {
                    label += " ";
                    pot += this.Potencia;
                    exibirLabel(label);
                    continue;
                }
                else
                {
                    label += ".";
                    exibirLabel(label);
                }
            }

            return exibirLabel(label) + " Aquecimento concluído";

        }

        public string exibirLabel(string l)
        {
            return l;
        }

        public void Pausar()
        {
            this.Pausado = true;
        }

        public void Iniciar()
        {
            this.Aquecimento = (this.Aquecimento == true) ? false : true;
         }

        private void AdicionaProgramasDefinidos()
        {
            ProgramasPreDefinidos.Add( new Programa("Pipoca", "Pipoca (de micro-ondas)", 3, 7, 'p' ,": Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento."));
            ProgramasPreDefinidos.Add( new Programa("Leite", "Leite", 5, 5, 'l' , ": Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras."));
            ProgramasPreDefinidos.Add( new Programa("Carnes de boi", "Carne em pedaço ou fatias", 14, 4, 'c' , "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme"));
            ProgramasPreDefinidos.Add( new Programa("Frango", " Frango (qualquer corte)", 8, 7, 'f' , ": Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme"));
            ProgramasPreDefinidos.Add( new Programa("Feijão", ": Feijão congelado", 8, 9, 'b' , ": Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo\r\npode perder resistência em altas temperaturas"));

        }

        public void AdicionaProgramasPersonalizados(Programa programa)
        {
            bool igual = false;
            foreach (var p in ProgramasPreDefinidos)
            {
                if (p.stringDeAquecimento == programa.stringDeAquecimento)
                {
                    igual = true;
                    throw new MicroondasExecao("Essa string de aquecimento já existe!");
                    break;
                }
            }
            if (!igual)
            {
                ProgramasPersonalizados.Add(programa);

            }
        }
    }
}
