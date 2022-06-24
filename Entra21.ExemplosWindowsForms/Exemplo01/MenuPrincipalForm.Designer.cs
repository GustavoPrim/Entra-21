namespace Entra21.ExemplosWindowsForms.Exemplo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonMenuEnderecos = new System.Windows.Forms.Button();
            this.buttonMenuPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMenuEnderecos
            // 
            this.buttonMenuEnderecos.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuEnderecos.Image")));
            this.buttonMenuEnderecos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuEnderecos.Location = new System.Drawing.Point(12, 12);
            this.buttonMenuEnderecos.Name = "buttonMenuEnderecos";
            this.buttonMenuEnderecos.Size = new System.Drawing.Size(330, 215);
            this.buttonMenuEnderecos.TabIndex = 0;
            this.buttonMenuEnderecos.Text = "Endereços";
            this.buttonMenuEnderecos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenuEnderecos.UseVisualStyleBackColor = true;
            this.buttonMenuEnderecos.Click += new System.EventHandler(this.buttonMenuEnderecos_Click);
            // 
            // buttonMenuPacientes
            // 
            this.buttonMenuPacientes.Image = global::Entra21.ExemplosWindowsForms.Properties.Resources.user;
            this.buttonMenuPacientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuPacientes.Location = new System.Drawing.Point(348, 12);
            this.buttonMenuPacientes.Name = "buttonMenuPacientes";
            this.buttonMenuPacientes.Size = new System.Drawing.Size(297, 215);
            this.buttonMenuPacientes.TabIndex = 1;
            this.buttonMenuPacientes.Text = "Pacientes";
            this.buttonMenuPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenuPacientes.UseVisualStyleBackColor = true;
            this.buttonMenuPacientes.Click += new System.EventHandler(this.buttonMenuPacientes_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 239);
            this.Controls.Add(this.buttonMenuPacientes);
            this.Controls.Add(this.buttonMenuEnderecos);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonMenuEnderecos;
        private Button buttonMenuPacientes;
    }
}