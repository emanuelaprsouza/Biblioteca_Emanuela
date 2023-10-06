using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emanuela3B
{
    public partial class Form1 : Form
    {

        private int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()  
        {
            listView2.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM emprestimo";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string Livro = (string)dr["NomedoLivro"];
                    string Autor = (string)dr["Autor"];
                    string Tempo = (string)dr["Tempo"];
                    string Nome = (string)dr["Nome"];
                    string CPF = (string)dr["CPF"];  
                    string Tel = (string)dr["Telefone"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(Livro);
                    lv.SubItems.Add(Autor);
                    lv.SubItems.Add(Tempo);
                    lv.SubItems.Add(Nome);
                    lv.SubItems.Add(CPF); 
                    lv.SubItems.Add(Tel);
                    listView2.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
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
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO emprestimo VALUES (@Livro, @Autor, @Tempo, @Nome, @CPF, @telefone)";

            sqlCommand.Parameters.AddWithValue("@Livro", txbNomeLivro.Text);
            sqlCommand.Parameters.AddWithValue("@Autor", TxbAutor.Text);
            sqlCommand.Parameters.AddWithValue("@Tempo", txbTempo.Text);
            sqlCommand.Parameters.AddWithValue("@Nome", txbNpessoa.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", txbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbtelefone.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "BIBLIOTECA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                 txbNomeLivro.Clear();
                 txbNpessoa.Clear();
                 txbtelefone.Clear();
                 txbTempo.Clear();
                 TxbAutor.Clear();
                 txbCPF.Clear();

            UpdateListView();
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
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE emprestimo SET 
             NomedoLivro = @Livro,
             Autor    = @Autor,
             Tempo    = @Tempo, 
             Nome     = @Nome,
             CPF      = @CPF,
             telefone = @telefone
             WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@Livro", txbNomeLivro.Text);
            sqlCommand.Parameters.AddWithValue("@Autor", TxbAutor.Text);
            sqlCommand.Parameters.AddWithValue("@Tempo", txbTempo.Text);
            sqlCommand.Parameters.AddWithValue("@Nome", txbNpessoa.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", txbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbtelefone.Text);
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Editado com sucesso",
                "BIBLIOTECA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNomeLivro.Clear();
            txbNpessoa.Clear();
            txbtelefone.Clear();
            txbTempo.Clear();
            TxbAutor.Clear();
            txbCPF.Clear();

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

                UpdateListView();

            MessageBox.Show("Deletado com sucesso",
               "BIBLIOTECA",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            


        }
    }
}
