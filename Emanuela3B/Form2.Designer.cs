namespace Emanuela3B
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.cliente = new System.Windows.Forms.Label();
            this.txbcliente = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            this.txbcadastro = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(461, 252);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(96, 24);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "CLIENTE";
            this.cliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbcliente
            // 
            this.txbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcliente.Location = new System.Drawing.Point(437, 321);
            this.txbcliente.Name = "txbcliente";
            this.txbcliente.Size = new System.Drawing.Size(156, 26);
            this.txbcliente.TabIndex = 1;
            // 
            // txbsenha
            // 
            this.txbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsenha.Location = new System.Drawing.Point(437, 453);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(156, 29);
            this.txbsenha.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(460, 397);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(89, 25);
            this.senha.TabIndex = 3;
            this.senha.Text = "SENHA";
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(326, 539);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(168, 66);
            this.limpar.TabIndex = 4;
            this.limpar.Text = "LIMPAR";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.Color.Black;
            this.entrar.Location = new System.Drawing.Point(677, 539);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(178, 66);
            this.entrar.TabIndex = 5;
            this.entrar.Text = "ENTRAR";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // txbcadastro
            // 
            this.txbcadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcadastro.Location = new System.Drawing.Point(731, 162);
            this.txbcadastro.Name = "txbcadastro";
            this.txbcadastro.Size = new System.Drawing.Size(184, 47);
            this.txbcadastro.TabIndex = 6;
            this.txbcadastro.Text = "CRIAR CONTA";
            this.txbcadastro.UseVisualStyleBackColor = false;
            this.txbcadastro.Click += new System.EventHandler(this.txbcadastro_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(650, 299);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1207, 859);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txbcadastro);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbcliente);
            this.Controls.Add(this.cliente);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.TextBox txbcliente;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button txbcadastro;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}