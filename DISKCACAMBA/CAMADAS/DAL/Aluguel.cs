using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISKCACAMBA.CAMADAS.DAL
{
    public class Aluguel
    {
        private string strCon = CAMADAS.DAL.Conexao.getConexao();
        // Método de Recuperação: Dados Aluguel
        public List<MODEL.Aluguel> Select()
        {
            List<MODEL.Aluguel> lstAluguel = new List<MODEL.Aluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Aluguel;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    //dados do emprestimo
                    CAMADAS.MODEL.Aluguel aluguel = new MODEL.Aluguel();
                    aluguel.id = Convert.ToInt32(dados["id"].ToString());
                    aluguel.cliente_id = Convert.ToInt32(dados["clientes_id"].ToString());
                    aluguel.date = Convert.ToDateTime(dados["data"].ToString());
                    //recuperar nome do cliente
                    CAMADAS.DAL.Clientes dalCli = new Clientes();
                    CAMADAS.MODEL.Clientes Clientes = dalCli.SelectById(aluguel.cliente_id);
                    aluguel.nomeCli = Clientes.nome;
                    lstAluguel.Add(aluguel);

                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Alugueis");

            }
            finally
            {
                conexao.Close();
            }
            return lstAluguel;
        }
        //Método Insert dados: Aluguel

        public List<MODEL.Aluguel> SelectByID(int id)
        {
            List<MODEL.Aluguel> lstAluguel = new List<MODEL.Aluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Aluguel WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    //dados do emprestimo
                    CAMADAS.MODEL.Aluguel aluguel = new MODEL.Aluguel();
                    aluguel.id = Convert.ToInt32(dados["id"].ToString());
                    aluguel.cliente_id = Convert.ToInt32(dados["clientes_id"].ToString());
                    aluguel.date = Convert.ToDateTime(dados["data"].ToString());
                    //recuperar nome do cliente
                    CAMADAS.DAL.Clientes dalCli = new Clientes();
                    CAMADAS.MODEL.Clientes Clientes = dalCli.SelectById(aluguel.cliente_id);
                    aluguel.nomeCli = Clientes.nome;
                    lstAluguel.Add(aluguel);

                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta ID de Alugueis");

            }
            finally
            {
                conexao.Close();
            }
            return lstAluguel;
        }
        public void Insert(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Aluguel VALUES(@clientes_id, @data);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@clientes_id", aluguel.cliente_id);
            cmd.Parameters.AddWithValue("@data", aluguel.date);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("Erro na inserção de Aluguel");

            }
            finally
            {
                conexao.Close();
            }

        }

        //Método Update dados: Aluguel
        public void Update(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Aluguel SET clientes_id=@clientes_id, data=@dataID ";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", aluguel.id);
            cmd.Parameters.AddWithValue("@clientes_id", aluguel.cliente_id);
            cmd.Parameters.AddWithValue("@data", aluguel.date);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("Erro na atualização de Alugueis");

            }
            finally
            {
                conexao.Close();
            }

        }
        public void Delete(int idAluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Aluguel WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAluguel);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção do Aluguel");
            }

            finally
            {
                conexao.Close();
            }
        }

    }
}
