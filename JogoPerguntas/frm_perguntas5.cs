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
    public partial class frm_perguntas5 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
       
        public frm_perguntas5()
        {
            InitializeComponent();
        }

        private void frm_perguntas5_Load(object sender, EventArgs e)
        {
            lbl_score5.Text = Pontos.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao3A.Checked)
            {
                frm_perguntas6 f6 = new frm_perguntas6();
                if ((cont > 20) && (cont < 40))
                {
                    f6.Pontos =Pontos+10;
                    this.Hide();
                    f6.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f6.Pontos =Pontos +5;
                    this.Hide();
                    f6.ShowDialog();
                }
            }
            else if ((rbd_opcao1A.Checked) || (rbd_opcao2A.Checked) || (rbd_opcao4A.Checked) || (rbd_opcao5A.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            lbl_timer5.Text = cont.ToString();
            if (cont == 0)
            {
                timer5.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
