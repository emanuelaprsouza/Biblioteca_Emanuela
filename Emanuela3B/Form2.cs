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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
                           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txbcadastro_Click(object sender, EventArgs e)
        {
            //se passar 1 gestão total , 2 apenas cadastro 
            Form1 form1 = new Form1(2);
            form1.ShowDialog();

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string Cliente = txbcliente.Text;
            string senha = Class1.CalculateMD5Hash(txbsenha.Text);

            ClienteDAO clienteDAO = new ClienteDAO();

            if (clienteDAO.LoginCliente(Cliente, senha))
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique os dados inseridos!",
                                "ERROU",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
