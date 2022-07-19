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
            this.SuspendLayout();
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.Location = new System.Drawing.Point(159, 12);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(141, 197);
            this.buttonPersonagens.TabIndex = 0;
            this.buttonPersonagens.Text = "Personagens";
            this.buttonPersonagens.UseVisualStyleBackColor = true;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTiposPersonagens
            // 
            this.buttonTiposPersonagens.Location = new System.Drawing.Point(306, 12);
            this.buttonTiposPersonagens.Name = "buttonTiposPersonagens";
            this.buttonTiposPersonagens.Size = new System.Drawing.Size(141, 197);
            this.buttonTiposPersonagens.TabIndex = 1;
            this.buttonTiposPersonagens.Text = "Tipos de Personagens";
            this.buttonTiposPersonagens.UseVisualStyleBackColor = true;
            this.buttonTiposPersonagens.Click += new System.EventHandler(this.buttonTiposPersonagens_Click);
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.Location = new System.Drawing.Point(12, 12);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(141, 197);
            this.buttonEditoras.TabIndex = 2;
            this.buttonEditoras.Text = "Editoras";
            this.buttonEditoras.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 221);
            this.Controls.Add(this.buttonEditoras);
            this.Controls.Add(this.buttonTiposPersonagens);
            this.Controls.Add(this.buttonPersonagens);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPersonagens;
        private Button buttonTiposPersonagens;
        private Button buttonEditoras;
    }
}