using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DISKCACAMBA.CAMADAS.DAL
{
    public class Cacambas
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Cacambas> Select()
        {
            List<MODEL.Cacambas> lstcacambas = new List<MODEL.Cacambas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cacambas";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cacambas cacambas = new MODEL.Cacambas();
                    cacambas.id = Convert.ToInt32(dados["id"].ToString());
                    cacambas.tipo = dados["tipo"].ToString();
                    cacambas.tamanho = dados["tamanho"].ToString();
                    cacambas.valor = Convert.ToSingle(dados["valor"].ToString());
                    cacambas.situacao = Convert.ToInt32(dados["situacao"].ToString());
                    lstcacambas.Add(cacambas);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Consulta de Cacambas");
            }
            finally
            {
                conexao.Close();
            }

            return lstcacambas;
        }

        public void Insert(MODEL.Cacambas cacambas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Cacambas VALUES (@tipo, @tamanho, @valor, @situacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@tipo", cacambas.tipo);
            cmd.Parameters.AddWithValue("@tamanho", cacambas.tamanho);
            cmd.Parameters.AddWithValue("@valor", cacambas.valor);
            cmd.Parameters.AddWithValue("@situacao", cacambas.situacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Inclusão de Caçambas");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cacambas cacambas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Cacambas SET tipo=@tipo, tamanho=@tamanho, valor=@valor, situacao=@situacao ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue(@"id", cacambas.id);
            cmd.Parameters.AddWithValue("@tipo", cacambas.tipo);
            cmd.Parameters.AddWithValue("@tamanho", cacambas.tamanho);
            cmd.Parameters.AddWithValue("@valor", cacambas.valor);
            cmd.Parameters.AddWithValue("@situacao", cacambas.situacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Atualização de Caçambas");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete (int idCacambas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Cacambas WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCacambas);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Cacambas");
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}

