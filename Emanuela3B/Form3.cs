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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(3);
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            Form6 form6 = new Form6();
            form6.Show();
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
