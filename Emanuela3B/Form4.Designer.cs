namespace Emanuela3B
{
    partial class Form4
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
            this.email = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.rua = new System.Windows.Forms.Label();
            this.txbrua = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.Label();
            this.txbbairro = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(29, 25);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(43, 15);
            this.email.TabIndex = 0;
            this.email.Text = "EMAIL";
            // 
            // txbemail
            // 
            this.txbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemail.Location = new System.Drawing.Point(32, 43);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(162, 24);
            this.txbemail.TabIndex = 1;
            // 
            // rua
            // 
            this.rua.AutoSize = true;
            this.rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rua.Location = new System.Drawing.Point(29, 83);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(32, 15);
            this.rua.TabIndex = 2;
            this.rua.Text = "RUA";
            // 
            // txbrua
            // 
            this.txbrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbrua.Location = new System.Drawing.Point(32, 101);
            this.txbrua.Name = "txbrua";
            this.txbrua.Size = new System.Drawing.Size(162, 24);
            this.txbrua.TabIndex = 3;
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(32, 143);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(52, 15);
            this.bairro.TabIndex = 4;
            this.bairro.Text = "BAIRRO";
            // 
            // txbbairro
            // 
            this.txbbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbbairro.Location = new System.Drawing.Point(32, 162);
            this.txbbairro.Name = "txbbairro";
            this.txbbairro.Size = new System.Drawing.Size(162, 24);
            this.txbbairro.TabIndex = 5;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(29, 212);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(62, 15);
            this.num.TabIndex = 6;
            this.num.Text = "NÚMERO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 24);
            this.textBox1.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 665);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.txbbairro);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.txbrua);
            this.Controls.Add(this.rua);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.email);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label rua;
        private System.Windows.Forms.TextBox txbrua;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.TextBox txbbairro;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.TextBox textBox1;
    }
}