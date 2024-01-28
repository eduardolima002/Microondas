using System.Timers;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer, limp;
        public Form1()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timerChama;

            limp = new System.Timers.Timer();
            limp.Interval = 1000;
            limp.Elapsed += limpeza;
            limp.AutoReset = false;

            InitializeComponent();
        }

        public int tempoS = 0;
        public int potenciaM = 10;
        public int contador = 0;
        public bool parado = false;

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
                string info = new string('.', potenciaM) + " ";
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

        public string SegundosParaMinutos(int tempo)
        {
            int minutos = tempo / 60;
            float segundosRestantes = tempo % 60;
            return $"{minutos} : {segundosRestantes}";
        }

        private void InitAquecimento_Click(object sender, EventArgs e)
        {
            if(parado)
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
            }
                
        }
    }
}
