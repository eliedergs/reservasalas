namespace MG_Reserva
{
    partial class Gerenciador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logSaida = new System.Windows.Forms.RichTextBox();
            this.groupCriarReservas = new System.Windows.Forms.GroupBox();
            this.labelAlertaData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValidationHoraInicio = new System.Windows.Forms.Label();
            this.textHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.labelFim = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.textHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.checkWebCam = new System.Windows.Forms.CheckBox();
            this.checkInternet = new System.Windows.Forms.CheckBox();
            this.labelNomeArquivo = new System.Windows.Forms.Label();
            this.textNomeArquivo = new System.Windows.Forms.TextBox();
            this.logArquivoReservas = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.numericTamanho = new System.Windows.Forms.NumericUpDown();
            this.labelTamanho = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnReservar = new System.Windows.Forms.Button();
            this.labelSaida = new System.Windows.Forms.Label();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.logEntrada = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupCriarReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logSaida);
            this.panel1.Controls.Add(this.groupCriarReservas);
            this.panel1.Controls.Add(this.btnReservar);
            this.panel1.Controls.Add(this.labelSaida);
            this.panel1.Controls.Add(this.labelEntrada);
            this.panel1.Controls.Add(this.logEntrada);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 373);
            this.panel1.TabIndex = 0;
            // 
            // logSaida
            // 
            this.logSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logSaida.Location = new System.Drawing.Point(402, 35);
            this.logSaida.Name = "logSaida";
            this.logSaida.ReadOnly = true;
            this.logSaida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logSaida.Size = new System.Drawing.Size(320, 144);
            this.logSaida.TabIndex = 0;
            this.logSaida.Text = "";
            // 
            // groupCriarReservas
            // 
            this.groupCriarReservas.Controls.Add(this.labelAlertaData);
            this.groupCriarReservas.Controls.Add(this.label3);
            this.groupCriarReservas.Controls.Add(this.label2);
            this.groupCriarReservas.Controls.Add(this.label1);
            this.groupCriarReservas.Controls.Add(this.labelValidationHoraInicio);
            this.groupCriarReservas.Controls.Add(this.textHoraFim);
            this.groupCriarReservas.Controls.Add(this.labelFim);
            this.groupCriarReservas.Controls.Add(this.btnGravar);
            this.groupCriarReservas.Controls.Add(this.textHoraInicio);
            this.groupCriarReservas.Controls.Add(this.checkWebCam);
            this.groupCriarReservas.Controls.Add(this.checkInternet);
            this.groupCriarReservas.Controls.Add(this.labelNomeArquivo);
            this.groupCriarReservas.Controls.Add(this.textNomeArquivo);
            this.groupCriarReservas.Controls.Add(this.logArquivoReservas);
            this.groupCriarReservas.Controls.Add(this.btnEnviar);
            this.groupCriarReservas.Controls.Add(this.numericTamanho);
            this.groupCriarReservas.Controls.Add(this.labelTamanho);
            this.groupCriarReservas.Controls.Add(this.labelInicio);
            this.groupCriarReservas.Controls.Add(this.textData);
            this.groupCriarReservas.Controls.Add(this.labelData);
            this.groupCriarReservas.Controls.Add(this.calendario);
            this.groupCriarReservas.Location = new System.Drawing.Point(0, 185);
            this.groupCriarReservas.Name = "groupCriarReservas";
            this.groupCriarReservas.Size = new System.Drawing.Size(668, 188);
            this.groupCriarReservas.TabIndex = 5;
            this.groupCriarReservas.TabStop = false;
            this.groupCriarReservas.Text = "Criar Reservas";
            // 
            // labelAlertaData
            // 
            this.labelAlertaData.AutoSize = true;
            this.labelAlertaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlertaData.ForeColor = System.Drawing.Color.Maroon;
            this.labelAlertaData.Location = new System.Drawing.Point(278, 16);
            this.labelAlertaData.Name = "labelAlertaData";
            this.labelAlertaData.Size = new System.Drawing.Size(60, 13);
            this.labelAlertaData.TabIndex = 22;
            this.labelAlertaData.Text = "Dia não útil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(236, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(247, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "* Obrigatório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(297, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // labelValidationHoraInicio
            // 
            this.labelValidationHoraInicio.AutoSize = true;
            this.labelValidationHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidationHoraInicio.ForeColor = System.Drawing.Color.Maroon;
            this.labelValidationHoraInicio.Location = new System.Drawing.Point(242, 55);
            this.labelValidationHoraInicio.Name = "labelValidationHoraInicio";
            this.labelValidationHoraInicio.Size = new System.Drawing.Size(13, 17);
            this.labelValidationHoraInicio.TabIndex = 18;
            this.labelValidationHoraInicio.Text = "*";
            // 
            // textHoraFim
            // 
            this.textHoraFim.Location = new System.Drawing.Point(300, 72);
            this.textHoraFim.Mask = "00:00";
            this.textHoraFim.Name = "textHoraFim";
            this.textHoraFim.Size = new System.Drawing.Size(38, 20);
            this.textHoraFim.TabIndex = 5;
            this.textHoraFim.ValidatingType = typeof(System.DateTime);
            this.textHoraFim.TextChanged += new System.EventHandler(this.TextHoraFim_TextChanged);
            // 
            // labelFim
            // 
            this.labelFim.AutoSize = true;
            this.labelFim.Location = new System.Drawing.Point(308, 57);
            this.labelFim.Name = "labelFim";
            this.labelFim.Size = new System.Drawing.Size(23, 13);
            this.labelFim.TabIndex = 17;
            this.labelFim.Text = "Fim";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(590, 31);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(66, 20);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // textHoraInicio
            // 
            this.textHoraInicio.Location = new System.Drawing.Point(245, 72);
            this.textHoraInicio.Mask = "00:00";
            this.textHoraInicio.Name = "textHoraInicio";
            this.textHoraInicio.Size = new System.Drawing.Size(41, 20);
            this.textHoraInicio.TabIndex = 4;
            this.textHoraInicio.ValidatingType = typeof(System.DateTime);
            this.textHoraInicio.TextChanged += new System.EventHandler(this.TextHoraInicio_TextChanged);
            // 
            // checkWebCam
            // 
            this.checkWebCam.AutoSize = true;
            this.checkWebCam.Location = new System.Drawing.Point(302, 98);
            this.checkWebCam.Name = "checkWebCam";
            this.checkWebCam.Size = new System.Drawing.Size(70, 17);
            this.checkWebCam.TabIndex = 7;
            this.checkWebCam.Text = "WebCam";
            this.checkWebCam.UseVisualStyleBackColor = true;
            // 
            // checkInternet
            // 
            this.checkInternet.AutoSize = true;
            this.checkInternet.Location = new System.Drawing.Point(302, 121);
            this.checkInternet.Name = "checkInternet";
            this.checkInternet.Size = new System.Drawing.Size(62, 17);
            this.checkInternet.TabIndex = 8;
            this.checkInternet.Text = "Internet";
            this.checkInternet.UseVisualStyleBackColor = true;
            // 
            // labelNomeArquivo
            // 
            this.labelNomeArquivo.AutoSize = true;
            this.labelNomeArquivo.Location = new System.Drawing.Point(373, 15);
            this.labelNomeArquivo.Name = "labelNomeArquivo";
            this.labelNomeArquivo.Size = new System.Drawing.Size(88, 13);
            this.labelNomeArquivo.TabIndex = 12;
            this.labelNomeArquivo.Text = "Nome do arquivo";
            // 
            // textNomeArquivo
            // 
            this.textNomeArquivo.Location = new System.Drawing.Point(376, 31);
            this.textNomeArquivo.Name = "textNomeArquivo";
            this.textNomeArquivo.Size = new System.Drawing.Size(203, 20);
            this.textNomeArquivo.TabIndex = 1;
            // 
            // logArquivoReservas
            // 
            this.logArquivoReservas.Location = new System.Drawing.Point(376, 57);
            this.logArquivoReservas.Name = "logArquivoReservas";
            this.logArquivoReservas.ReadOnly = true;
            this.logArquivoReservas.Size = new System.Drawing.Size(280, 120);
            this.logArquivoReservas.TabIndex = 0;
            this.logArquivoReservas.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(276, 158);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(62, 22);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar ->";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // numericTamanho
            // 
            this.numericTamanho.Location = new System.Drawing.Point(250, 114);
            this.numericTamanho.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericTamanho.Name = "numericTamanho";
            this.numericTamanho.Size = new System.Drawing.Size(44, 20);
            this.numericTamanho.TabIndex = 6;
            this.numericTamanho.ValueChanged += new System.EventHandler(this.NumericTamanho_ValueChanged);
            // 
            // labelTamanho
            // 
            this.labelTamanho.AutoSize = true;
            this.labelTamanho.Location = new System.Drawing.Point(247, 98);
            this.labelTamanho.Name = "labelTamanho";
            this.labelTamanho.Size = new System.Drawing.Size(52, 13);
            this.labelTamanho.TabIndex = 9;
            this.labelTamanho.Text = "Tamanho";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(251, 57);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(32, 13);
            this.labelInicio.TabIndex = 5;
            this.labelInicio.Text = "Inicio";
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(245, 32);
            this.textData.Name = "textData";
            this.textData.ReadOnly = true;
            this.textData.Size = new System.Drawing.Size(93, 20);
            this.textData.TabIndex = 3;
            this.textData.TextChanged += new System.EventHandler(this.TextData_TextChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(242, 16);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(6, 15);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(334, 91);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(62, 38);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // labelSaida
            // 
            this.labelSaida.AutoSize = true;
            this.labelSaida.Location = new System.Drawing.Point(399, 19);
            this.labelSaida.Name = "labelSaida";
            this.labelSaida.Size = new System.Drawing.Size(34, 13);
            this.labelSaida.TabIndex = 3;
            this.labelSaida.Text = "Saida";
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Location = new System.Drawing.Point(3, 19);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(44, 13);
            this.labelEntrada.TabIndex = 1;
            this.labelEntrada.Text = "Entrada";
            // 
            // logEntrada
            // 
            this.logEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEntrada.Location = new System.Drawing.Point(6, 35);
            this.logEntrada.Name = "logEntrada";
            this.logEntrada.ReadOnly = true;
            this.logEntrada.Size = new System.Drawing.Size(322, 144);
            this.logEntrada.TabIndex = 0;
            this.logEntrada.Text = "";
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 397);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupCriarReservas.ResumeLayout(false);
            this.groupCriarReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTamanho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupCriarReservas;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label labelSaida;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.RichTextBox logEntrada;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.RichTextBox logSaida;
        private System.Windows.Forms.MaskedTextBox textHoraInicio;
        private System.Windows.Forms.CheckBox checkWebCam;
        private System.Windows.Forms.CheckBox checkInternet;
        private System.Windows.Forms.Label labelNomeArquivo;
        private System.Windows.Forms.TextBox textNomeArquivo;
        private System.Windows.Forms.RichTextBox logArquivoReservas;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NumericUpDown numericTamanho;
        private System.Windows.Forms.Label labelTamanho;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.MaskedTextBox textHoraFim;
        private System.Windows.Forms.Label labelFim;
        private System.Windows.Forms.Label labelValidationHoraInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlertaData;
    }
}

