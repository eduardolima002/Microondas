﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayMain = new TextBox();
            power = new TextBox();
            Display = new Label();
            potencia = new Label();
            ButtonSete = new Button();
            ButtonOito = new Button();
            ButtonNove = new Button();
            ButtonSeis = new Button();
            ButtonQuatro = new Button();
            ButtonCinco = new Button();
            ButtonUm = new Button();
            ButtonDois = new Button();
            ButtonTrez = new Button();
            BotaoZero = new Button();
            pararCancelar = new Button();
            InitAquecimento = new Button();
            label1 = new Label();
            displayResult = new Label();
            powerResult = new Label();
            stringInformativa = new Label();
            SuspendLayout();
            // 
            // displayMain
            // 
            displayMain.Location = new Point(12, 12);
            displayMain.Name = "displayMain";
            displayMain.Size = new Size(103, 23);
            displayMain.TabIndex = 0;
            displayMain.TextAlign = HorizontalAlignment.Right;
            // 
            // power
            // 
            power.Location = new Point(12, 49);
            power.Name = "power";
            power.Size = new Size(103, 23);
            power.TabIndex = 1;
            power.TextAlign = HorizontalAlignment.Right;
            // 
            // Display
            // 
            Display.AutoSize = true;
            Display.Location = new Point(121, 20);
            Display.Name = "Display";
            Display.Size = new Size(54, 15);
            Display.TabIndex = 3;
            Display.Text = "Display : ";
            // 
            // potencia
            // 
            potencia.AutoSize = true;
            potencia.Location = new Point(121, 57);
            potencia.Name = "potencia";
            potencia.Size = new Size(62, 15);
            potencia.TabIndex = 4;
            potencia.Text = "Potência : ";
            // 
            // ButtonSete
            // 
            ButtonSete.Location = new Point(14, 168);
            ButtonSete.Name = "ButtonSete";
            ButtonSete.Size = new Size(54, 52);
            ButtonSete.TabIndex = 5;
            ButtonSete.Text = "7";
            ButtonSete.UseVisualStyleBackColor = true;
            // 
            // ButtonOito
            // 
            ButtonOito.Location = new Point(74, 168);
            ButtonOito.Name = "ButtonOito";
            ButtonOito.Size = new Size(54, 52);
            ButtonOito.TabIndex = 6;
            ButtonOito.Text = "8";
            ButtonOito.UseVisualStyleBackColor = true;
            // 
            // ButtonNove
            // 
            ButtonNove.Location = new Point(134, 168);
            ButtonNove.Name = "ButtonNove";
            ButtonNove.Size = new Size(54, 52);
            ButtonNove.TabIndex = 7;
            ButtonNove.Text = "9";
            ButtonNove.UseVisualStyleBackColor = true;
            // 
            // ButtonSeis
            // 
            ButtonSeis.Location = new Point(134, 226);
            ButtonSeis.Name = "ButtonSeis";
            ButtonSeis.Size = new Size(54, 52);
            ButtonSeis.TabIndex = 8;
            ButtonSeis.Text = "6";
            ButtonSeis.UseVisualStyleBackColor = true;
            // 
            // ButtonQuatro
            // 
            ButtonQuatro.Location = new Point(14, 226);
            ButtonQuatro.Name = "ButtonQuatro";
            ButtonQuatro.Size = new Size(54, 52);
            ButtonQuatro.TabIndex = 9;
            ButtonQuatro.Text = "4";
            ButtonQuatro.UseVisualStyleBackColor = true;
            // 
            // ButtonCinco
            // 
            ButtonCinco.Location = new Point(74, 226);
            ButtonCinco.Name = "ButtonCinco";
            ButtonCinco.Size = new Size(54, 52);
            ButtonCinco.TabIndex = 10;
            ButtonCinco.Text = "5";
            ButtonCinco.UseVisualStyleBackColor = true;
            // 
            // ButtonUm
            // 
            ButtonUm.Location = new Point(14, 284);
            ButtonUm.Name = "ButtonUm";
            ButtonUm.Size = new Size(54, 52);
            ButtonUm.TabIndex = 11;
            ButtonUm.Text = "1";
            ButtonUm.UseVisualStyleBackColor = true;
            // 
            // ButtonDois
            // 
            ButtonDois.Location = new Point(74, 284);
            ButtonDois.Name = "ButtonDois";
            ButtonDois.Size = new Size(54, 52);
            ButtonDois.TabIndex = 12;
            ButtonDois.Text = "2";
            ButtonDois.UseVisualStyleBackColor = true;
            // 
            // ButtonTrez
            // 
            ButtonTrez.Location = new Point(134, 284);
            ButtonTrez.Name = "ButtonTrez";
            ButtonTrez.Size = new Size(54, 52);
            ButtonTrez.TabIndex = 13;
            ButtonTrez.Text = "3";
            ButtonTrez.UseVisualStyleBackColor = true;
            // 
            // BotaoZero
            // 
            BotaoZero.Location = new Point(14, 342);
            BotaoZero.Name = "BotaoZero";
            BotaoZero.Size = new Size(174, 52);
            BotaoZero.TabIndex = 14;
            BotaoZero.Text = "0";
            BotaoZero.UseVisualStyleBackColor = true;
            // 
            // pararCancelar
            // 
            pararCancelar.Location = new Point(14, 112);
            pararCancelar.Name = "pararCancelar";
            pararCancelar.Size = new Size(84, 52);
            pararCancelar.TabIndex = 15;
            pararCancelar.Text = "Parar Cancelar";
            pararCancelar.UseVisualStyleBackColor = true;
            pararCancelar.Click += pararCancelar_Click;
            // 
            // InitAquecimento
            // 
            InitAquecimento.Location = new Point(109, 112);
            InitAquecimento.Name = "InitAquecimento";
            InitAquecimento.Size = new Size(84, 52);
            InitAquecimento.TabIndex = 16;
            InitAquecimento.Text = "Iniciar/Aquecimento";
            InitAquecimento.UseVisualStyleBackColor = true;
            InitAquecimento.Click += InitAquecimento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // displayResult
            // 
            displayResult.AutoSize = true;
            displayResult.Location = new Point(181, 20);
            displayResult.Name = "displayResult";
            displayResult.Size = new Size(0, 15);
            displayResult.TabIndex = 18;
            // 
            // powerResult
            // 
            powerResult.AutoSize = true;
            powerResult.Location = new Point(181, 57);
            powerResult.Name = "powerResult";
            powerResult.Size = new Size(0, 15);
            powerResult.TabIndex = 19;
            // 
            // stringInformativa
            // 
            stringInformativa.AutoSize = true;
            stringInformativa.Location = new Point(228, 20);
            stringInformativa.Name = "stringInformativa";
            stringInformativa.Size = new Size(0, 15);
            stringInformativa.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 531);
            Controls.Add(stringInformativa);
            Controls.Add(powerResult);
            Controls.Add(displayResult);
            Controls.Add(label1);
            Controls.Add(InitAquecimento);
            Controls.Add(pararCancelar);
            Controls.Add(BotaoZero);
            Controls.Add(ButtonTrez);
            Controls.Add(ButtonDois);
            Controls.Add(ButtonUm);
            Controls.Add(ButtonCinco);
            Controls.Add(ButtonQuatro);
            Controls.Add(ButtonSeis);
            Controls.Add(ButtonNove);
            Controls.Add(ButtonOito);
            Controls.Add(ButtonSete);
            Controls.Add(potencia);
            Controls.Add(Display);
            Controls.Add(power);
            Controls.Add(displayMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayMain;
        private TextBox power;
        private Label Display;
        private Label potencia;
        private Button ButtonSete;
        private Button ButtonOito;
        private Button ButtonNove;
        private Button ButtonSeis;
        private Button ButtonQuatro;
        private Button ButtonCinco;
        private Button ButtonUm;
        private Button ButtonDois;
        private Button ButtonTrez;
        private Button BotaoZero;
        private Button pararCancelar;
        private Button InitAquecimento;
        private Label label1;
        private Label displayResult;
        private Label powerResult;
        private Label stringInformativa;
    }
}
