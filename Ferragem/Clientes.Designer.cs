namespace Ferragem
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btAtualizarCliente = new System.Windows.Forms.Button();
            this.btExcluirCliente = new System.Windows.Forms.Button();
            this.btIncluirCliente = new System.Windows.Forms.Button();
            this.btConsultarCliente = new System.Windows.Forms.Button();
            this.txIDCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txEmailCliente = new System.Windows.Forms.TextBox();
            this.mtxTelCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txNomeCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataNascCliente = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txIdadeCliente = new System.Windows.Forms.TextBox();
            this.btLimparCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vWDGVCLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fERRAGEMdb = new Ferragem.FERRAGEMdb();
            this.cbCidadeCliente = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txUFCliente = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.cidadesTableAdapter = new Ferragem.FERRAGEMdbTableAdapters.CidadesTableAdapter();
            this.vW_DGV_CLIENTESTableAdapter = new Ferragem.FERRAGEMdbTableAdapters.VW_DGV_CLIENTESTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVCLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAtualizarCliente
            // 
            this.btAtualizarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btAtualizarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtualizarCliente.BackgroundImage")));
            this.btAtualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btAtualizarCliente.Location = new System.Drawing.Point(639, 107);
            this.btAtualizarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAtualizarCliente.Name = "btAtualizarCliente";
            this.btAtualizarCliente.Size = new System.Drawing.Size(59, 44);
            this.btAtualizarCliente.TabIndex = 102;
            this.toolTip3.SetToolTip(this.btAtualizarCliente, "Atualizar");
            this.btAtualizarCliente.UseVisualStyleBackColor = false;
            this.btAtualizarCliente.Click += new System.EventHandler(this.btAtualizarCliente_Click);
            // 
            // btExcluirCliente
            // 
            this.btExcluirCliente.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirCliente.BackgroundImage = global::Ferragem.Properties.Resources.lixo;
            this.btExcluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btExcluirCliente.Location = new System.Drawing.Point(639, 161);
            this.btExcluirCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExcluirCliente.Name = "btExcluirCliente";
            this.btExcluirCliente.Size = new System.Drawing.Size(59, 44);
            this.btExcluirCliente.TabIndex = 101;
            this.toolTip2.SetToolTip(this.btExcluirCliente, "Excluir");
            this.btExcluirCliente.UseVisualStyleBackColor = false;
            this.btExcluirCliente.Click += new System.EventHandler(this.btExcluirCliente_Click);
            // 
            // btIncluirCliente
            // 
            this.btIncluirCliente.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirCliente.BackgroundImage")));
            this.btIncluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btIncluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluirCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btIncluirCliente.Location = new System.Drawing.Point(639, 54);
            this.btIncluirCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIncluirCliente.Name = "btIncluirCliente";
            this.btIncluirCliente.Size = new System.Drawing.Size(59, 44);
            this.btIncluirCliente.TabIndex = 100;
            this.toolTip4.SetToolTip(this.btIncluirCliente, "Incluir");
            this.btIncluirCliente.UseVisualStyleBackColor = false;
            this.btIncluirCliente.Click += new System.EventHandler(this.btIncluirCliente_Click);
            // 
            // btConsultarCliente
            // 
            this.btConsultarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarCliente.BackgroundImage = global::Ferragem.Properties.Resources.lupa;
            this.btConsultarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btConsultarCliente.Location = new System.Drawing.Point(205, 2);
            this.btConsultarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConsultarCliente.Name = "btConsultarCliente";
            this.btConsultarCliente.Size = new System.Drawing.Size(79, 60);
            this.btConsultarCliente.TabIndex = 99;
            this.toolTip5.SetToolTip(this.btConsultarCliente, "Consultar");
            this.btConsultarCliente.UseVisualStyleBackColor = false;
            this.btConsultarCliente.Click += new System.EventHandler(this.btConsultarCliente_Click);
            // 
            // txIDCliente
            // 
            this.txIDCliente.Enabled = false;
            this.txIDCliente.Location = new System.Drawing.Point(129, 22);
            this.txIDCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txIDCliente.Name = "txIDCliente";
            this.txIDCliente.Size = new System.Drawing.Size(71, 22);
            this.txIDCliente.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 97;
            this.label11.Text = "ID Cliente:";
            // 
            // txEmailCliente
            // 
            this.txEmailCliente.Location = new System.Drawing.Point(281, 230);
            this.txEmailCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txEmailCliente.Name = "txEmailCliente";
            this.txEmailCliente.Size = new System.Drawing.Size(279, 22);
            this.txEmailCliente.TabIndex = 96;
            // 
            // mtxTelCliente
            // 
            this.mtxTelCliente.Location = new System.Drawing.Point(80, 230);
            this.mtxTelCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxTelCliente.Mask = "(00) 90000-0000";
            this.mtxTelCliente.Name = "mtxTelCliente";
            this.mtxTelCliente.Size = new System.Drawing.Size(120, 22);
            this.mtxTelCliente.TabIndex = 95;
            // 
            // mtxCPFCliente
            // 
            this.mtxCPFCliente.Location = new System.Drawing.Point(477, 79);
            this.mtxCPFCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxCPFCliente.Mask = "000,000,000-00";
            this.mtxCPFCliente.Name = "mtxCPFCliente";
            this.mtxCPFCliente.Size = new System.Drawing.Size(120, 22);
            this.mtxCPFCliente.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 88;
            this.label10.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 87;
            this.label9.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 86;
            this.label8.Text = "Telefone:";
            // 
            // txNomeCliente
            // 
            this.txNomeCliente.Location = new System.Drawing.Point(80, 79);
            this.txNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNomeCliente.Name = "txNomeCliente";
            this.txNomeCliente.Size = new System.Drawing.Size(327, 22);
            this.txNomeCliente.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Nome:";
            // 
            // dtpDataNascCliente
            // 
            this.dtpDataNascCliente.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataNascCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascCliente.Location = new System.Drawing.Point(335, 132);
            this.dtpDataNascCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataNascCliente.Name = "dtpDataNascCliente";
            this.dtpDataNascCliente.Size = new System.Drawing.Size(137, 22);
            this.dtpDataNascCliente.TabIndex = 104;
            this.dtpDataNascCliente.Value = new System.DateTime(2023, 9, 9, 0, 0, 0, 0);
            this.dtpDataNascCliente.ValueChanged += new System.EventHandler(this.dtpDataNascCliente_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Idade:";
            // 
            // txIdadeCliente
            // 
            this.txIdadeCliente.Location = new System.Drawing.Point(80, 132);
            this.txIdadeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txIdadeCliente.Name = "txIdadeCliente";
            this.txIdadeCliente.Size = new System.Drawing.Size(51, 22);
            this.txIdadeCliente.TabIndex = 106;
            this.txIdadeCliente.TextChanged += new System.EventHandler(this.txIdadeCliente_TextChanged);
            // 
            // btLimparCliente
            // 
            this.btLimparCliente.BackColor = System.Drawing.Color.Transparent;
            this.btLimparCliente.BackgroundImage = global::Ferragem.Properties.Resources.vassoura;
            this.btLimparCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimparCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btLimparCliente.Location = new System.Drawing.Point(639, 210);
            this.btLimparCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimparCliente.Name = "btLimparCliente";
            this.btLimparCliente.Size = new System.Drawing.Size(59, 44);
            this.btLimparCliente.TabIndex = 107;
            this.toolTip1.SetToolTip(this.btLimparCliente, "Limpar");
            this.btLimparCliente.UseVisualStyleBackColor = false;
            this.btLimparCliente.Click += new System.EventHandler(this.btLimparCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataGridView1.DataSource = this.vWDGVCLIENTESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 241);
            this.dataGridView1.TabIndex = 112;
            // 
            // vWDGVCLIENTESBindingSource
            // 
            this.vWDGVCLIENTESBindingSource.DataMember = "VW_DGV_CLIENTES";
            this.vWDGVCLIENTESBindingSource.DataSource = this.fERRAGEMdb;
            // 
            // fERRAGEMdb
            // 
            this.fERRAGEMdb.DataSetName = "FERRAGEMdb";
            this.fERRAGEMdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbCidadeCliente
            // 
            this.cbCidadeCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cidadesBindingSource, "id_cidade", true));
            this.cbCidadeCliente.DataSource = this.cidadesBindingSource;
            this.cbCidadeCliente.DisplayMember = "nome";
            this.cbCidadeCliente.FormattingEnabled = true;
            this.cbCidadeCliente.Location = new System.Drawing.Point(80, 178);
            this.cbCidadeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbCidadeCliente.Name = "cbCidadeCliente";
            this.cbCidadeCliente.Size = new System.Drawing.Size(276, 24);
            this.cbCidadeCliente.TabIndex = 113;
            this.cbCidadeCliente.ValueMember = "id_cidade";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.fERRAGEMdb;
            // 
            // txUFCliente
            // 
            this.txUFCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "uf", true));
            this.txUFCliente.Enabled = false;
            this.txUFCliente.Location = new System.Drawing.Point(416, 178);
            this.txUFCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txUFCliente.Name = "txUFCliente";
            this.txUFCliente.Size = new System.Drawing.Size(56, 22);
            this.txUFCliente.TabIndex = 114;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // vW_DGV_CLIENTESTableAdapter
            // 
            this.vW_DGV_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 49;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "data_nascimento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data de Nascimento";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "idade";
            this.dataGridViewTextBoxColumn12.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 71;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumn13.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn14.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn15.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn16.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1204, 545);
            this.Controls.Add(this.txUFCliente);
            this.Controls.Add(this.cbCidadeCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btLimparCliente);
            this.Controls.Add(this.txIdadeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataNascCliente);
            this.Controls.Add(this.btAtualizarCliente);
            this.Controls.Add(this.btExcluirCliente);
            this.Controls.Add(this.btIncluirCliente);
            this.Controls.Add(this.btConsultarCliente);
            this.Controls.Add(this.txIDCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txEmailCliente);
            this.Controls.Add(this.mtxTelCliente);
            this.Controls.Add(this.mtxCPFCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txNomeCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDGVCLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERRAGEMdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAtualizarCliente;
        private System.Windows.Forms.Button btExcluirCliente;
        private System.Windows.Forms.Button btIncluirCliente;
        private System.Windows.Forms.Button btConsultarCliente;
        private System.Windows.Forms.TextBox txIDCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txEmailCliente;
        private System.Windows.Forms.MaskedTextBox mtxTelCliente;
        private System.Windows.Forms.MaskedTextBox mtxCPFCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNomeCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataNascCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIdadeCliente;
        private System.Windows.Forms.Button btLimparCliente;
        private FERRAGEMdb fERRAGEMdb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbCidadeCliente;
        private System.Windows.Forms.TextBox txUFCliente;
        private FERRAGEMdbTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource vWDGVCLIENTESBindingSource;
        private FERRAGEMdbTableAdapters.VW_DGV_CLIENTESTableAdapter vW_DGV_CLIENTESTableAdapter;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}