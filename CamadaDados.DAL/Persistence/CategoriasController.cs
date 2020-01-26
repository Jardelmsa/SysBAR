using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.DAL.Models;
using System.Data.SqlClient;
namespace CamadaDados.DAL.Persistence
{
  public  class CategoriasController : Conexao
    {
        public void Create(Categorias c)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Categorias VALUES (@v1, @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", c.Nome);
                Cmd.Parameters.AddWithValue("@v2", c.Descricao);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex )
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
