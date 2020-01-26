using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CamadaDados.DAL.Models;

namespace CamadaDados.DAL.Persistence
{
    public class CadastroMesasController : Conexao
    {
        public void Create( CadastroMesas cm)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Cadastro_Mesas VALUES (@v1, @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", cm.NumeroMesa);
                Cmd.Parameters.AddWithValue("@v2", cm.Observacoes);
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
