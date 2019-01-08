namespace SistemaMoveisG2
{
    partial class FrmTabelaMedidas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskLargura = new System.Windows.Forms.MaskedTextBox();
            this.mskComprimento = new System.Windows.Forms.MaskedTextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFabricamte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lbIdProduto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCubagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnExluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.dBmoveisg2DataSet = new EstoqueMoveisG2.DBmoveisg2DataSet();
            this.tbProdutosMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutosMedidasTableAdapter = new EstoqueMoveisG2.DBmoveisg2DataSetTableAdapters.tbProdutosMedidasTableAdapter();
            this.produtoCubagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoComprimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoLargura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBmoveisg2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosMedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskLargura);
            this.groupBox1.Controls.Add(this.mskComprimento);
            this.groupBox1.Controls.Add(this.mskAltura);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFabricamte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVolume);
            this.groupBox1.Controls.Add(this.lbIdProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pbProduto);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCubagem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Controls.Add(this.btnExluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // mskLargura
            // 
            this.mskLargura.Location = new System.Drawing.Point(61, 71);
            this.mskLargura.Mask = "0.000";
            this.mskLargura.Name = "mskLargura";
            this.mskLargura.Size = new System.Drawing.Size(37, 20);
            this.mskLargura.TabIndex = 29;
            // 
            // mskComprimento
            // 
            this.mskComprimento.Location = new System.Drawing.Point(111, 71);
            this.mskComprimento.Mask = "0.000";
            this.mskComprimento.Name = "mskComprimento";
            this.mskComprimento.Size = new System.Drawing.Size(37, 20);
            this.mskComprimento.TabIndex = 28;
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(6, 71);
            this.mskAltura.Mask = "0.000";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(37, 20);
            this.mskAltura.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Fabricante";
            // 
            // txtFabricamte
            // 
            this.txtFabricamte.Location = new System.Drawing.Point(101, 121);
            this.txtFabricamte.Name = "txtFabricamte";
            this.txtFabricamte.Size = new System.Drawing.Size(57, 20);
            this.txtFabricamte.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Produto ID:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(58, 121);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(34, 20);
            this.txtVolume.TabIndex = 5;
            // 
            // lbIdProduto
            // 
            this.lbIdProduto.AutoSize = true;
            this.lbIdProduto.Location = new System.Drawing.Point(314, 16);
            this.lbIdProduto.Name = "lbIdProduto";
            this.lbIdProduto.Size = new System.Drawing.Size(13, 13);
            this.lbIdProduto.TabIndex = 23;
            this.lbIdProduto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Volume";
            // 
            // pbProduto
            // 
            this.pbProduto.Location = new System.Drawing.Point(171, 60);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(156, 86);
            this.pbProduto.TabIndex = 22;
            this.pbProduto.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(90, 152);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cubagem";
            // 
            // txtCubagem
            // 
            this.txtCubagem.Location = new System.Drawing.Point(9, 121);
            this.txtCubagem.Name = "txtCubagem";
            this.txtCubagem.Size = new System.Drawing.Size(34, 20);
            this.txtCubagem.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Largura";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(9, 152);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(171, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(6, 32);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(327, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(252, 152);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(75, 23);
            this.btnExluir.TabIndex = 10;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPesquisarProduto);
            this.panel1.Location = new System.Drawing.Point(12, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(250, 47);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Digite o nome do Produto";
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPesquisarProduto.Location = new System.Drawing.Point(9, 25);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(318, 20);
            this.txtPesquisarProduto.TabIndex = 0;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            // 
            // dBmoveisg2DataSet
            // 
            this.dBmoveisg2DataSet.DataSetName = "DBmoveisg2DataSet";
            this.dBmoveisg2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutosMedidasBindingSource
            // 
            this.tbProdutosMedidasBindingSource.DataMember = "tbProdutosMedidas";
            this.tbProdutosMedidasBindingSource.DataSource = this.dBmoveisg2DataSet;
            // 
            // tbProdutosMedidasTableAdapter
            // 
            this.tbProdutosMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // produtoCubagem
            // 
            this.produtoCubagem.DataPropertyName = "ProdutoCubagem";
            this.produtoCubagem.HeaderText = "Cubagem";
            this.produtoCubagem.Name = "produtoCubagem";
            this.produtoCubagem.ReadOnly = true;
            // 
            // produtoVolume
            // 
            this.produtoVolume.DataPropertyName = "ProdutoVolume";
            this.produtoVolume.HeaderText = "Volume";
            this.produtoVolume.Name = "produtoVolume";
            this.produtoVolume.ReadOnly = true;
            // 
            // produtoComprimento
            // 
            this.produtoComprimento.DataPropertyName = "ProdutoComprimento";
            this.produtoComprimento.HeaderText = "Comprimento";
            this.produtoComprimento.Name = "produtoComprimento";
            this.produtoComprimento.ReadOnly = true;
            // 
            // produtoLargura
            // 
            this.produtoLargura.DataPropertyName = "ProdutoLargura";
            this.produtoLargura.HeaderText = "Largura";
            this.produtoLargura.Name = "produtoLargura";
            this.produtoLargura.ReadOnly = true;
            // 
            // produtoAltura
            // 
            this.produtoAltura.DataPropertyName = "ProdutoAltura";
            this.produtoAltura.HeaderText = "Altura";
            this.produtoAltura.Name = "produtoAltura";
            this.produtoAltura.ReadOnly = true;
            // 
            // produtoFabricante
            // 
            this.produtoFabricante.DataPropertyName = "ProdutoFabricante";
            this.produtoFabricante.HeaderText = "Fabricante";
            this.produtoFabricante.Name = "produtoFabricante";
            this.produtoFabricante.ReadOnly = true;
            // 
            // produtoNome
            // 
            this.produtoNome.DataPropertyName = "ProdutoNome";
            this.produtoNome.HeaderText = "Descrição";
            this.produtoNome.Name = "produtoNome";
            this.produtoNome.ReadOnly = true;
            this.produtoNome.Width = 200;
            // 
            // codigoProduto
            // 
            this.codigoProduto.DataPropertyName = "ProdutoCodigo";
            this.codigoProduto.HeaderText = "Código";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProduto,
            this.produtoNome,
            this.produtoFabricante,
            this.produtoAltura,
            this.produtoLargura,
            this.produtoComprimento,
            this.produtoVolume,
            this.produtoCubagem});
            this.dgvDados.Location = new System.Drawing.Point(12, 278);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(339, 216);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseClick);
            // 
            // FrmTabelaMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Name = "FrmTabelaMedidas";
            this.Text = "Tabela de Peso e Medidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBmoveisg2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosMedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtCubagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.Label lbIdProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFabricamte;
        private System.Windows.Forms.MaskedTextBox mskLargura;
        private System.Windows.Forms.MaskedTextBox mskComprimento;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private EstoqueMoveisG2.DBmoveisg2DataSet dBmoveisg2DataSet;
        private System.Windows.Forms.BindingSource tbProdutosMedidasBindingSource;
        private EstoqueMoveisG2.DBmoveisg2DataSetTableAdapters.tbProdutosMedidasTableAdapter tbProdutosMedidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoCubagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoComprimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoLargura;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}

