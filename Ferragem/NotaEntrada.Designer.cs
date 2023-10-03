namespace Ferragem
{
    partial class NotaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaEntrada));
            this.btLimparNotaE = new System.Windows.Forms.Button();
            this.btAtualizarNotaE = new System.Windows.Forms.Button();
            this.btExcluirNotaE = new System.Windows.Forms.Button();
            this.btIncluirNotaE = new System.Windows.Forms.Button();
            this.btConsultarNotaE = new System.Windows.Forms.Button();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fERRAGEMdb1 = new Ferragem.FERRAGEMdb();
            this.txQtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txIDNotaE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNumNota = new System.Windows.Forms.TextBox();
            this.txValor_Compra = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDGVPRODENTRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btAdiciona = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvNotaE = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDGVNOTAENTRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter2 = new Ferragem.FERRAGEMdbTableAdapters.FornecedoresTableAdapter();
            this.produtosTableAdapter2 = new Ferragem.FERRAGEMdbTableAdapters.ProdutosTableAdapter();
            this.vW_DGV_PROD_ENTRADATableAdapter = new Ferragem.FERRAGEMdbTableAdapters.VW_DGV_PROD_ENTRADATableAdapter();
            this.vW_DGV_NOTA_ENTRADATableAdapter = new Ferragem.FERRAGEMdbTableAdapters.VW_DGV_NOTA_ENTRADATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVPRODENTRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVNOTAENTRADABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btLimparNotaE
            // 
            this.btLimparNotaE.BackColor = System.Drawing.Color.Transparent;
            this.btLimparNotaE.BackgroundImage = global::Ferragem.Properties.Resources.vassoura;
            this.btLimparNotaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimparNotaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparNotaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparNotaE.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btLimparNotaE.Location = new System.Drawing.Point(919, 139);
            this.btLimparNotaE.Margin = new System.Windows.Forms.Padding(2);
            this.btLimparNotaE.Name = "btLimparNotaE";
            this.btLimparNotaE.Size = new System.Drawing.Size(44, 36);
            this.btLimparNotaE.TabIndex = 161;
            this.toolTip4.SetToolTip(this.btLimparNotaE, "Limpar");
            this.btLimparNotaE.UseVisualStyleBackColor = false;
            this.btLimparNotaE.Click += new System.EventHandler(this.btLimparNotaE_Click);
            // 
            // btAtualizarNotaE
            // 
            this.btAtualizarNotaE.BackColor = System.Drawing.Color.Transparent;
            this.btAtualizarNotaE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtualizarNotaE.BackgroundImage")));
            this.btAtualizarNotaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAtualizarNotaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarNotaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarNotaE.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btAtualizarNotaE.Location = new System.Drawing.Point(919, 55);
            this.btAtualizarNotaE.Margin = new System.Windows.Forms.Padding(2);
            this.btAtualizarNotaE.Name = "btAtualizarNotaE";
            this.btAtualizarNotaE.Size = new System.Drawing.Size(44, 36);
            this.btAtualizarNotaE.TabIndex = 160;
            this.toolTip2.SetToolTip(this.btAtualizarNotaE, "Atualizar");
            this.btAtualizarNotaE.UseVisualStyleBackColor = false;
            this.btAtualizarNotaE.Click += new System.EventHandler(this.btAtualizarNotaE_Click);
            // 
            // btExcluirNotaE
            // 
            this.btExcluirNotaE.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirNotaE.BackgroundImage = global::Ferragem.Properties.Resources.lixo;
            this.btExcluirNotaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExcluirNotaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirNotaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirNotaE.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btExcluirNotaE.Location = new System.Drawing.Point(919, 99);
            this.btExcluirNotaE.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluirNotaE.Name = "btExcluirNotaE";
            this.btExcluirNotaE.Size = new System.Drawing.Size(44, 36);
            this.btExcluirNotaE.TabIndex = 159;
            this.toolTip3.SetToolTip(this.btExcluirNotaE, "Excluir");
            this.btExcluirNotaE.UseVisualStyleBackColor = false;
            this.btExcluirNotaE.Click += new System.EventHandler(this.btExcluirNotaE_Click);
            // 
            // btIncluirNotaE
            // 
            this.btIncluirNotaE.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirNotaE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirNotaE.BackgroundImage")));
            this.btIncluirNotaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btIncluirNotaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirNotaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluirNotaE.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btIncluirNotaE.Location = new System.Drawing.Point(919, 12);
            this.btIncluirNotaE.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluirNotaE.Name = "btIncluirNotaE";
            this.btIncluirNotaE.Size = new System.Drawing.Size(44, 36);
            this.btIncluirNotaE.TabIndex = 158;
            this.toolTip1.SetToolTip(this.btIncluirNotaE, "Incluir");
            this.btIncluirNotaE.UseVisualStyleBackColor = false;
            this.btIncluirNotaE.Click += new System.EventHandler(this.btIncluirNotaE_Click);
            // 
            // btConsultarNotaE
            // 
            this.btConsultarNotaE.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarNotaE.BackgroundImage = global::Ferragem.Properties.Resources.lupa;
            this.btConsultarNotaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConsultarNotaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarNotaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarNotaE.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btConsultarNotaE.Location = new System.Drawing.Point(179, 7);
            this.btConsultarNotaE.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultarNotaE.Name = "btConsultarNotaE";
            this.btConsultarNotaE.Size = new System.Drawing.Size(59, 49);
            this.btConsultarNotaE.TabIndex = 157;
            this.toolTip5.SetToolTip(this.btConsultarNotaE, "Consultar");
            this.btConsultarNotaE.UseVisualStyleBackColor = false;
            this.btConsultarNotaE.Click += new System.EventHandler(this.btConsultarNotaE_Click);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "id_fornecedor", true));
            this.cbFornecedor.DataSource = this.fornecedoresBindingSource;
            this.cbFornecedor.DisplayMember = "nome";
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(106, 69);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(203, 21);
            this.cbFornecedor.TabIndex = 155;
            this.cbFornecedor.ValueMember = "id_fornecedor";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.fERRAGEMdb1;
            // 
            // fERRAGEMdb1
            // 
            this.fERRAGEMdb1.DataSetName = "FERRAGEMdb";
            this.fERRAGEMdb1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txQtde
            // 
            this.txQtde.Location = new System.Drawing.Point(106, 133);
            this.txQtde.Margin = new System.Windows.Forms.Padding(2);
            this.txQtde.Name = "txQtde";
            this.txQtde.Size = new System.Drawing.Size(55, 20);
            this.txQtde.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 153;
            this.label1.Text = "Valor de compra:";
            // 
            // txIDNotaE
            // 
            this.txIDNotaE.Enabled = false;
            this.txIDNotaE.Location = new System.Drawing.Point(126, 23);
            this.txIDNotaE.Margin = new System.Windows.Forms.Padding(2);
            this.txIDNotaE.Name = "txIDNotaE";
            this.txIDNotaE.Size = new System.Drawing.Size(48, 20);
            this.txIDNotaE.TabIndex = 152;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 151;
            this.label11.Text = "ID Nota:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 146;
            this.label9.Text = "Produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 145;
            this.label8.Text = "Quantidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 141;
            this.label12.Text = "Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 162;
            this.label2.Text = "Número da Nota:";
            // 
            // txNumNota
            // 
            this.txNumNota.Location = new System.Drawing.Point(411, 69);
            this.txNumNota.Margin = new System.Windows.Forms.Padding(2);
            this.txNumNota.Name = "txNumNota";
            this.txNumNota.Size = new System.Drawing.Size(55, 20);
            this.txNumNota.TabIndex = 163;
            this.txNumNota.TextChanged += new System.EventHandler(this.txNumNota_TextChanged);
            // 
            // txValor_Compra
            // 
            this.txValor_Compra.Location = new System.Drawing.Point(268, 132);
            this.txValor_Compra.Name = "txValor_Compra";
            this.txValor_Compra.Size = new System.Drawing.Size(100, 20);
            this.txValor_Compra.TabIndex = 165;
            this.txValor_Compra.TextChanged += new System.EventHandler(this.txValor_Compra_TextChanged);
            // 
            // cbProduto
            // 
            this.cbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "id_produto", true));
            this.cbProduto.DataSource = this.produtosBindingSource;
            this.cbProduto.DisplayMember = "nome";
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(106, 101);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(272, 21);
            this.cbProduto.TabIndex = 166;
            this.cbProduto.ValueMember = "id_produto";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.fERRAGEMdb1;
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AllowUserToResizeColumns = false;
            this.dgvProd.AllowUserToResizeRows = false;
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvProd.DataSource = this.vWDGVPRODENTRADABindingSource;
            this.dgvProd.Location = new System.Drawing.Point(525, 12);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProd.Size = new System.Drawing.Size(368, 494);
            this.dgvProd.TabIndex = 167;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "produto_nome";
            this.dataGridViewTextBoxColumn15.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 69;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "qtde";
            this.dataGridViewTextBoxColumn13.HeaderText = "Qtde";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "valor_un_compra";
            this.dataGridViewTextBoxColumn14.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // vWDGVPRODENTRADABindingSource
            // 
            this.vWDGVPRODENTRADABindingSource.DataMember = "VW_DGV_PROD_ENTRADA";
            this.vWDGVPRODENTRADABindingSource.DataSource = this.fERRAGEMdb1;
            // 
            // btAdiciona
            // 
            this.btAdiciona.Location = new System.Drawing.Point(421, 99);
            this.btAdiciona.Name = "btAdiciona";
            this.btAdiciona.Size = new System.Drawing.Size(56, 37);
            this.btAdiciona.TabIndex = 169;
            this.btAdiciona.Text = "Adiciona Produto";
            this.btAdiciona.UseVisualStyleBackColor = true;
            this.btAdiciona.Click += new System.EventHandler(this.btAdiciona_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(421, 142);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(56, 37);
            this.btRemove.TabIndex = 170;
            this.btRemove.Text = "Remove Produto";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // dgvNotaE
            // 
            this.dgvNotaE.AllowUserToAddRows = false;
            this.dgvNotaE.AllowUserToDeleteRows = false;
            this.dgvNotaE.AllowUserToResizeColumns = false;
            this.dgvNotaE.AllowUserToResizeRows = false;
            this.dgvNotaE.AutoGenerateColumns = false;
            this.dgvNotaE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn24});
            this.dgvNotaE.DataSource = this.vWDGVNOTAENTRADABindingSource;
            this.dgvNotaE.Location = new System.Drawing.Point(23, 206);
            this.dgvNotaE.MultiSelect = false;
            this.dgvNotaE.Name = "dgvNotaE";
            this.dgvNotaE.ReadOnly = true;
            this.dgvNotaE.RowHeadersVisible = false;
            this.dgvNotaE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNotaE.Size = new System.Drawing.Size(485, 300);
            this.dgvNotaE.TabIndex = 171;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "n_nota";
            this.dataGridViewTextBoxColumn18.HeaderText = "N° Nota";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 70;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "fornecedor_nome";
            this.dataGridViewTextBoxColumn22.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "valor_total_nota";
            this.dataGridViewTextBoxColumn24.HeaderText = "Valor Total";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // vWDGVNOTAENTRADABindingSource
            // 
            this.vWDGVNOTAENTRADABindingSource.DataMember = "VW_DGV_NOTA_ENTRADA";
            this.vWDGVNOTAENTRADABindingSource.DataSource = this.fERRAGEMdb1;
            // 
            // fornecedoresTableAdapter2
            // 
            this.fornecedoresTableAdapter2.ClearBeforeFill = true;
            // 
            // produtosTableAdapter2
            // 
            this.produtosTableAdapter2.ClearBeforeFill = true;
            // 
            // vW_DGV_PROD_ENTRADATableAdapter
            // 
            this.vW_DGV_PROD_ENTRADATableAdapter.ClearBeforeFill = true;
            // 
            // vW_DGV_NOTA_ENTRADATableAdapter
            // 
            this.vW_DGV_NOTA_ENTRADATableAdapter.ClearBeforeFill = true;
            // 
            // NotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(974, 518);
            this.Controls.Add(this.dgvNotaE);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdiciona);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.txValor_Compra);
            this.Controls.Add(this.txNumNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLimparNotaE);
            this.Controls.Add(this.btAtualizarNotaE);
            this.Controls.Add(this.btExcluirNotaE);
            this.Controls.Add(this.btIncluirNotaE);
            this.Controls.Add(this.btConsultarNotaE);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.txQtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txIDNotaE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Entrada";
            this.Load += new System.EventHandler(this.NotaEntrada_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotaEntrada_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVPRODENTRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVNOTAENTRADABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLimparNotaE;
        private System.Windows.Forms.Button btAtualizarNotaE;
        private System.Windows.Forms.Button btExcluirNotaE;
        private System.Windows.Forms.Button btIncluirNotaE;
        private System.Windows.Forms.Button btConsultarNotaE;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox txQtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIDNotaE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNumNota;
        private System.Windows.Forms.TextBox txValor_Compra;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.DataGridView dgvProd;
        private FERRAGEMdb fERRAGEMdb;
        private FERRAGEMdbTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private FERRAGEMdbTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoruncompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtonomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnotaeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoruncompraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedornomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtonomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalnotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAdiciona;
        private FERRAGEMdbTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter1;
        private FERRAGEMdbTableAdapters.ProdutosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.DataGridView dgvNotaE;
        private FERRAGEMdb fERRAGEMdb1;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private FERRAGEMdbTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter2;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FERRAGEMdbTableAdapters.ProdutosTableAdapter produtosTableAdapter2;
        private System.Windows.Forms.BindingSource vWDGVPRODENTRADABindingSource;
        private FERRAGEMdbTableAdapters.VW_DGV_PROD_ENTRADATableAdapter vW_DGV_PROD_ENTRADATableAdapter;
        private System.Windows.Forms.BindingSource vWDGVNOTAENTRADABindingSource;
        private FERRAGEMdbTableAdapters.VW_DGV_NOTA_ENTRADATableAdapter vW_DGV_NOTA_ENTRADATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}