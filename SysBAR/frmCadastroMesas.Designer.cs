namespace SysBAR
{
    partial class frmCadastroMesas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroDaMesa = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvMesas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroDaMesa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastros de Mesas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número da Mesa:";
            // 
            // txtNumeroDaMesa
            // 
            this.txtNumeroDaMesa.Location = new System.Drawing.Point(50, 106);
            this.txtNumeroDaMesa.Name = "txtNumeroDaMesa";
            this.txtNumeroDaMesa.Size = new System.Drawing.Size(150, 25);
            this.txtNumeroDaMesa.TabIndex = 2;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(217, 106);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(300, 25);
            this.txtObservacoes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Observações:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(323, 155);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 28);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(423, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(214, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesas Cadastradas:";
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.AllowUserToOrderColumns = true;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMesas.Location = new System.Drawing.Point(50, 284);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.Size = new System.Drawing.Size(467, 150);
            this.dgvMesas.TabIndex = 8;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(166, 243);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(150, 25);
            this.txtPesquisar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digite o número:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(322, 240);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 28);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(118, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 12;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensagem.Location = new System.Drawing.Point(47, 138);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(422, 240);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 28);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadastroMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(585, 492);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroMesas";
            this.Text = "SysBAR || Cadastros de Mesas";
            this.Load += new System.EventHandler(this.frmCadastroMesas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroDaMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltar;
    }
}