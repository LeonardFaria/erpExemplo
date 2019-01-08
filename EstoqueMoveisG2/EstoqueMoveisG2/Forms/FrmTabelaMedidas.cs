using EstoqueMoveisG2;
using EstoqueMoveisG2.Classes;
using EstoqueMoveisG2.DBmoveisg2DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMoveisG2
{
    public partial class FrmTabelaMedidas : Form
    {
        public FrmTabelaMedidas()
        {
            InitializeComponent();;
        }
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;
        DataSet dtProdutos = new DataSet();
        string strConn = "Data Source=LENARD\\SQLEXPRESS;Initial Catalog=DBmoveisg2;Persist Security Info=True;User ID=sa;Password=001002"; string strSqlCmd = "";
        DLLconexao objConexao = new DLLconexao();
        DataTable dt;
        DataSet ds;
        DataGridViewRow rowData;
        int idProduto = 0;
        int _linhaIndice;

        public string nomeProduto, volumeProduto, cubagemProduto, fabricanteProduto;
        public string alturaProduto, larguraProduto , comprimentoProduto ;
        public int produtoCodigo = 0;

        private void btnExluir_Click(object sender, EventArgs e)
        {
            idProduto = Convert.ToInt32(lbIdProduto.Text);
            objConexao.ExcluirProdutosMedidas(idProduto);
            LimparTextBox();
            dgvDados.DataSource = "" ;
            dgvDados.Refresh();
            dgvDados.DataSource = objConexao.SQLGridView();
            PreencherDataGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            nomeProduto = txtNomeProduto.Text;
            alturaProduto = mskAltura.Text;
            larguraProduto = mskLargura.Text;
            comprimentoProduto = mskComprimento.Text;
            volumeProduto = txtVolume.Text;
            cubagemProduto = txtCubagem.Text;
            fabricanteProduto = txtFabricamte.Text;

            objConexao.CadastrarProdutosMedidas(txtNomeProduto.Text, txtFabricamte.Text, mskAltura.Text, mskLargura.Text, mskComprimento.Text, txtVolume.Text, txtCubagem.Text);
            dgvDados.DataSource = objConexao.SQLGridView();
            this.tbProdutosMedidasTableAdapter.Fill(this.dBmoveisg2DataSet.tbProdutosMedidas);
            PreencherDataGrid();
            LimparTextBox();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparTextBox();
        }

        private void dgvDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _linhaIndice = e.RowIndex;
            if (_linhaIndice == -1)
            {
                return;
            }

            rowData = dgvDados.Rows[_linhaIndice];
            lbIdProduto.Text = rowData.Cells[0].Value.ToString();
            txtNomeProduto.Text = rowData.Cells[1].Value.ToString();
            txtFabricamte.Text = rowData.Cells[2].Value.ToString();
            mskAltura.Text = rowData.Cells[3].Value.ToString();
            mskLargura.Text = rowData.Cells[4].Value.ToString();
            mskComprimento.Text = rowData.Cells[5].Value.ToString();
            txtVolume.Text = rowData.Cells[6].Value.ToString();
            txtCubagem.Text = rowData.Cells[7].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
                DBmoveisg2DataSet.tbProdutosMedidasDataTable objProdutosMedidas = new DBmoveisg2DataSet.tbProdutosMedidasDataTable();
                tbProdutosMedidasTableAdapter objProdutosMedidasTableAdapter = new tbProdutosMedidasTableAdapter();
                objProdutosMedidasTableAdapter.FillByNome(objProdutosMedidas, "%"+txtPesquisarProduto.Text+"%");

                foreach (DataRow r in objProdutosMedidas.Rows)
                {
                    dgvDados.CurrentRow.Cells[0].Value.ToString();
                    dgvDados.CurrentRow.Cells[1].Value.ToString();
                    dgvDados.CurrentRow.Cells[2].Value.ToString();
                    dgvDados.CurrentRow.Cells[3].Value.ToString();
                    dgvDados.CurrentRow.Cells[4].Value.ToString();
                    dgvDados.CurrentRow.Cells[5].Value.ToString();
                    dgvDados.CurrentRow.Cells[6].Value.ToString();
                    dgvDados.CurrentRow.Cells[7].Value.ToString();
                }
        }

        public void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            //objConexao.ObterListaPesquisa(txtPesquisarProduto.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBmoveisg2DataSet.tbProdutosMedidas'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutosMedidasTableAdapter.Fill(this.dBmoveisg2DataSet.tbProdutosMedidas);
            dgvDados.DataSource = objConexao.SQLGridView();
            //cboFiltro.DataSource = objConexao.CarregarComboBox("select ProdutoFabricante from tbProdutosMedidas");
            PreencherDataGrid();
        }


        public void PreencherDataGrid()
        {
            dgvDados.DataSource = objConexao.SQLGridView();
        }

        public void LimparTextBox()
        {
            mskAltura.Clear();
            mskComprimento.Clear();
            txtCubagem.Clear();
            mskLargura.Clear();
            txtNomeProduto.Clear();
            txtVolume.Clear();
            txtFabricamte.Clear();
            lbIdProduto.Refresh();
            txtNomeProduto.ClearUndo();
        }
        
    }
}
