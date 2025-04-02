using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaNiquel
{
    public partial class fmrMegaSena : Form
    {
        private Random Mega = new Random();
        private int numSorteado;
        private int[,] cartao;
        public fmrMegaSena()
        {
            InitializeComponent();
        }

        private void btnSortearNum_Click(object sender, EventArgs e)
        {
            //Consistência de dados - Verificar qtde de cartões
            if (String.IsNullOrWhiteSpace(txtQtDeCard.Text))
            {
                MessageBox.Show("Informe a quantidade de cartões!",
                    "Mega Sena",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                //txtQtDeCard.Focus();
                return;
            }
        }
    }
}
