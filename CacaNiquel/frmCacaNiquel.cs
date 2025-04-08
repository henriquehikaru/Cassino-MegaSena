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
    public partial class fmrCacaNiquel : Form
    {
        //Inicio da Classe - C
        private Random srt = new Random();
        private int niquel1, niquel2, niquel3;
        private int contaGiro = 0, contaNiquel = 1;
        private int tentativas = 3;

        private void fmrCacaNiquel_Load(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            tentativas--;
            
            if (tentativas < 0)
            {
                MessageBox.Show("Você não possui mais tentativas!");
                return;
            }

            btnJogar.Text = "Jogar\nTentativas: " + tentativas.ToString();

            tmrNiquel.Enabled = true;

            lblNiquel1.Text = "";
            lblNiquel2.Text = "";
            lblNiquel3.Text = "";

            contaNiquel = 1;
        }

        public fmrCacaNiquel()
        {
            InitializeComponent();
        }

        private void tmrNiquel_Tick(object sender, EventArgs e)
        {
            btnJogar.Enabled = false;
            contaGiro++;
            
            switch (contaNiquel)
            {
                case 1:
                    niquel1 = srt.Next(0, 10);
                    lblNiquel1.Text = niquel1.ToString();
                    break;
                case 2:
                    niquel2 = srt.Next(0, 10);
                    lblNiquel2.Text = niquel2.ToString();
                    break;
                case 3:
                    niquel3 = srt.Next(0, 10);
                    lblNiquel3.Text = niquel3.ToString();
                    break;
                default:
                    // Atingiu a condição de término
                    tmrNiquel.Enabled = false;

                    if (niquel1 == niquel2 && niquel2 == niquel3)
                    {
                        MessageBox.Show("Parabéns, você ganhou um milhão 🌽🌽🌽!");
                    }
                    if (niquel1 == niquel2 || niquel1 ==  niquel3 || niquel2 == niquel3)
                    {
                        MessageBox.Show("Parabéns, você ganhou um milho 🌽!");
                    }
                    else
                    {
                        MessageBox.Show("Que pena, você perdeu! 😭");
                    }

                    listNiquel.Items.Add(niquel1.ToString() + " - " + niquel2.ToString() + " - " + niquel3.ToString());
                    btnJogar.Enabled = true;
                    break;

                    
            }
            if (contaGiro == 5)
            {
                contaNiquel++;
                contaGiro = 0;
            }
        }

        
        
    }
}
