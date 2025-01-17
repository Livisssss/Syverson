﻿namespace Ferragem
{
    partial class Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxCNPJFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.mtxTelFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txEmailFornecedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txIDFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txIEFornecedor = new System.Windows.Forms.TextBox();
            this.cbCidadeFornecedor = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fERRAGEMdb = new Ferragem.FERRAGEMdb();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.idfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDGVFORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btLimparFornecedor = new System.Windows.Forms.Button();
            this.btAtualizarFornecedor = new System.Windows.Forms.Button();
            this.btExcluirFornecedor = new System.Windows.Forms.Button();
            this.btIncluirFornecedor = new System.Windows.Forms.Button();
            this.btConsultarFornecedor = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.txUFFornecedor = new System.Windows.Forms.TextBox();
            this.cidadesTableAdapter = new Ferragem.FERRAGEMdbTableAdapters.CidadesTableAdapter();
            this.vW_DGV_FORNECEDORESTableAdapter = new Ferragem.FERRAGEMdbTableAdapters.VW_DGV_FORNECEDORESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVFORNECEDORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 111;
            this.label12.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "UF:";
            // 
            // txNomeFornecedor
            // 
            this.txNomeFornecedor.Location = new System.Drawing.Point(69, 62);
            this.txNomeFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txNomeFornecedor.Name = "txNomeFornecedor";
            this.txNomeFornecedor.Size = new System.Drawing.Size(240, 20);
            this.txNomeFornecedor.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "CNPJ:";
            // 
            // mtxCNPJFornecedor
            // 
            this.mtxCNPJFornecedor.Location = new System.Drawing.Point(69, 102);
            this.mtxCNPJFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.mtxCNPJFornecedor.Mask = "00,000,000/0000-00";
            this.mtxCNPJFornecedor.Name = "mtxCNPJFornecedor";
            this.mtxCNPJFornecedor.Size = new System.Drawing.Size(120, 20);
            this.mtxCNPJFornecedor.TabIndex = 119;
            // 
            // mtxTelFornecedor
            // 
            this.mtxTelFornecedor.Location = new System.Drawing.Point(69, 185);
            this.mtxTelFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.mtxTelFornecedor.Mask = "(00) 90000-0000";
            this.mtxTelFornecedor.Name = "mtxTelFornecedor";
            this.mtxTelFornecedor.Size = new System.Drawing.Size(85, 20);
            this.mtxTelFornecedor.TabIndex = 120;
            // 
            // txEmailFornecedor
            // 
            this.txEmailFornecedor.Location = new System.Drawing.Point(220, 185);
            this.txEmailFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txEmailFornecedor.Name = "txEmailFornecedor";
            this.txEmailFornecedor.Size = new System.Drawing.Size(204, 20);
            this.txEmailFornecedor.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 122;
            this.label11.Text = "ID Fornecedor:";
            // 
            // txIDFornecedor
            // 
            this.txIDFornecedor.Enabled = false;
            this.txIDFornecedor.Location = new System.Drawing.Point(106, 16);
            this.txIDFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txIDFornecedor.Name = "txIDFornecedor";
            this.txIDFornecedor.Size = new System.Drawing.Size(48, 20);
            this.txIDFornecedor.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Inscrição Estadual:";
            // 
            // txIEFornecedor
            // 
            this.txIEFornecedor.Location = new System.Drawing.Point(307, 102);
            this.txIEFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txIEFornecedor.Name = "txIEFornecedor";
            this.txIEFornecedor.Size = new System.Drawing.Size(117, 20);
            this.txIEFornecedor.TabIndex = 130;
            this.txIEFornecedor.TextChanged += new System.EventHandler(this.txIEFornecedor_TextChanged);
            // 
            // cbCidadeFornecedor
            // 
            this.cbCidadeFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cidadesBindingSource, "id_cidade", true));
            this.cbCidadeFornecedor.DataSource = this.cidadesBindingSource;
            this.cbCidadeFornecedor.DisplayMember = "nome";
            this.cbCidadeFornecedor.FormattingEnabled = true;
            this.cbCidadeFornecedor.Location = new System.Drawing.Point(69, 143);
            this.cbCidadeFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbCidadeFornecedor.Name = "cbCidadeFornecedor";
            this.cbCidadeFornecedor.Size = new System.Drawing.Size(203, 21);
            this.cbCidadeFornecedor.TabIndex = 132;
            this.cbCidadeFornecedor.ValueMember = "id_cidade";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.fERRAGEMdb;
            // 
            // fERRAGEMdb
            // 
            this.fERRAGEMdb.DataSetName = "FERRAGEMdb";
            this.fERRAGEMdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AllowUserToResizeColumns = false;
            this.dgvFornecedor.AllowUserToResizeRows = false;
            this.dgvFornecedor.AutoGenerateColumns = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfornecedorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.ieDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn});
            this.dgvFornecedor.DataSource = this.vWDGVFORNECEDORESBindingSource;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 227);
            this.dgvFornecedor.MultiSelect = false;
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.RowHeadersWidth = 51;
            this.dgvFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFornecedor.Size = new System.Drawing.Size(879, 204);
            this.dgvFornecedor.TabIndex = 134;
            // 
            // idfornecedorDataGridViewTextBoxColumn
            // 
            this.idfornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idfornecedorDataGridViewTextBoxColumn.DataPropertyName = "id_fornecedor";
            this.idfornecedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idfornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfornecedorDataGridViewTextBoxColumn.Name = "idfornecedorDataGridViewTextBoxColumn";
            this.idfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfornecedorDataGridViewTextBoxColumn.Width = 43;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ieDataGridViewTextBoxColumn
            // 
            this.ieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ieDataGridViewTextBoxColumn.DataPropertyName = "ie";
            this.ieDataGridViewTextBoxColumn.HeaderText = "Incrição Estadual";
            this.ieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ieDataGridViewTextBoxColumn.Name = "ieDataGridViewTextBoxColumn";
            this.ieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 60;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWDGVFORNECEDORESBindingSource
            // 
            this.vWDGVFORNECEDORESBindingSource.DataMember = "VW_DGV_FORNECEDORES";
            this.vWDGVFORNECEDORESBindingSource.DataSource = this.fERRAGEMdb;
            // 
            // btLimparFornecedor
            // 
            this.btLimparFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btLimparFornecedor.BackgroundImage = global::Ferragem.Properties.Resources.vassoura;
            this.btLimparFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimparFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparFornecedor.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btLimparFornecedor.Location = new System.Drawing.Point(484, 169);
            this.btLimparFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btLimparFornecedor.Name = "btLimparFornecedor";
            this.btLimparFornecedor.Size = new System.Drawing.Size(44, 36);
            this.btLimparFornecedor.TabIndex = 139;
            this.toolTip5.SetToolTip(this.btLimparFornecedor, "Limpar");
            this.btLimparFornecedor.UseVisualStyleBackColor = false;
            this.btLimparFornecedor.Click += new System.EventHandler(this.btLimparFornecedor_Click);
            // 
            // btAtualizarFornecedor
            // 
            this.btAtualizarFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btAtualizarFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtualizarFornecedor.BackgroundImage")));
            this.btAtualizarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAtualizarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarFornecedor.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btAtualizarFornecedor.Location = new System.Drawing.Point(484, 85);
            this.btAtualizarFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btAtualizarFornecedor.Name = "btAtualizarFornecedor";
            this.btAtualizarFornecedor.Size = new System.Drawing.Size(44, 36);
            this.btAtualizarFornecedor.TabIndex = 138;
            this.toolTip3.SetToolTip(this.btAtualizarFornecedor, "Atualizar");
            this.btAtualizarFornecedor.UseVisualStyleBackColor = false;
            this.btAtualizarFornecedor.Click += new System.EventHandler(this.btAtualizarFornecedor_Click);
            // 
            // btExcluirFornecedor
            // 
            this.btExcluirFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirFornecedor.BackgroundImage = global::Ferragem.Properties.Resources.lixo;
            this.btExcluirFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExcluirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirFornecedor.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btExcluirFornecedor.Location = new System.Drawing.Point(484, 129);
            this.btExcluirFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluirFornecedor.Name = "btExcluirFornecedor";
            this.btExcluirFornecedor.Size = new System.Drawing.Size(44, 36);
            this.btExcluirFornecedor.TabIndex = 137;
            this.toolTip4.SetToolTip(this.btExcluirFornecedor, "Excluir");
            this.btExcluirFornecedor.UseVisualStyleBackColor = false;
            this.btExcluirFornecedor.Click += new System.EventHandler(this.btExcluirFornecedor_Click);
            // 
            // btIncluirFornecedor
            // 
            this.btIncluirFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirFornecedor.BackgroundImage")));
            this.btIncluirFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btIncluirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluirFornecedor.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btIncluirFornecedor.Location = new System.Drawing.Point(484, 42);
            this.btIncluirFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluirFornecedor.Name = "btIncluirFornecedor";
            this.btIncluirFornecedor.Size = new System.Drawing.Size(44, 36);
            this.btIncluirFornecedor.TabIndex = 136;
            this.toolTip2.SetToolTip(this.btIncluirFornecedor, "Incluir");
            this.btIncluirFornecedor.UseVisualStyleBackColor = false;
            this.btIncluirFornecedor.Click += new System.EventHandler(this.btIncluirFornecedor_Click);
            // 
            // btConsultarFornecedor
            // 
            this.btConsultarFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarFornecedor.BackgroundImage = global::Ferragem.Properties.Resources.lupa;
            this.btConsultarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConsultarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarFornecedor.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btConsultarFornecedor.Location = new System.Drawing.Point(159, 0);
            this.btConsultarFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultarFornecedor.Name = "btConsultarFornecedor";
            this.btConsultarFornecedor.Size = new System.Drawing.Size(59, 49);
            this.btConsultarFornecedor.TabIndex = 135;
            this.toolTip1.SetToolTip(this.btConsultarFornecedor, "Consultar");
            this.btConsultarFornecedor.UseVisualStyleBackColor = false;
            this.btConsultarFornecedor.Click += new System.EventHandler(this.btConsultarFornecedor_Click);
            // 
            // txUFFornecedor
            // 
            this.txUFFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "uf", true));
            this.txUFFornecedor.Enabled = false;
            this.txUFFornecedor.Location = new System.Drawing.Point(321, 143);
            this.txUFFornecedor.Name = "txUFFornecedor";
            this.txUFFornecedor.Size = new System.Drawing.Size(43, 20);
            this.txUFFornecedor.TabIndex = 140;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // vW_DGV_FORNECEDORESTableAdapter
            // 
            this.vW_DGV_FORNECEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(903, 443);
            this.Controls.Add(this.txUFFornecedor);
            this.Controls.Add(this.btLimparFornecedor);
            this.Controls.Add(this.btAtualizarFornecedor);
            this.Controls.Add(this.btExcluirFornecedor);
            this.Controls.Add(this.btIncluirFornecedor);
            this.Controls.Add(this.btConsultarFornecedor);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.cbCidadeFornecedor);
            this.Controls.Add(this.txIEFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txIDFornecedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txEmailFornecedor);
            this.Controls.Add(this.mtxTelFornecedor);
            this.Controls.Add(this.mtxCNPJFornecedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txNomeFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fornecedores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVFORNECEDORESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNomeFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxCNPJFornecedor;
        private System.Windows.Forms.MaskedTextBox mtxTelFornecedor;
        private System.Windows.Forms.TextBox txEmailFornecedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txIDFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIEFornecedor;
        private System.Windows.Forms.ComboBox cbCidadeFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btLimparFornecedor;
        private System.Windows.Forms.Button btAtualizarFornecedor;
        private System.Windows.Forms.Button btExcluirFornecedor;
        private System.Windows.Forms.Button btIncluirFornecedor;
        private System.Windows.Forms.Button btConsultarFornecedor;
        private FERRAGEMdb fERRAGEMdb;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txUFFornecedor;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private FERRAGEMdbTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource vWDGVFORNECEDORESBindingSource;
        private FERRAGEMdbTableAdapters.VW_DGV_FORNECEDORESTableAdapter vW_DGV_FORNECEDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
    }
}