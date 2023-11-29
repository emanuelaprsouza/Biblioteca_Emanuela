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
        public bool LoginCliente(string Cliente, string senha )
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM emprestimo WHERE " + " Nome = @Cliente AND senha = @senha ";

            sqlCom.Parameters.AddWithValue("@Cliente",Cliente);
            sqlCom.Parameters.AddWithValue("@senha", senha);

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.HasRows) 
                {
                    dr.Close();
                    return true;
                }

                dr.Close();
                return false;

            }
            catch (Exception err)
            {
               throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
           
        }

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

                   (int)dr["id"],                  
                   (string)dr["Nome"],
                   (string)dr["CPF"],
                   (string)dr["telefone"],
                   (string)dr["senha"]
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
             Nome     = @Nome,
             CPF      = @CPF,
             telefone = @telefone,
             senha    = @senha
             WHERE id = @id";

           
            sqlCommand.Parameters.AddWithValue("@Nome", cliente.Npessoa);
            sqlCommand.Parameters.AddWithValue("@CPF", cliente.CPF); 
            sqlCommand.Parameters.AddWithValue("@telefone", cliente.telefone);
            sqlCommand.Parameters.AddWithValue("@senha", cliente.senha);
            sqlCommand.Parameters.AddWithValue("@id", cliente.id);

            sqlCommand.ExecuteNonQuery();
        }
         
        public void InsertCliente(Cliente cliente)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO emprestimo VALUES ( @Nome, @CPF, @telefone, @senha)";

          
            sqlCommand.Parameters.AddWithValue("@Nome", cliente.Npessoa); 
            sqlCommand.Parameters.AddWithValue("@CPF", cliente.CPF);
            sqlCommand.Parameters.AddWithValue("@telefone", cliente.telefone);
            sqlCommand.Parameters.AddWithValue("@senha", cliente.senha);

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
