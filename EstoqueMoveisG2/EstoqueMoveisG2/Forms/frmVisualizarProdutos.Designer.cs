namespace EstoqueMoveisG2.Forms
{
    partial class FrmVisualizarProdutos
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.produtoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblResultadoPesquisa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoCodigo,
            this.produtoNome});
            this.dgvDados.Location = new System.Drawing.Point(12, 72);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(965, 322);
            this.dgvDados.TabIndex = 0;
            // 
            // produtoCodigo
            // 
            this.produtoCodigo.HeaderText = "Código";
            this.produtoCodigo.Name = "produtoCodigo";
            this.produtoCodigo.ReadOnly = true;
            // 
            // produtoNome
            // 
            this.produtoNome.HeaderText = "Nome";
            this.produtoNome.Name = "produtoNome";
            this.produtoNome.ReadOnly = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::EstoqueMoveisG2.Properties.Resources.icons8_editar_propriedade_30;
            this.btnAlterar.Location = new System.Drawing.Point(147, 400);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(129, 42);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "  Alterar [ F3 ]";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::EstoqueMoveisG2.Properties.Resources.icons8_soma_30;
            this.btnNovo.Location = new System.Drawing.Point(12, 400);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(129, 42);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "  Novo [ F2 ]";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::EstoqueMoveisG2.Properties.Resources.icons8_soma_30;
            this.btnExcluir.Location = new System.Drawing.Point(282, 400);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(129, 42);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir [ F4 ]";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblResultadoPesquisa
            // 
            this.lblResultadoPesquisa.BackColor = System.Drawing.Color.Coral;
            this.lblResultadoPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPesquisa.Location = new System.Drawing.Point(12, 50);
            this.lblResultadoPesquisa.Name = "lblResultadoPesquisa";
            this.lblResultadoPesquisa.Size = new System.Drawing.Size(965, 19);
            this.lblResultadoPesquisa.TabIndex = 4;
            this.lblResultadoPesquisa.Text = "0 ITENS ENCONTRADOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o nome do produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(814, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "[ F5 ] para nova busca";
            // 
            // FrmVisualizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvDados);
            this.MinimizeBox = false;
            this.Name = "FrmVisualizarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisualizarProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoNome;
        private System.Windows.Forms.Label lblResultadoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}