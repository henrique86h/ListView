using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxProduto.Clear();
            textBoxQuantidade.Clear();
            textBoxPreco.Clear();
            textBoxID.Focus();
        }
    }
}
