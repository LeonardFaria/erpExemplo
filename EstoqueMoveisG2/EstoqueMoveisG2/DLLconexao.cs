using EstoqueMoveisG2.Classes;
using SistemaMoveisG2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueMoveisG2
{
    public class DLLconexao
    {

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        bool validarCampos = false;
        public SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=DBmoveisg2;Persist Security Info=True;User ID=sa;Password=001002";

        public DataTable Conexao(string CommandSql)
        {

            sqlDataAdapter = new SqlDataAdapter();
            sqlConnection = new SqlConnection(strConn);
            sqlCommand = new SqlCommand(CommandSql, sqlConnection);
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.Text;
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void ExcluirProdutosMedidas(int id)
        {
            string strCommand = @"delete from tbProdutosMedidas where "+id+ " = ProdutoCodigo";

            sqlConnection = new SqlConnection(strConn);
            sqlCommand = new SqlCommand(strCommand,sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Produto excluido com sucesso !");

        }

        public DataTable ConsultarProdutosMedidas(string textoPesquisa)
        {
            string strCommand = @"select ProdutoCodigo, ProdutoNome, ProdutoFabricante, ProdutoAltura, ProdutoLargura, ProdutoComprimento, ProdutoVolume, ProdutoCubagem from tbProdutosMedidas where ProdutoNome like '%'"+textoPesquisa.ToString()+"'%'";
            sqlConnection = new SqlConnection(strConn);
            sqlCommand = new SqlCommand(strCommand, sqlConnection);
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public void CadastrarProdutosMedidas(string nomeProduto, string fabricanteProduto, string alturaProduto, string larguraProduto, string comprimentoProduto, string volumeProduto, string cubagemProduto)
        {
            FrmTabelaMedidas frmTabelaMedidas = new FrmTabelaMedidas();
            ProdutosInfo objProdutoInfo = new ProdutosInfo();

            /*string strCommand = @"insert into tbProdutos (ProdutoSkuLojista, ProdutoSkuInterno, ProdutoNome, ProdutoCategoria, ProdutoModelo, ProdutoPreco, ProdutoStatus, ProdutoStatusPreco,ProdutoAltura,ProdutoLargura,ProdutoComprimento,ProdutoVolume,ProdutoCubagem)"+
            "values(@ProdutoSkuLojista, @ProdutoSkuInterno, @ProdutoNome, @ProdutoCategoria, @ProdutoModelo, @ProdutoPreco, @ProdutoStatus, @ProdutoStatusPreco,@ProdutoAltura,@ProdutoLargura,@ProdutoComprimento,@ProdutoVolume,@ProdutoCubagem)";*/

            string strCommand = @"insert into tbProdutosMedidas (ProdutoNome, ProdutoFabricante,ProdutoAltura,ProdutoLargura,ProdutoComprimento,ProdutoVolume,ProdutoCubagem)" +
            "values(@ProdutoNome, @ProdutoFabricante,@ProdutoAltura,@ProdutoLargura,@ProdutoComprimento,@ProdutoVolume,@ProdutoCubagem)";

            sqlConnection = new SqlConnection(strConn);
            sqlCommand = new SqlCommand(strCommand, sqlConnection);

            #region valida os campos
            if (!String.IsNullOrEmpty(nomeProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoNome", nomeProduto);
                validarCampos = true;
            }
            else
            {
                MessageBox.Show("Campo Nome do Produto é Obrigatorio !");
                validarCampos = false;
            }

            if (!String.IsNullOrEmpty(nomeProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoFabricante", nomeProduto);
                validarCampos = true;
            }
            else
            {
                MessageBox.Show("Campo Fabricante do Produto é Obrigatorio !");
                validarCampos = false;
            }
            if (!String.IsNullOrEmpty(alturaProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoAltura", alturaProduto);
                validarCampos = true;
            }
            else
            {
                MessageBox.Show("Campo Atura do Produto é Obrigatorio");
                validarCampos = false;
            }
            if (!String.IsNullOrEmpty(larguraProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoLargura", larguraProduto);
                validarCampos = true;
            }
            else
            {
                MessageBox.Show("Campo Largura do produto é Obrigatorio");
                validarCampos = false;
            }
            if (!String.IsNullOrEmpty(comprimentoProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoComprimento", comprimentoProduto);
                validarCampos = true;
            }
            else
            {
                MessageBox.Show("Campo Comprimento é Obrigatorio");
                validarCampos = false;
            }
            if (!String.IsNullOrEmpty(volumeProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoVolume", volumeProduto);
                validarCampos = true;
            }
            else
            {
                MessageBox.Show("Campo Volume é Obrigatorio");
                validarCampos = false;
            }
            if (!String.IsNullOrEmpty(cubagemProduto))
            {
                sqlCommand.Parameters.AddWithValue(@"ProdutoCubagem", cubagemProduto);
                validarCampos = true;
            }
            else
            {if (cubagemProduto == null)
                {
                    string cubagem = "0";
                    sqlCommand.Parameters.AddWithValue(@"ProdutoCubagem", cubagem);
                    validarCampos = true;
                }
                
            }
            #endregion
            try
            {
                if (validarCampos == true)
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro !" + ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public DataTable CarregarComboBox(string stringSqlCommand)
        {
            dataTable = new DataTable();
            sqlConnection = new SqlConnection(strConn);
            sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable SQLGridView()
        {
            string strCommand = "Select ProdutoCodigo, ProdutoNome, ProdutoFabricante, ProdutoAltura,ProdutoLargura,ProdutoComprimento,ProdutoVolume,ProdutoCubagem from tbProdutosMedidas";
            dataTable = new DataTable();
            sqlConnection = new SqlConnection(strConn);
            sqlCommand = new SqlCommand(strCommand,sqlConnection);
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public List<ProdutosInfo> ObterListaPesquisa(string TextoPesquisa)
        {
            sqlConnection = new SqlConnection(strConn);
            List<ProdutosInfo> objProdutoInfo = new List<ProdutosInfo>();
            string strCMD = "SELECT ProdutoCodigo, ProdutoNome, ProdutoFabricante FROM tbProdutosMedidas WHERE ProdutoNome LIKE '%" + TextoPesquisa + "%'";
            sqlCommand = new SqlCommand(strCMD,sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    ProdutosInfo p = new ProdutosInfo();
                    p.produtoCodigo = Convert.ToInt32(sqlDataReader["ProdutoCodigo"]);
                    p.produtoNome = sqlDataReader["ProdutoNome"].ToString();
                    p.produtoFabricante = sqlDataReader["ProdutoFabricante"].ToString();
                    p.produtoAltura = sqlDataReader["ProdutoAltura"].ToString();
                    p.produtoLargura = sqlDataReader["ProdutoLargura"].ToString();
                    p.produtoComprimento = sqlDataReader["ProdutoComprimento"].ToString();
                    p.produtoVolume = sqlDataReader["ProdutoVolume"].ToString();
                    p.produtoCubagem = sqlDataReader["ProdutoCubagem"].ToString();
                    objProdutoInfo.Add(p);  
                }
            }
            sqlConnection.Close();
            return objProdutoInfo;
        }
    }
}
