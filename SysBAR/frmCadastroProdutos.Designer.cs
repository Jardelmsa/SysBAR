namespace SysBAR
{
    partial class frmCadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 376);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dgvProdutos);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMensagem);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnCadastrar);
            this.tabPage2.Controls.Add(this.txtDescricao);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtFabricante);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPreco);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbxCategoria);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(189, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(36, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 25);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(198, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 25);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecione a categoria:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(433, 72);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(177, 25);
            this.cbxCategoria.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(36, 122);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(164, 25);
            this.txtPreco.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preço:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(206, 122);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(404, 25);
            this.txtFabricante.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fabricante:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(36, 171);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(574, 71);
            this.txtDescricao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descricao do Produto:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(229, 294);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 28);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(339, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 28);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensagem.Location = new System.Drawing.Point(70, 249);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 15;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(365, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 28);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 84);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 25);
            this.txtBuscar.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Digite o nome do produto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(218, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Consultar Produtos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(472, 81);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 28);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 128);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(642, 177);
            this.dgvProdutos.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(133, 316);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 20;
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroProdutos";
            this.Text = "SysBAR || Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadastroProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
    }
}