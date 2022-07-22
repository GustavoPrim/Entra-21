namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaCadastroEdicaoForm
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
            this.labelNomeUf = new System.Windows.Forms.Label();
            this.textBoxNomeUf = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelSiglaUf = new System.Windows.Forms.Label();
            this.textBoxSiglaUf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNomeUf
            // 
            this.labelNomeUf.AutoSize = true;
            this.labelNomeUf.Location = new System.Drawing.Point(12, 9);
            this.labelNomeUf.Name = "labelNomeUf";
            this.labelNomeUf.Size = new System.Drawing.Size(40, 15);
            this.labelNomeUf.TabIndex = 0;
            this.labelNomeUf.Text = "Nome";
            // 
            // textBoxNomeUf
            // 
            this.textBoxNomeUf.Location = new System.Drawing.Point(12, 27);
            this.textBoxNomeUf.Name = "textBoxNomeUf";
            this.textBoxNomeUf.Size = new System.Drawing.Size(195, 23);
            this.textBoxNomeUf.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(167, 56);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 34);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(248, 56);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 34);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // labelSiglaUf
            // 
            this.labelSiglaUf.AutoSize = true;
            this.labelSiglaUf.Location = new System.Drawing.Point(260, 9);
            this.labelSiglaUf.Name = "labelSiglaUf";
            this.labelSiglaUf.Size = new System.Drawing.Size(32, 15);
            this.labelSiglaUf.TabIndex = 4;
            this.labelSiglaUf.Text = "Sigla";
            // 
            // textBoxSiglaUf
            // 
            this.textBoxSiglaUf.Location = new System.Drawing.Point(248, 27);
            this.textBoxSiglaUf.Name = "textBoxSiglaUf";
            this.textBoxSiglaUf.Size = new System.Drawing.Size(54, 23);
            this.textBoxSiglaUf.TabIndex = 5;
            // 
            // UnidadeFederativaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 91);
            this.Controls.Add(this.textBoxSiglaUf);
            this.Controls.Add(this.labelSiglaUf);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNomeUf);
            this.Controls.Add(this.labelNomeUf);
            this.Name = "UnidadeFederativaCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UF Cadastro e Edição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNomeUf;
        private TextBox textBoxNomeUf;
        private Button buttonCancelar;
        private Button buttonCadastrar;
        private Label labelSiglaUf;
        private TextBox textBoxSiglaUf;
    }
}