using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CamadaDados.DAL.Models;
using CamadaDados.DAL.Persistence;

namespace SysBAR
{
    public partial class frmCadastroCategorias : Form
    {
        public frmCadastroCategorias()
        {
            InitializeComponent();
        }

        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter Adpt;
        SqlDataReader Dr;

        private void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=desktop-6nkvmju;Initial Catalog=SysBarDB;Integrated Security=True;");
                Con.Open();
            }
            catch (Exception ex )
            {

                throw new Exception(ex.Message);
            }
        }

        private void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                Adpt = new SqlDataAdapter("SELECT * FROM Categorias", Con);
                Adpt.Fill(dt);
                dgvCategorias.DataSource = dt;
            }
            catch (Exception ex )
            {

                lblTotal.Text = ex.Message;
            }
            finally
            {
                FecharConexao();
            }
        }

        private void frmCadastroCategorias_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvCategorias.RowCount;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPesquisar.Text == "")
                {
                    MessageBox.Show("Digite o nome da categoria...");
                    txtPesquisar.Focus();
                }
                else
                {
                    AbrirConexao();
                    DataTable dt = new DataTable();
                    Adpt = new SqlDataAdapter("SELECT * FROM Categorias WHERE nome= '" + txtPesquisar.Text.Trim() + "' ", Con);
                    Adpt.Fill(dt);
                    dgvCategorias.DataSource = dt;
                    lblTotal.Text = "Total de Registros: " + dgvCategorias.RowCount;
                }
            }
            catch (Exception ex)
            {

                lblTotal.Text = ex.Message;
            }
            finally
            {
                FecharConexao();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Categorias WHERE nome= '" + txtNome.Text.Trim() + "' ", Con);
                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    lblMensagem.Text = "Já constam registros para a categoria informada.";
                    FecharConexao();
                }
                else if (txtNome.Text == "")
                {
                    lblMensagem.Text = "Digite o nome da categoria!";
                }
                else
                {
                    Categorias c = new Categorias();
                    c.Nome = txtNome.Text.Trim();
                    c.Descricao = txtDescricao.Text;

                    CategoriasController cc = new CategoriasController();
                    cc.Create(c);

                    lblMensagem.Text = "Categoria Cadastrada com sucesso.";
                    CarregarGrid();
                    lblTotal.Text = "Total de Registros: " + dgvCategorias.RowCount;
                    this.txtNome.Text = "";
                    this.txtDescricao.Text = "";
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvCategorias.RowCount;
            this.txtNome.Text = "";
            this.txtDescricao.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvCategorias.RowCount;
            this.txtPesquisar.Text = "";
        }
    }
}
