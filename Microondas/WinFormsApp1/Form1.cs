using System.Timers;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer, limp;
        public List<ProgramasPadroes> programasPadroes { get; set; } = new List<ProgramasPadroes>();

        public Form1()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timerChama;

            limp = new System.Timers.Timer();
            limp.Interval = 1000;
            limp.Elapsed += limpeza;
            limp.AutoReset = false;

            programasPadroes.Add(new ProgramasPadroes(1,
                "Pipoca",
                3,
                7,
                "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.",
                'p'
                ));
            programasPadroes.Add(new ProgramasPadroes(2,
                "Leite",
                5,
                5,
                "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.",
                'l'
                ));
            programasPadroes.Add(new ProgramasPadroes(3,
                "Carnes de boi",
                14,
                4,
                "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
                'c'
                ));
            programasPadroes.Add(new ProgramasPadroes(4,
                "Frango",
                8,
                7,
                " Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
                'f'
                ));
            programasPadroes.Add(new ProgramasPadroes(6,
                "Feijao",
                8,
                9,
                " : Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas",
                'b'
                ));


            InitializeComponent();

        }


        public int tempoS = 0;
        public int potenciaM = 10;
        public int contador = 0;
        public bool parado = false;
        public char stringAquecimento = '.';
        public bool init = true;


        public void validaTempo(int tempo)
        {
            if (tempo > 120 || tempo < 1)
            {
                MessageBox.Show("O tempo deve ser menor que 2 minutos e no minimo 1 segundos");
            }
        }

        public void limpaCampos()
        {
            displayResult.Text = "";
            displayMain.Text = "";
            power.Text = "";
            powerResult.Text = "";
            stringInformativa.Text = "";
            tempoS = 0;
            potenciaM = 10;
            contador = 0;
            stringAquecimento = '.';
            init = false;
        }

        public bool validaPotencia(int potencia)
        {
            if (potencia < 0 || potencia > 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void inicioRapido()
        {
            tempoS += 30;
            if (displayResult.Text.Length == 0 && displayMain.Text.Length == 0)
            {
                tempoS = 30;
                displayResult.Text = "30";
            }
            else
            {
                displayResult.Text = SegundosParaMinutos(tempoS);

            }
            powerResult.Text = potenciaM.ToString();
            parado = false;
            timer.Start();
        }

        public void IniciarAquecimento(int tempo, int potencia)
        {

            validaTempo(tempo);
            if (tempo >= 60 || tempo < 100)
            {
                tempoS += tempo;
                displayResult.Text = SegundosParaMinutos(tempoS);
                displayMain.Text = "";
            }

            if (!validaPotencia(potencia))
            {
                powerResult.Text = potenciaM.ToString();
            }
            else
            {
                powerResult.Text = potencia.ToString();
                power.Text = "";
            }
            timer.Start();
            parado = false;


        }

        public void criaStringInformativa()
        {
            if (tempoS > contador)
            {
                string info = new string(stringAquecimento, potenciaM) + " ";
                stringInformativa.Text += info;
                contador++;
            }
            else
            {
                stringInformativa.Text += " Aquecimento concluido";
                limp.Start();
                timer.Stop();
            }

        }

        private void timerChama(object sender, ElapsedEventArgs e)
        {
            criaStringInformativa();
        }

        private void limpeza(object sender, ElapsedEventArgs e)
        {
            limpaCampos();
        }

        public int minutosParaSegundos(int tempo)
        {
            return tempo * 60;
        }

        public string SegundosParaMinutos(int tempo)
        {
            int minutos = tempo / 60;
            float segundosRestantes = tempo % 60;
            return $"{minutos} : {segundosRestantes}";
        }

        private void InitAquecimento_Click(object sender, EventArgs e)
        {
            if (init)
            {
                stringAquecimento = '.';
                if (parado)
                {
                    timer.Start();
                    parado = false;
                }
                else
                {
                    if (displayMain.Text.Length == 0)
                    {
                        MessageBox.Show("Quando o tempo não é definido o inicio rapido é iniciado");
                        inicioRapido();
                    }
                    else
                    {
                        int tempo = Int32.Parse(displayMain.Text);
                        int pot = (power.Text.Length == 0) ? 10 : Int32.Parse(power.Text);
                        potenciaM = pot;
                        if (power.Text.Length == 0)
                        {
                            MessageBox.Show("em caso de potência não informada, será inserido em tela o valor 10 como padrão");
                            IniciarAquecimento(tempo, pot);
                        }
                        else
                        {
                            IniciarAquecimento(tempo, pot);
                        }
                    }

                }
            }
            else
            {
            }
        }

        private void pararCancelar_Click(object sender, EventArgs e)
        {
            if (parado)
            {
                limpaCampos();
                parado = false;
            }
            else
            {
                timer.Stop();
                parado = true;
                init = false;
            }

        }

        private void BotaoZero_Click(object sender, EventArgs e)
        {
            displayMain.Text += "0";
        }

        private void ButtonUm_Click(object sender, EventArgs e)
        {
            displayMain.Text += "1";
        }

        private void ButtonDois_Click(object sender, EventArgs e)
        {
            displayMain.Text += "2";
        }

        private void ButtonTrez_Click(object sender, EventArgs e)
        {
            displayMain.Text += "3";
        }

        private void ButtonQuatro_Click(object sender, EventArgs e)
        {
            displayMain.Text += "4";
        }

        private void ButtonCinco_Click(object sender, EventArgs e)
        {
            displayMain.Text += "5";
        }

        private void ButtonSeis_Click(object sender, EventArgs e)
        {
            displayMain.Text += "6";
        }

        private void ButtonSete_Click(object sender, EventArgs e)
        {
            displayMain.Text += "7";
        }

        private void ButtonOito_Click(object sender, EventArgs e)
        {
            displayMain.Text += "8";
        }

        private void ButtonNove_Click(object sender, EventArgs e)
        {
            displayMain.Text += "9";
        }

        // ------------------------------------------------------------------

        private void CriarBotoesProgramas()
        {
            foreach (var programa in programasPadroes)
            {
                Button novoBotao = new Button();
                novoBotao.Text = $"{programa.Nome}\n potencia:{programa.Potencia}\nTempo {programa.Tempo}\n\n{programa.Instrucoes}";
                novoBotao.Tag = programa;
                novoBotao.Dock = DockStyle.Left;
                novoBotao.Size = new Size(120, 80);
                novoBotao.Click += botaoPrograma_Click;

                Padroes.Controls.Add(novoBotao);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CriarBotoesProgramas();
            criaBotoesCustom();
        }

        private void botaoPrograma_Click(object sender, EventArgs e)
        {
            limpaCampos();
            init = false;
            if (sender is Button botao)
            {
                if (botao.Tag is ProgramasPadroes programa)
                {
                    int tempo = programa.Tempo;

                    tempoS = minutosParaSegundos(tempo);
                    potenciaM = programa.Potencia;
                    powerResult.Text = potenciaM.ToString();
                    displayResult.Text += SegundosParaMinutos(tempoS);
                    stringAquecimento = programa.stringAquecimento;
                    timer.Start();
                }
            }

        }

        private void CadastraNovo_Click(object sender, EventArgs e)
        {
            Form2 abrirForm = new Form2();
            abrirForm.ShowDialog();
        }

        public void criaBotoesCustom()
        {
            Form2 salvos = new Form2();

            List<ProgramasPadroes> novosBotoes = salvos.listarTodos(Form2.caminho);
            CriarBotoesCustom(novosBotoes);
        }

        private void CriarBotoesCustom(List<ProgramasPadroes> novosBotoes)
        {
            foreach (var programa in novosBotoes)
            {
                Button novoBotao = new Button();
                novoBotao.Text = $"{programa.Nome}\n potencia:{programa.Potencia}\nTempo {programa.Tempo}\n\n{programa.Instrucoes}";
                novoBotao.Tag = programa;
                novoBotao.Dock = DockStyle.Right;
                novoBotao.Font = new Font(novoBotao.Font,FontStyle.Italic);
                novoBotao.Size = new Size(120, 80);
                novoBotao.Click += botaoPrograma_Click;

                panelCustom.Controls.Add(novoBotao);
            }
        }
    }
}
 