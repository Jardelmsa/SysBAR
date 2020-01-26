namespace SysBAR
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncináriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesAvançadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.opçõesAvançadasToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(937, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.logoffToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMesasToolStripMenuItem,
            this.cadastroDeFuncináriosToolStripMenuItem,
            this.cadastroDeCategoriasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroClientesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeMesasToolStripMenuItem
            // 
            this.cadastroDeMesasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastroDeMesasToolStripMenuItem.Name = "cadastroDeMesasToolStripMenuItem";
            this.cadastroDeMesasToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cadastroDeMesasToolStripMenuItem.Text = "Cadastro de Mesas";
            this.cadastroDeMesasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMesasToolStripMenuItem_Click);
            // 
            // cadastroDeFuncináriosToolStripMenuItem
            // 
            this.cadastroDeFuncináriosToolStripMenuItem.Name = "cadastroDeFuncináriosToolStripMenuItem";
            this.cadastroDeFuncináriosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cadastroDeFuncináriosToolStripMenuItem.Text = "Cadastro de Funcionários";
            // 
            // cadastroDeCategoriasToolStripMenuItem
            // 
            this.cadastroDeCategoriasToolStripMenuItem.Name = "cadastroDeCategoriasToolStripMenuItem";
            this.cadastroDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cadastroDeCategoriasToolStripMenuItem.Text = "Cadastro de Categorias";
            this.cadastroDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCategoriasToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // cadastroClientesToolStripMenuItem
            // 
            this.cadastroClientesToolStripMenuItem.Name = "cadastroClientesToolStripMenuItem";
            this.cadastroClientesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cadastroClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroClientesToolStripMenuItem_Click);
            // 
            // opçõesAvançadasToolStripMenuItem
            // 
            this.opçõesAvançadasToolStripMenuItem.Name = "opçõesAvançadasToolStripMenuItem";
            this.opçõesAvançadasToolStripMenuItem.Size = new System.Drawing.Size(134, 21);
            this.opçõesAvançadasToolStripMenuItem.Text = "Opções Avançadas";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 56);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de Mesas Abertas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Funcionário:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(497, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(189, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data e Hora:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 25, 21, 7, 56, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data e Hora:";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(937, 384);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3600;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 465);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysBar ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncináriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesAvançadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

