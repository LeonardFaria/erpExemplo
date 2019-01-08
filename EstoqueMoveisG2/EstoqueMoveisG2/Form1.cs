using EstoqueMoveisG2.Forms;
using SistemaMoveisG2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueMoveisG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmVisualizarProdutos frmVisualizarProdutos = new FrmVisualizarProdutos();
            frmVisualizarProdutos.MdiParent = this;
            frmVisualizarProdutos.Show();

        }

        private void tabelaDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabelaMedidas frmTabelaMedidas = new FrmTabelaMedidas();
            frmTabelaMedidas.MdiParent = this;
            frmTabelaMedidas.Show();
        }
    }
}
