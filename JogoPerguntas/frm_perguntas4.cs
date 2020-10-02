using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoPerguntas
{
    public partial class frm_perguntas4 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas4()
        {
            InitializeComponent();
        }

        private void frm_perguntas4_Load(object sender, EventArgs e)
        {
            lbl_score4.Text = pontos.ToString();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao4B.Checked)
            {
                frm_perguntas5 f5 = new frm_perguntas5();
                if ((cont > 20) && (cont < 40))
                {
                    f5.Pontos = Pontos+10;
                    this.Hide();
                    f5.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f5.Pontos =Pontos+5;
                    this.Hide();
                    f5.ShowDialog();
                }

            }
            else if ((rbd_opcao1B.Checked) || (rbd_opcao2B.Checked) || (rbd_opcao3B.Checked) || (rbd_opcao5B.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lbl_timer4.Text = cont.ToString();
            if (cont == 0)
            {
                timer4.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
