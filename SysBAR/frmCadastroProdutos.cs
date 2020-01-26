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
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
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
            catch (Exception ex)
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
                Adpt = new SqlDataAdapter("SELECT  TOP 100 * FROM Produtos", Con);
                Adpt.Fill(dt);
                dgvProdutos.DataSource = dt;
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

        private void CarregarCategorias()
        {
            try
            {
                AbrirConexao();
                DataSet ds = new DataSet();
                Adpt = new SqlDataAdapter("SELECT * FROM Categorias", Con);
                Adpt.Fill(ds);
                cbxCategoria.DataSource = ds.Tables[0];
                cbxCategoria.DisplayMember = "nome";
                cbxCategoria.ValueMember = "nome";
                FecharConexao();

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT  * FROM Produtos WHERE nome= '" + txtNome.Text + "' OR codigo= '" + txtCodigo.Text + "' ", Con);
                Dr = Cmd.ExecuteReader();
                

                if (Dr.Read())
                {
                    lblMensagem.Text = "O Código do Produto ou o nome já são cadastrados!";
                  
                }
                else
                {
                    if(txtCodigo.Text=="" || txtNome.Text =="" || txtPreco.Text=="" || cbxCategoria.Text == "")
                    {
                        lblMensagem.Text = "Preencha todos os campos que são obrigatórios";
                    }
                    else
                    {
                        Produtos p = new Produtos();
                        p.Codigo = txtCodigo.Text;
                        p.Nome = txtNome.Text;
                        p.Categoria = cbxCategoria.Text;
                        p.Preco = Convert.ToDecimal(txtPreco.Text);
                        p.Descricao = txtDescricao.Text;
                        p.Fabricante = txtFabricante.Text;

                        ProdutosController pc = new ProdutosController();
                        pc.Create(p);

                        lblMensagem.Text = "Cadastro Realizado com sucesso!";
                        this.txtCodigo.Text = "";
                        this.txtNome.Text = "";
                        this.cbxCategoria.Text = "";
                        this.txtPreco.Text = "";
                        this.txtDescricao.Text = "";
                        this.txtFabricante.Text = "";

                        CarregarGrid();
                        lblTotal.Text = "Total de Registros: " + dgvProdutos.RowCount;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvProdutos.RowCount;
            CarregarCategorias();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    MessageBox.Show("Digite o nome do Produto!");
                }
                else
                {
                    AbrirConexao();
                    DataTable dt = new DataTable();
                    Adpt = new SqlDataAdapter("SELECT * FROM Produtos WHERE nome= '" + txtBuscar.Text + "' ", Con);
                    Adpt.Fill(dt);
                    dgvProdutos.DataSource = dt;
                    FecharConexao();
                    lblTotal.Text = "Total de Registros: " + dgvProdutos.RowCount;
                }
            }
            catch (Exception ex)
            {

                lblTotal.Text = ex.Message ;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvProdutos.RowCount;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = "";
            this.txtNome.Text = "";
            this.cbxCategoria.Text = "";
            this.txtPreco.Text = "";
            this.txtDescricao.Text = "";
            this.txtFabricante.Text = "";

            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvProdutos.RowCount;
        }
    }
}
