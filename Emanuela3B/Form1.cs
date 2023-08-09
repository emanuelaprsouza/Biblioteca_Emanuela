using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emanuela3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = txbNome.Text;
            String enrollment = TxbPront.Text;

            String message = "Nome: " + nome +
                            "\nMatrícula: " + enrollment;

            MessageBox.Show(
                message,
                "ATENÇÃO",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information           
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
