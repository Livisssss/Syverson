namespace Ferragem
{
    partial class Produtos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDGVPRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fERRAGEMdb = new Ferragem.FERRAGEMdb();
            this.txIDProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txNomeProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btLimparProduto = new System.Windows.Forms.Button();
            this.btAtualizarProduto = new System.Windows.Forms.Button();
            this.btExcluirProduto = new System.Windows.Forms.Button();
            this.btIncluirProduto = new System.Windows.Forms.Button();
            this.btConsultarProduto = new System.Windows.Forms.Button();
            this.vW_DGV_PRODUTOSTableAdapter = new Ferragem.FERRAGEMdbTableAdapters.VW_DGV_PRODUTOSTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVPRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.vWDGVPRODUTOSBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(340, 13);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProdutos.Size = new System.Drawing.Size(438, 224);
            this.dgvProdutos.TabIndex = 156;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWDGVPRODUTOSBindingSource
            // 
            this.vWDGVPRODUTOSBindingSource.DataMember = "VW_DGV_PRODUTOS";
            this.vWDGVPRODUTOSBindingSource.DataSource = this.fERRAGEMdb;
            // 
            // fERRAGEMdb
            // 
            this.fERRAGEMdb.DataSetName = "FERRAGEMdb";
            this.fERRAGEMdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txIDProduto
            // 
            this.txIDProduto.Enabled = false;
            this.txIDProduto.Location = new System.Drawing.Point(106, 23);
            this.txIDProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txIDProduto.Name = "txIDProduto";
            this.txIDProduto.Size = new System.Drawing.Size(48, 20);
            this.txIDProduto.TabIndex = 152;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 151;
            this.label11.Text = "ID Produto:";
            // 
            // txDescricaoProduto
            // 
            this.txDescricaoProduto.Location = new System.Drawing.Point(69, 112);
            this.txDescricaoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txDescricaoProduto.Multiline = true;
            this.txDescricaoProduto.Name = "txDescricaoProduto";
            this.txDescricaoProduto.Size = new System.Drawing.Size(240, 125);
            this.txDescricaoProduto.TabIndex = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 146;
            this.label9.Text = "Descrição:";
            // 
            // txNomeProduto
            // 
            this.txNomeProduto.Location = new System.Drawing.Point(69, 69);
            this.txNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txNomeProduto.Name = "txNomeProduto";
            this.txNomeProduto.Size = new System.Drawing.Size(240, 20);
            this.txNomeProduto.TabIndex = 144;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 141;
            this.label12.Text = "Nome:";
            // 
            // btLimparProduto
            // 
            this.btLimparProduto.BackColor = System.Drawing.Color.Transparent;
            this.btLimparProduto.BackgroundImage = global::Ferragem.Properties.Resources.vassoura;
            this.btLimparProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimparProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparProduto.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btLimparProduto.Location = new System.Drawing.Point(796, 153);
            this.btLimparProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btLimparProduto.Name = "btLimparProduto";
            this.btLimparProduto.Size = new System.Drawing.Size(44, 36);
            this.btLimparProduto.TabIndex = 161;
            this.toolTip4.SetToolTip(this.btLimparProduto, "Limpar");
            this.btLimparProduto.UseVisualStyleBackColor = false;
            this.btLimparProduto.Click += new System.EventHandler(this.btLimparProduto_Click);
            // 
            // btAtualizarProduto
            // 
            this.btAtualizarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btAtualizarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtualizarProduto.BackgroundImage")));
            this.btAtualizarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAtualizarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarProduto.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btAtualizarProduto.Location = new System.Drawing.Point(796, 69);
            this.btAtualizarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btAtualizarProduto.Name = "btAtualizarProduto";
            this.btAtualizarProduto.Size = new System.Drawing.Size(44, 36);
            this.btAtualizarProduto.TabIndex = 160;
            this.toolTip2.SetToolTip(this.btAtualizarProduto, "Atualizar");
            this.btAtualizarProduto.UseVisualStyleBackColor = false;
            this.btAtualizarProduto.Click += new System.EventHandler(this.btAtualizarProduto_Click);
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirProduto.BackgroundImage = global::Ferragem.Properties.Resources.lixo;
            this.btExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirProduto.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btExcluirProduto.Location = new System.Drawing.Point(796, 113);
            this.btExcluirProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(44, 36);
            this.btExcluirProduto.TabIndex = 159;
            this.toolTip3.SetToolTip(this.btExcluirProduto, "Excluir");
            this.btExcluirProduto.UseVisualStyleBackColor = false;
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // btIncluirProduto
            // 
            this.btIncluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirProduto.BackgroundImage")));
            this.btIncluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btIncluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluirProduto.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btIncluirProduto.Location = new System.Drawing.Point(796, 26);
            this.btIncluirProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluirProduto.Name = "btIncluirProduto";
            this.btIncluirProduto.Size = new System.Drawing.Size(44, 36);
            this.btIncluirProduto.TabIndex = 158;
            this.toolTip1.SetToolTip(this.btIncluirProduto, "Incluir");
            this.btIncluirProduto.UseVisualStyleBackColor = false;
            this.btIncluirProduto.Click += new System.EventHandler(this.btIncluirProduto_Click);
            // 
            // btConsultarProduto
            // 
            this.btConsultarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarProduto.BackgroundImage = global::Ferragem.Properties.Resources.lupa;
            this.btConsultarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConsultarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarProduto.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btConsultarProduto.Location = new System.Drawing.Point(159, 7);
            this.btConsultarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultarProduto.Name = "btConsultarProduto";
            this.btConsultarProduto.Size = new System.Drawing.Size(59, 49);
            this.btConsultarProduto.TabIndex = 157;
            this.toolTip5.SetToolTip(this.btConsultarProduto, "Consultar");
            this.btConsultarProduto.UseVisualStyleBackColor = false;
            this.btConsultarProduto.Click += new System.EventHandler(this.btConsultarProduto_Click);
            // 
            // vW_DGV_PRODUTOSTableAdapter
            // 
            this.vW_DGV_PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(846, 245);
            this.Controls.Add(this.btLimparProduto);
            this.Controls.Add(this.btAtualizarProduto);
            this.Controls.Add(this.btExcluirProduto);
            this.Controls.Add(this.btIncluirProduto);
            this.Controls.Add(this.btConsultarProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txIDProduto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txDescricaoProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txNomeProduto);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Produtos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVPRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLimparProduto;
        private System.Windows.Forms.Button btAtualizarProduto;
        private System.Windows.Forms.Button btExcluirProduto;
        private System.Windows.Forms.Button btIncluirProduto;
        private System.Windows.Forms.Button btConsultarProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txIDProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txDescricaoProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txNomeProduto;
        private System.Windows.Forms.Label label12;
        private FERRAGEMdb fERRAGEMdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vWDGVPRODUTOSBindingSource;
        private FERRAGEMdbTableAdapters.VW_DGV_PRODUTOSTableAdapter vW_DGV_PRODUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}