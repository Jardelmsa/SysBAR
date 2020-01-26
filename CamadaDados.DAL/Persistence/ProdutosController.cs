using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CamadaDados.DAL.Models;
using CamadaDados.DAL.Persistence;

namespace CamadaDados.DAL.Persistence
{
   public  class ProdutosController: Conexao
    {
        public void Create(Produtos p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Produtos VALUES (@v1, @v2, @v3, @v4, @v5, @v6)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Codigo);
                Cmd.Parameters.AddWithValue("@v2", p.Nome);
                Cmd.Parameters.AddWithValue("@v3", p.Categoria);
                Cmd.Parameters.AddWithValue("@v4", p.Preco);
                Cmd.Parameters.AddWithValue("@v5", p.Descricao);
                Cmd.Parameters.AddWithValue("@v6", p.Fabricante);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
