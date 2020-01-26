using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados.DAL.Models;
using CamadaDados.DAL.Persistence;
using System.Data.SqlClient;

namespace SysBAR
{
    public partial class frmCadastroMesas : Form
    {
        public frmCadastroMesas()
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
                Adpt = new SqlDataAdapter("SELECT * FROM Cadastro_Mesas", Con);
                Adpt.Fill(dt);
                dgvMesas.DataSource = dt;


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCadastroMesas_Load(object sender, EventArgs e)
        {
           
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvMesas.RowCount;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtNumeroDaMesa.Text = "";
            this.txtObservacoes.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Cadastro_Mesas WHERE numero_mesa= '" +txtNumeroDaMesa.Text + "'  ", Con);
                Dr = Cmd.ExecuteReader();
                if (Dr.Read())
                {
                    lblMensagem.Text = "Já existe um cadastro para o número da mesa em questão !.";
                }

               else  if(txtNumeroDaMesa.Text == "" )
                {
                    lblMensagem.Text = "Informe o número da Mesa !";
                }
                else
                { 
                    CadastroMesas cm = new CadastroMesas();
                    cm.NumeroMesa = Convert.ToInt32(txtNumeroDaMesa.Text);
                    cm.Observacoes = txtObservacoes.Text;
                    CadastroMesasController cmc = new CadastroMesasController();
                    cmc.Create(cm);

                    lblMensagem.Text = "Mesa Cadastrada com sucesso!";
                    CarregarGrid();
                    lblTotal.Text = "Total de Registros: " + dgvMesas.RowCount;

                    this.txtNumeroDaMesa.Text = "";
                    this.txtObservacoes.Text = "";
                    this.txtNumeroDaMesa.Focus();
                              
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPesquisar.Text == "")
                {
                    lblMensagem.Text = "Digite o número da Mesa !";
                }
                else
                {
                    AbrirConexao();
                    DataTable dt = new DataTable();
                    Adpt = new SqlDataAdapter("SELECT * FROM Cadastro_Mesas WHERE numero_mesa= '" +txtPesquisar.Text + "' ", Con);
                    Adpt.Fill(dt);
                    dgvMesas.DataSource = dt;
                    lblTotal.Text = "Total de Registros: " + dgvMesas.RowCount;    
                   
                }           
            }
            catch (Exception ex )
            {

                lblTotal.Text = ex.Message;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.txtPesquisar.Text = "";
            CarregarGrid();
            lblTotal.Text = "Total de Registros: " + dgvMesas.RowCount;
        }
    }
}
