namespace Emanuela3B
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NLivro = new System.Windows.Forms.Label();
            this.txbNomeLivro = new System.Windows.Forms.TextBox();
            this.TxbAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TAluguel = new System.Windows.Forms.Label();
            this.txbTempo = new System.Windows.Forms.TextBox();
            this.btncow = new System.Windows.Forms.Button();
            this.Npessoa = new System.Windows.Forms.Label();
            this.txbNpessoa = new System.Windows.Forms.TextBox();
            this.cpfpessoa = new System.Windows.Forms.Label();
            this.telefonepess = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbtelefone = new System.Windows.Forms.MaskedTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntedit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NLivro
            // 
            this.NLivro.AutoSize = true;
            this.NLivro.Location = new System.Drawing.Point(71, 9);
            this.NLivro.Name = "NLivro";
            this.NLivro.Size = new System.Drawing.Size(77, 13);
            this.NLivro.TabIndex = 1;
            this.NLivro.Text = " NOME LIVRO";
            this.NLivro.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNomeLivro
            // 
            this.txbNomeLivro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeLivro.Location = new System.Drawing.Point(69, 25);
            this.txbNomeLivro.Name = "txbNomeLivro";
            this.txbNomeLivro.Size = new System.Drawing.Size(163, 33);
            this.txbNomeLivro.TabIndex = 0;
            this.txbNomeLivro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxbAutor
            // 
            this.TxbAutor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbAutor.Location = new System.Drawing.Point(69, 88);
            this.TxbAutor.Name = "TxbAutor";
            this.TxbAutor.Size = new System.Drawing.Size(163, 33);
            this.TxbAutor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AUTOR";
            // 
            // TAluguel
            // 
            this.TAluguel.AutoSize = true;
            this.TAluguel.Location = new System.Drawing.Point(66, 141);
            this.TAluguel.Name = "TAluguel";
            this.TAluguel.Size = new System.Drawing.Size(45, 13);
            this.TAluguel.TabIndex = 5;
            this.TAluguel.Text = "TEMPO";
            this.TAluguel.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbTempo
            // 
            this.txbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTempo.Location = new System.Drawing.Point(69, 165);
            this.txbTempo.Name = "txbTempo";
            this.txbTempo.Size = new System.Drawing.Size(163, 29);
            this.txbTempo.TabIndex = 2;
            // 
            // btncow
            // 
            this.btncow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncow.Font = new System.Drawing.Font("Dutch801 XBd BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncow.ForeColor = System.Drawing.Color.Black;
            this.btncow.Image = ((System.Drawing.Image)(resources.GetObject("btncow.Image")));
            this.btncow.Location = new System.Drawing.Point(55, 339);
            this.btncow.Name = "btncow";
            this.btncow.Size = new System.Drawing.Size(356, 232);
            this.btncow.TabIndex = 6;
            this.btncow.Text = "\r\n\r\n\r\n\r\nCADASTRO";
            this.btncow.UseVisualStyleBackColor = false;
            this.btncow.Click += new System.EventHandler(this.button1_Click);
            // 
            // Npessoa
            // 
            this.Npessoa.AutoSize = true;
            this.Npessoa.Location = new System.Drawing.Point(361, 13);
            this.Npessoa.Name = "Npessoa";
            this.Npessoa.Size = new System.Drawing.Size(35, 13);
            this.Npessoa.TabIndex = 7;
            this.Npessoa.Text = "Nome";
            // 
            // txbNpessoa
            // 
            this.txbNpessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNpessoa.Location = new System.Drawing.Point(364, 29);
            this.txbNpessoa.Name = "txbNpessoa";
            this.txbNpessoa.Size = new System.Drawing.Size(163, 29);
            this.txbNpessoa.TabIndex = 3;
            this.txbNpessoa.TextChanged += new System.EventHandler(this.txbNpessoa_TextChanged);
            // 
            // cpfpessoa
            // 
            this.cpfpessoa.AutoSize = true;
            this.cpfpessoa.Location = new System.Drawing.Point(361, 75);
            this.cpfpessoa.Name = "cpfpessoa";
            this.cpfpessoa.Size = new System.Drawing.Size(27, 13);
            this.cpfpessoa.TabIndex = 9;
            this.cpfpessoa.Text = "CPF";
            // 
            // telefonepess
            // 
            this.telefonepess.AutoSize = true;
            this.telefonepess.Location = new System.Drawing.Point(361, 141);
            this.telefonepess.Name = "telefonepess";
            this.telefonepess.Size = new System.Drawing.Size(63, 13);
            this.telefonepess.TabIndex = 11;
            this.telefonepess.Text = "TELEFONE";
            // 
            // txbCPF
            // 
            this.txbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.Location = new System.Drawing.Point(364, 92);
            this.txbCPF.Mask = "000,000,000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(163, 29);
            this.txbCPF.TabIndex = 4;
            this.txbCPF.Leave += new System.EventHandler(this.txbCPF_Leave);
            // 
            // txbtelefone
            // 
            this.txbtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelefone.Location = new System.Drawing.Point(364, 165);
            this.txbtelefone.Mask = "(+55) 00000-0000";
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(163, 26);
            this.txbtelefone.TabIndex = 5;
            this.txbtelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbtelefone_MaskInputRejected);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(610, 13);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(503, 185);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NomedoLivro";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tempo";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cliente";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CPF";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telefone";
            // 
            // bntedit
            // 
            this.bntedit.BackColor = System.Drawing.Color.Salmon;
            this.bntedit.Font = new System.Drawing.Font("Dutch801 XBd BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntedit.ForeColor = System.Drawing.Color.Black;
            this.bntedit.Image = ((System.Drawing.Image)(resources.GetObject("bntedit.Image")));
            this.bntedit.Location = new System.Drawing.Point(827, 301);
            this.bntedit.Name = "bntedit";
            this.bntedit.Size = new System.Drawing.Size(320, 270);
            this.bntedit.TabIndex = 14;
            this.bntedit.Text = "\r\n\r\n\r\n\r\n\r\nEDITAR";
            this.bntedit.UseVisualStyleBackColor = false;
            this.bntedit.Click += new System.EventHandler(this.bntedit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Dutch801 XBd BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(431, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 355);
            this.button1.TabIndex = 15;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\nDELETAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1214, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntedit);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txbtelefone);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.telefonepess);
            this.Controls.Add(this.cpfpessoa);
            this.Controls.Add(this.txbNpessoa);
            this.Controls.Add(this.Npessoa);
            this.Controls.Add(this.txbTempo);
            this.Controls.Add(this.TAluguel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbAutor);
            this.Controls.Add(this.txbNomeLivro);
            this.Controls.Add(this.NLivro);
            this.Controls.Add(this.btncow);
            this.Name = "Form1";
            this.Text = "CADASTRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncow;
        private System.Windows.Forms.Label NLivro;
        private System.Windows.Forms.TextBox txbNomeLivro;
        private System.Windows.Forms.TextBox TxbAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TAluguel;
        private System.Windows.Forms.TextBox txbTempo;
        private System.Windows.Forms.Label Npessoa;
        private System.Windows.Forms.TextBox txbNpessoa;
        private System.Windows.Forms.Label cpfpessoa;
        private System.Windows.Forms.Label telefonepess;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.MaskedTextBox txbtelefone;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button bntedit;
        private System.Windows.Forms.Button button1;
    }
}

