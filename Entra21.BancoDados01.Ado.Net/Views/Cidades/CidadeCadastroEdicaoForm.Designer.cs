namespace Entra21.BancoDados01.Ado.Net.Exercicio.Views.Cidades
{
    partial class CidadeCadastroEdicaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeCidade = new System.Windows.Forms.Label();
            this.labelEstadoCidade = new System.Windows.Forms.Label();
            this.labelPibCidade = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.labelFundacaoCidade = new System.Windows.Forms.Label();
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeHabitantes = new System.Windows.Forms.TextBox();
            this.dateTimePickerHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomeCidade
            // 
            this.labelNomeCidade.AutoSize = true;
            this.labelNomeCidade.Location = new System.Drawing.Point(9, 22);
            this.labelNomeCidade.Name = "labelNomeCidade";
            this.labelNomeCidade.Size = new System.Drawing.Size(40, 15);
            this.labelNomeCidade.TabIndex = 0;
            this.labelNomeCidade.Text = "Nome";
            // 
            // labelEstadoCidade
            // 
            this.labelEstadoCidade.AutoSize = true;
            this.labelEstadoCidade.Location = new System.Drawing.Point(9, 66);
            this.labelEstadoCidade.Name = "labelEstadoCidade";
            this.labelEstadoCidade.Size = new System.Drawing.Size(42, 15);
            this.labelEstadoCidade.TabIndex = 1;
            this.labelEstadoCidade.Text = "Estado";
            // 
            // labelPibCidade
            // 
            this.labelPibCidade.AutoSize = true;
            this.labelPibCidade.Location = new System.Drawing.Point(9, 110);
            this.labelPibCidade.Name = "labelPibCidade";
            this.labelPibCidade.Size = new System.Drawing.Size(24, 15);
            this.labelPibCidade.TabIndex = 2;
            this.labelPibCidade.Text = "Pib";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNome.Location = new System.Drawing.Point(9, 40);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(262, 23);
            this.textBoxNome.TabIndex = 3;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxEstado.DisplayMember = "Nome";
            this.comboBoxEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(9, 84);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(262, 23);
            this.comboBoxEstado.TabIndex = 4;
            // 
            // dateTimePickerDataFundacao
            // 
            this.dateTimePickerDataFundacao.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePickerDataFundacao.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePickerDataFundacao.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePickerDataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFundacao.Location = new System.Drawing.Point(9, 216);
            this.dateTimePickerDataFundacao.Name = "dateTimePickerDataFundacao";
            this.dateTimePickerDataFundacao.Size = new System.Drawing.Size(109, 23);
            this.dateTimePickerDataFundacao.TabIndex = 6;
            // 
            // labelFundacaoCidade
            // 
            this.labelFundacaoCidade.AutoSize = true;
            this.labelFundacaoCidade.Location = new System.Drawing.Point(9, 198);
            this.labelFundacaoCidade.Name = "labelFundacaoCidade";
            this.labelFundacaoCidade.Size = new System.Drawing.Size(100, 15);
            this.labelFundacaoCidade.TabIndex = 7;
            this.labelFundacaoCidade.Text = "Data de fundação";
            // 
            // labelQuantidadeHabitantes
            // 
            this.labelQuantidadeHabitantes.AutoSize = true;
            this.labelQuantidadeHabitantes.Location = new System.Drawing.Point(9, 154);
            this.labelQuantidadeHabitantes.Name = "labelQuantidadeHabitantes";
            this.labelQuantidadeHabitantes.Size = new System.Drawing.Size(143, 15);
            this.labelQuantidadeHabitantes.TabIndex = 8;
            this.labelQuantidadeHabitantes.Text = "Quantidade de habitantes";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCancelar.Location = new System.Drawing.Point(126, 245);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 35);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSalvar.Location = new System.Drawing.Point(207, 245);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 35);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxPib
            // 
            this.textBoxPib.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPib.Location = new System.Drawing.Point(9, 128);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(262, 23);
            this.textBoxPib.TabIndex = 12;
            // 
            // textBoxQuantidadeHabitantes
            // 
            this.textBoxQuantidadeHabitantes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxQuantidadeHabitantes.Location = new System.Drawing.Point(9, 172);
            this.textBoxQuantidadeHabitantes.Name = "textBoxQuantidadeHabitantes";
            this.textBoxQuantidadeHabitantes.Size = new System.Drawing.Size(262, 23);
            this.textBoxQuantidadeHabitantes.TabIndex = 13;
            // 
            // dateTimePickerHoraFundacao
            // 
            this.dateTimePickerHoraFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFundacao.Location = new System.Drawing.Point(162, 216);
            this.dateTimePickerHoraFundacao.Name = "dateTimePickerHoraFundacao";
            this.dateTimePickerHoraFundacao.Size = new System.Drawing.Size(109, 23);
            this.dateTimePickerHoraFundacao.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hora de fundação";
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(283, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerHoraFundacao);
            this.Controls.Add(this.textBoxQuantidadeHabitantes);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.labelFundacaoCidade);
            this.Controls.Add(this.dateTimePickerDataFundacao);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelPibCidade);
            this.Controls.Add(this.labelEstadoCidade);
            this.Controls.Add(this.labelNomeCidade);
            this.Name = "CidadeCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNomeCidade;
        private Label labelEstadoCidade;
        private Label labelPibCidade;
        private TextBox textBoxNome;
        private ComboBox comboBoxEstado;
        private DateTimePicker dateTimePickerDataFundacao;
        private Label labelFundacaoCidade;
        private Label labelQuantidadeHabitantes;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private TextBox textBoxPib;
        private TextBox textBoxQuantidadeHabitantes;
        private DateTimePicker dateTimePickerHoraFundacao;
        private Label label1;
    }
}