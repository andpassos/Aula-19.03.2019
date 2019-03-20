namespace Cadastros
{
    partial class Menu
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Cadastros.Properties.Resources.iconfinder__signout_common_door_exit_logout_out_4247897;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(178, 247);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 45);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Cadastros.Properties.Resources.iconfinder_ic_work_48px_352228;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(178, 61);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(90, 45);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFuncinario
            // 
            this.btnFuncinario.Image = global::Cadastros.Properties.Resources.iconfinder_icon_ios7_people_211793;
            this.btnFuncinario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncinario.Location = new System.Drawing.Point(25, 61);
            this.btnFuncinario.Name = "btnFuncinario";
            this.btnFuncinario.Size = new System.Drawing.Size(90, 45);
            this.btnFuncinario.TabIndex = 0;
            this.btnFuncinario.Text = "Funcinários";
            this.btnFuncinario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncinario.UseVisualStyleBackColor = true;
            this.btnFuncinario.Click += new System.EventHandler(this.btnFuncinario_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 304);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnFuncinario);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncinario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSair;
    }
}