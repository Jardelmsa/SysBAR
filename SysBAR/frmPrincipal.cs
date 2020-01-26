using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysBAR
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private Form _obj;
        private void cadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmCadastroMesas
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            pnlPrincipal.Controls.Add(_obj);
            _obj.Show();
        }

        private void cadastroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmCadastroCategorias
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            pnlPrincipal.Controls.Add(_obj);
            _obj.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmCadastroProdutos
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            pnlPrincipal.Controls.Add(_obj);
            _obj.Show();
        }
    }
}
