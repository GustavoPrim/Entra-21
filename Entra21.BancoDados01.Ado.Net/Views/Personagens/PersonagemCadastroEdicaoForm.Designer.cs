namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    partial class PersonagemCadastroEdicaoForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelEditora = new System.Windows.Forms.Label();
            this.labelTipoPersonagem = new System.Windows.Forms.Label();
            this.comboBoxEditora = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoPersonagem = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(366, 27);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(12, 62);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(57, 20);
            this.labelEditora.TabIndex = 2;
            this.labelEditora.Text = "Editora";
            // 
            // labelTipoPersonagem
            // 
            this.labelTipoPersonagem.AutoSize = true;
            this.labelTipoPersonagem.Location = new System.Drawing.Point(12, 116);
            this.labelTipoPersonagem.Name = "labelTipoPersonagem";
            this.labelTipoPersonagem.Size = new System.Drawing.Size(124, 20);
            this.labelTipoPersonagem.TabIndex = 4;
            this.labelTipoPersonagem.Text = "Tipo Personagem";
            // 
            // comboBoxEditora
            // 
            this.comboBoxEditora.FormattingEnabled = true;
            this.comboBoxEditora.Location = new System.Drawing.Point(12, 85);
            this.comboBoxEditora.Name = "comboBoxEditora";
            this.comboBoxEditora.Size = new System.Drawing.Size(307, 28);
            this.comboBoxEditora.TabIndex = 5;
            // 
            // comboBoxTipoPersonagem
            // 
            this.comboBoxTipoPersonagem.DisplayMember = "Tipo";
            this.comboBoxTipoPersonagem.FormattingEnabled = true;
            this.comboBoxTipoPersonagem.Location = new System.Drawing.Point(12, 139);
            this.comboBoxTipoPersonagem.Name = "comboBoxTipoPersonagem";
            this.comboBoxTipoPersonagem.Size = new System.Drawing.Size(307, 28);
            this.comboBoxTipoPersonagem.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(284, 198);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(184, 198);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // PersonagemCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 233);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxTipoPersonagem);
            this.Controls.Add(this.comboBoxEditora);
            this.Controls.Add(this.labelTipoPersonagem);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "PersonagemCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonagemCadastroEdicaoForm";
            this.Load += new System.EventHandler(this.PersonagemCadastroEdicaoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelEditora;
        private Label labelTipoPersonagem;
        private ComboBox comboBoxEditora;
        private ComboBox comboBoxTipoPersonagem;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}