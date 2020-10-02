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
    public partial class frm_perguntas10 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas10()
        {
            InitializeComponent();
        }

        private void frm_perguntas10_Load(object sender, EventArgs e)
        {
            lbl_score10.Text = Pontos.ToString();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {

            if (rbd_opcao4G.Checked)
            {
                frm_perguntas11 f11 = new frm_perguntas11();
                this.Hide();
                f11.ShowDialog();

            }
            else if ((rbd_opcao1G.Checked) || (rbd_opcao2G.Checked) || (rbd_opcao3G.Checked) || (rbd_opcao5G.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();
                 
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            lbl_timer10.Text = cont.ToString();
            if (cont == 0)
            {
                timer10.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
