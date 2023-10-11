using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emanuela3B
{
    internal class ClienteDAO
    {
        public List<Cliente> SelectCliente()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM emprestimo";

            List < Cliente > clientes = new List<Cliente>();

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Cliente objeto = new Cliente(

                   (int)dr["Id"],
                   (string)dr["NomedoLivro"],
                   (string)dr["Autor"],
                   (string)dr["Tempo"],
                   (string)dr["Nome"],
                   (string)dr["CPF"],
                   (string)dr["Telefone"]
                   );

                    clientes.Add(objeto);

                }
                dr.Close();

                return clientes;//retornar a lista 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }

        public void UpdateCliente(Cliente cliente)
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

            sqlCommand.Parameters.AddWithValue("@Livro", cliente.NomeLivro);
            sqlCommand.Parameters.AddWithValue("@Autor", cliente.Autor);
            sqlCommand.Parameters.AddWithValue("@Tempo", cliente.Tempo);
            sqlCommand.Parameters.AddWithValue("@Nome", cliente.Npessoa);
            sqlCommand.Parameters.AddWithValue("@CPF", cliente.CPF); ;
            sqlCommand.Parameters.AddWithValue("@telefone", cliente.telefone);
            sqlCommand.Parameters.AddWithValue("@id", cliente.id);

            sqlCommand.ExecuteNonQuery();
        }

        public void InsertCliente(Cliente cliente)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO emprestimo VALUES (@Livro, @Autor, @Tempo, @Nome, @CPF, @telefone)";

            sqlCommand.Parameters.AddWithValue("@Livro", cliente.NomeLivro);
            sqlCommand.Parameters.AddWithValue("@Autor", cliente.Autor);
            sqlCommand.Parameters.AddWithValue("@Tempo", cliente.Tempo);
            sqlCommand.Parameters.AddWithValue("@Nome", cliente.Npessoa); 
            sqlCommand.Parameters.AddWithValue("@CPF", cliente.CPF);
            sqlCommand.Parameters.AddWithValue("@telefone", cliente.telefone);

            sqlCommand.ExecuteNonQuery();

        }

        //metodos para o CRUD
        public void DeleteCliente(int id)
       {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM emprestimo WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
        
            }
       }
    }
}
