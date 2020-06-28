using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DISKCACAMBA.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();
        // Método de Recuperação: Dados Clientes
        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes clientes = new MODEL.Clientes();
                    clientes.id = Convert.ToInt32(dados["id"].ToString());
                    clientes.nome = dados["nome"].ToString();
                    clientes.endereco = dados["endereco"].ToString();
                    clientes.telefone = dados["telefone"].ToString();
                    clientes.dias = Convert.ToInt32(dados["dias"].ToString());
                    clientes.multa = Convert.ToSingle(dados["multa"].ToString());

                    lstClientes.Add(clientes);
                }
            }
            catch{
                Console.WriteLine("Deu erro na consulta de Clientes");

            } 
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }
        //Método Insert dados: Clientes
        public void Insert(MODEL.Clientes clientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Clientes VALUES(@nome, @endereco, @telefone, @dias, @multa);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", clientes.nome);
            cmd.Parameters.AddWithValue("@endereco", clientes.endereco);
            cmd.Parameters.AddWithValue("@telefone", clientes.telefone);
            cmd.Parameters.AddWithValue("@dias", clientes.dias);
            cmd.Parameters.AddWithValue("@multa", clientes.multa);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("Erro na inserção de clientes"); 

            }
            finally
            {
                conexao.Close();
            }

        }

        //Método Update dados: Clientes
        public void Update(MODEL.Clientes clientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Clientes SET nome=@nome, endereco=@endereco, telefone=@telefone, dias=@dias, multa=@multa ";
            sql += " WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", clientes.id);
            cmd.Parameters.AddWithValue("@nome", clientes.nome);
            cmd.Parameters.AddWithValue("@endereco", clientes.endereco);
            cmd.Parameters.AddWithValue("@telefone", clientes.telefone);
            cmd.Parameters.AddWithValue("@dias", clientes.dias);
            cmd.Parameters.AddWithValue("@multa", clientes.multa);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("Erro na atualização de clientes");

            }
            finally
            {
                conexao.Close();
            }

        }
        public void Delete(int idClientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Clientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idClientes);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Erro remoção de clientes");        
            }
            
            finally
            {
                conexao.Close();
            }
        }

        public MODEL.Clientes SelectById(int id)
        {
            MODEL.Clientes clientes = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    clientes.id = Convert.ToInt32(dados["id"].ToString());
                    clientes.nome = dados["nome"].ToString();
                    clientes.endereco = dados["endereco"].ToString();
                    clientes.telefone = dados["telefone"].ToString();
                    clientes.dias = Convert.ToInt32(dados["dias"].ToString());
                    clientes.multa = Convert.ToSingle(dados["multa"].ToString());


                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes por ID");

            }
            finally
            {
                conexao.Close();
            }
            return clientes;
        }

    }
}
