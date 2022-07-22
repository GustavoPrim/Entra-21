namespace Entra21.BancoDados01.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonPersonagens = new System.Windows.Forms.Button();
            this.buttonTiposPersonagens = new System.Windows.Forms.Button();
            this.buttonEditoras = new System.Windows.Forms.Button();
            this.buttonCidades = new System.Windows.Forms.Button();
            this.buttonUnidadesFederativas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPersonagens.Location = new System.Drawing.Point(139, 9);
            this.buttonPersonagens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(123, 148);
            this.buttonPersonagens.TabIndex = 0;
            this.buttonPersonagens.Text = "Personagens";
            this.buttonPersonagens.UseVisualStyleBackColor = false;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTiposPersonagens
            // 
            this.buttonTiposPersonagens.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonTiposPersonagens.Location = new System.Drawing.Point(268, 9);
            this.buttonTiposPersonagens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTiposPersonagens.Name = "buttonTiposPersonagens";
            this.buttonTiposPersonagens.Size = new System.Drawing.Size(123, 148);
            this.buttonTiposPersonagens.TabIndex = 1;
            this.buttonTiposPersonagens.Text = "Tipos de Personagens";
            this.buttonTiposPersonagens.UseVisualStyleBackColor = false;
            this.buttonTiposPersonagens.Click += new System.EventHandler(this.buttonTiposPersonagens_Click);
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEditoras.Location = new System.Drawing.Point(10, 9);
            this.buttonEditoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(123, 148);
            this.buttonEditoras.TabIndex = 2;
            this.buttonEditoras.Text = "Editoras";
            this.buttonEditoras.UseVisualStyleBackColor = false;
            // 
            // buttonCidades
            // 
            this.buttonCidades.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCidades.Location = new System.Drawing.Point(527, 9);
            this.buttonCidades.Name = "buttonCidades";
            this.buttonCidades.Size = new System.Drawing.Size(123, 148);
            this.buttonCidades.TabIndex = 3;
            this.buttonCidades.Text = "Cidades";
            this.buttonCidades.UseVisualStyleBackColor = false;
            this.buttonCidades.Click += new System.EventHandler(this.buttonCidades_Click);
            // 
            // buttonUnidadesFederativas
            // 
            this.buttonUnidadesFederativas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUnidadesFederativas.Location = new System.Drawing.Point(397, 9);
            this.buttonUnidadesFederativas.Name = "buttonUnidadesFederativas";
            this.buttonUnidadesFederativas.Size = new System.Drawing.Size(124, 148);
            this.buttonUnidadesFederativas.TabIndex = 4;
            this.buttonUnidadesFederativas.Text = "Unidades Federativas";
            this.buttonUnidadesFederativas.UseVisualStyleBackColor = false;
            this.buttonUnidadesFederativas.Click += new System.EventHandler(this.buttonUnidadesFederativas_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(653, 166);
            this.Controls.Add(this.buttonUnidadesFederativas);
            this.Controls.Add(this.buttonCidades);
            this.Controls.Add(this.buttonEditoras);
            this.Controls.Add(this.buttonTiposPersonagens);
            this.Controls.Add(this.buttonPersonagens);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPersonagens;
        private Button buttonTiposPersonagens;
        private Button buttonEditoras;
        private Button buttonCidades;
        private Button buttonUnidadesFederativas;
    }
}