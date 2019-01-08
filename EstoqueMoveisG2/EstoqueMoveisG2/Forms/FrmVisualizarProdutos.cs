using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueMoveisG2.Forms
{
    public partial class FrmVisualizarProdutos : Form
    {
        Form1 form1 = new Form1();
        public FrmVisualizarProdutos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmAdicionarProduto frmAdicionarProduto = new FrmAdicionarProduto();
            frmAdicionarProduto.Show();
        }
    }
}
