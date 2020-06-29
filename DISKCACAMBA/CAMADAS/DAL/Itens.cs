using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISKCACAMBA.CAMADAS.DAL
{
    public class Itens
    {
        private string strCon = CAMADAS.DAL.Conexao.getConexao();

        //Método para recuperar Dados da Tabela de Itens
        public List<MODEL.Itens> Select()
        {
            List<MODEL.Itens> lstItens = new List<MODEL.Itens>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Itens;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    //preencher com dados do item
                    CAMADAS.MODEL.Itens item = new MODEL.Itens();
                    

                    item.id = Convert.ToInt32(dados["id"].ToString());
                    item.aluguel_id = Convert.ToInt32(dados["aluguel_id"].ToString());
                    item.cacambas_id = Convert.ToInt32(dados["cacambas_id"].ToString());
                    item.entrega = Convert.ToDateTime(dados["entrega"].ToString());

                    //recuperar tipo da Caçamba
                    CAMADAS.BLL.Cacambas bllCacambas = new BLL.Cacambas();
                    List<MODEL.Cacambas> listaCacambas = bllCacambas.SelectByID(item.cacambas_id);
                    item.tipo = listaCacambas[0].tipo;

                    lstItens.Add(item);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Itens...");
            }
            finally
            {
                conexao.Close();
            }

            return lstItens;
        }

        public List<MODEL.Itens> SelectByAlu(int id)
        {
            List<MODEL.Itens> lstItens = new List<MODEL.Itens>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Itens WHERE aluguel_id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    //preencher com dados do item
                    CAMADAS.MODEL.Itens item = new MODEL.Itens();
                    item.id = Convert.ToInt32(dados["id"].ToString());
                    item.aluguel_id = Convert.ToInt32(dados["aluguel_id"].ToString());
                    item.cacambas_id = Convert.ToInt32(dados["cacambas_id"].ToString());
                    item.entrega = Convert.ToDateTime(dados["entrega"].ToString());

                    //recuperar nome do livro
                    CAMADAS.BLL.Cacambas bllCacambas = new BLL.Cacambas();
                    List<MODEL.Cacambas> listaCacambas = bllCacambas.SelectByID(item.cacambas_id);
                    item.tipo = listaCacambas[0].tipo;

                    lstItens.Add(item);

                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Itens...");
            }
            finally
            {
                conexao.Close();
            }

            return lstItens;
        }

        //Método para Inserir dados na tabela de Itens
        public void Insert(MODEL.Itens item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Itens VALUES (@aluguel_id, @cacambas_id, @entrega);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@aluguel_id", item.aluguel_id);
            cmd.Parameters.AddWithValue("@cacambas_id", item.cacambas_id);
            cmd.Parameters.AddWithValue("@entrega", item.entrega);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Aluguel...");
            }
            finally
            {
                conexao.Close();
            }
        }

        //Método para Atualizar dados na tabela de itens
        public void Update(MODEL.Itens item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Itens SET aluguel_id=@aluguel_id, cacambas_id=@cacambas_id, entrega=@entrega  ";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", item.id);
            cmd.Parameters.AddWithValue("@aluguel_id", item.aluguel_id);
            cmd.Parameters.AddWithValue("@cacambas_id", item.cacambas_id);
            cmd.Parameters.AddWithValue("@entrega", item.entrega);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Itens...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Itens WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Itens...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
