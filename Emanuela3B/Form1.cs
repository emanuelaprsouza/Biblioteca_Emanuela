using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emanuela3B
{
    public partial class Form1 : Form
    {

        private int id;
        public Form1(int controle)
        {
            InitializeComponent();

            if (controle == 2)
            {
                listView2.Visible = false;
                button1.Visible = false;
                bntedit.Visible = false;
            }

        }


        private void UpdateListView()
        {
            listView2.Items.Clear();

            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = clienteDAO.SelectCliente();

            try
            {
                foreach (Cliente cliente in clientes)
                {

                    ListViewItem lv = new ListViewItem(cliente.id.ToString());
                    lv.SubItems.Add(cliente.NomeLivro);
                    lv.SubItems.Add(cliente.Autor);
                    lv.SubItems.Add(cliente.Tempo);
                    lv.SubItems.Add(cliente.Npessoa);
                    lv.SubItems.Add(cliente.CPF);
                    lv.SubItems.Add(cliente.telefone);
                    lv.SubItems.Add(cliente.senha);
                    listView2.Items.Add(lv);
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }




        private bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //criar objeto da classe user
                Cliente cliente = new Cliente(txbNomeLivro.Text,
                                              TxbAutor.Text,
                                              txbTempo.Text,
                                              txbNpessoa.Text,
                                              txbCPF.Text,
                                              txbtelefone.Text,
                                              Class1.CalculateMD5Hash(txbsenha.Text)
                                              );
                //chamar metodo de exclusão
                ClienteDAO clidados = new ClienteDAO();
                clidados.InsertCliente(cliente);

                MessageBox.Show("Cadastrado com sucesso",
                    "BIBLIOTECA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbNomeLivro.Clear();
            txbNpessoa.Clear();
            txbtelefone.Clear();
            txbTempo.Clear();
            TxbAutor.Clear();
            txbCPF.Clear();
            txbsenha.Clear();

            UpdateListView();
        }

        public static bool IsValidBrazilianPhoneNumber(string phoneNumber)
        {
            // Formato do telefone brasileiro: (99) 9999-9999
            string pattern = @"^\(\d{2}\)\s?\d{4}-\d{4}$";

            // Remove os caracteres especiais do telefone antes de verificar
            phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

            // Verifica se o telefone possui 10 dígitos
            if (phoneNumber.Length != 10)
            {
                return false;
            }

            // Verifica se o telefone segue o padrão (99) 9999-9999
            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return true;
            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbCPF_Leave(object sender, EventArgs e)
        {
            if (!IsCpf(txbCPF.Text))
            {
                MessageBox.Show("CPF Inválido");
                txbCPF.Focus();
            }
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntedit_Click(object sender, EventArgs e)
        {
            try
            {

                //criar objeto da classe user
                Cliente cliente = new Cliente(txbNomeLivro.Text,
                                              TxbAutor.Text,
                                              txbTempo.Text,
                                              txbNpessoa.Text,
                                              txbCPF.Text,
                                              txbtelefone.Text,
                                               Class1.CalculateMD5Hash(txbsenha.Text)
                                              );
                //chamar metodo de exclusão
                ClienteDAO clidados = new ClienteDAO();
                clidados.InsertCliente(cliente);

                MessageBox.Show("Editado com sucesso",
               "BIBLIOTECA",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            txbNomeLivro.Clear();
            txbNpessoa.Clear();
            txbtelefone.Clear();
            txbTempo.Clear();
            TxbAutor.Clear();
            txbCPF.Clear();
            txbsenha.Clear();

            UpdateListView();
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index; //guardar variavel do indice que foi clicado 
            index = listView2.FocusedItem.Index;
            id = int.Parse(listView2.Items[index].SubItems[0].Text);
            txbNomeLivro.Text = listView2.Items[index].SubItems[1].Text;
            TxbAutor.Text = listView2.Items[index].SubItems[2].Text;
            txbTempo.Text = listView2.Items[index].SubItems[3].Text;
            txbNpessoa.Text = listView2.Items[index].SubItems[4].Text;
            txbCPF.Text = listView2.Items[index].SubItems[5].Text;
            txbtelefone.Text = listView2.Items[index].SubItems[6].Text;
            txbsenha.Text = listView2.Items[index].SubItems[7].Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //chamar metodo de exclusão
            ClienteDAO clidados = new ClienteDAO();
            clidados.DeleteCliente(id);

            txbNomeLivro.Clear();
            txbNpessoa.Clear();
            txbtelefone.Clear();
            txbTempo.Clear();
            TxbAutor.Clear();
            txbCPF.Clear();
            txbsenha.Clear();

            UpdateListView();

            MessageBox.Show("Deletado com sucesso",
               "BIBLIOTECA",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);



        }

        private void txbtelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!IsValidBrazilianPhoneNumber(txbtelefone.Text))
            {
                MessageBox.Show("Telefone Inválido");
                txbtelefone.Focus();
            }
        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxbAutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
