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
        /* 05 - Antonio Jose - 15 - Marcos Santos
         * Inicio da Classe - Criação de objetos, variáveis, tipos que serão privados
        à classe - que serão visíveis à toda classe */
        private Random Mega = new Random();
        private int numSorteado;
        private int[,] cartao;
        private char[,] JogoVelho = new char[,] { {'X', 'O', 'X'}, 
                                                  {'X', 'O', 'X'}, 
                                                  {'O', 'X', 'O'}
        };
        private int numeroSorteado;

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
            cartao = new int[Convert.ToInt32(txtQtDeCard.Text), 6];
            GerarCartoes();
        }
        private void GerarCartoes()
        {
            for (int i = 0; i < Convert.ToInt32(txtQtDeCard.Text); i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    numeroSorteado = Mega.Next(1, 61);
                    cartao[i, j] = numeroSorteado;
                    lblCardAtual.Text += numeroSorteado.ToString("00") + " - ";
                    // lblCardAtual.Text += Convert.ToString(numeroSorteado + " - ");
                }
                lstCartoes.Items.Add(lblCardAtual.Text);
                lblCardAtual.Text = "";
            }
            
        }
    }
}
