namespace Ferragem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.strFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.strProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.strEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.strSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosTotaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldosTotaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.segurançaToolStripMenuItem,
            this.strSair});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(677, 29);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strCliente,
            this.strFornecedor,
            this.strProduto});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // strCliente
            // 
            this.strCliente.Name = "strCliente";
            this.strCliente.Size = new System.Drawing.Size(159, 26);
            this.strCliente.Text = "Cliente";
            this.strCliente.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // strFornecedor
            // 
            this.strFornecedor.Name = "strFornecedor";
            this.strFornecedor.Size = new System.Drawing.Size(159, 26);
            this.strFornecedor.Text = "Fornecedor";
            this.strFornecedor.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // strProduto
            // 
            this.strProduto.Name = "strProduto";
            this.strProduto.Size = new System.Drawing.Size(159, 26);
            this.strProduto.Text = "Produto";
            this.strProduto.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strEntrada,
            this.strSaida});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(112, 25);
            this.toolStripMenuItem5.Text = "Notas Fiscais";
            // 
            // strEntrada
            // 
            this.strEntrada.Name = "strEntrada";
            this.strEntrada.Size = new System.Drawing.Size(180, 26);
            this.strEntrada.Text = "Entrada";
            this.strEntrada.Click += new System.EventHandler(this.entradaToolStripMenuItem1_Click);
            // 
            // strSaida
            // 
            this.strSaida.Name = "strSaida";
            this.strSaida.Size = new System.Drawing.Size(180, 26);
            this.strSaida.Text = "Saída";
            this.strSaida.Click += new System.EventHandler(this.strSaida_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosTotaisToolStripMenuItem,
            this.saldosTotaisToolStripMenuItem,
            this.extratoToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 25);
            this.toolStripMenuItem3.Text = "Relatórios";
            // 
            // gastosTotaisToolStripMenuItem
            // 
            this.gastosTotaisToolStripMenuItem.Name = "gastosTotaisToolStripMenuItem";
            this.gastosTotaisToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.gastosTotaisToolStripMenuItem.Text = "Gastos Totais";
            // 
            // saldosTotaisToolStripMenuItem
            // 
            this.saldosTotaisToolStripMenuItem.Name = "saldosTotaisToolStripMenuItem";
            this.saldosTotaisToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saldosTotaisToolStripMenuItem.Text = "Saldos Totais";
            // 
            // extratoToolStripMenuItem
            // 
            this.extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            this.extratoToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.extratoToolStripMenuItem.Text = "Extrato";
            // 
            // segurançaToolStripMenuItem
            // 
            this.segurançaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strUsuario,
            this.atualizaçõesToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.segurançaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segurançaToolStripMenuItem.Name = "segurançaToolStripMenuItem";
            this.segurançaToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.segurançaToolStripMenuItem.Text = "Segurança";
            // 
            // strUsuario
            // 
            this.strUsuario.Name = "strUsuario";
            this.strUsuario.Size = new System.Drawing.Size(180, 26);
            this.strUsuario.Text = "Usuários";
            this.strUsuario.Click += new System.EventHandler(this.strUsuario_Click);
            // 
            // atualizaçõesToolStripMenuItem
            // 
            this.atualizaçõesToolStripMenuItem.Name = "atualizaçõesToolStripMenuItem";
            this.atualizaçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.atualizaçõesToolStripMenuItem.Text = "Atualizações";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // strSair
            // 
            this.strSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strSair.Name = "strSair";
            this.strSair.Size = new System.Drawing.Size(49, 25);
            this.strSair.Text = "Sair";
            this.strSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(677, 444);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syverson Ferragens®";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strCliente;
        private System.Windows.Forms.ToolStripMenuItem strFornecedor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gastosTotaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldosTotaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strUsuario;
        private System.Windows.Forms.ToolStripMenuItem atualizaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strSair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem strEntrada;
        private System.Windows.Forms.ToolStripMenuItem strSaida;
        private System.Windows.Forms.ToolStripMenuItem strProduto;
    }
}

