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
    public partial class frm_perguntas9 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            lbl_score9.Text = Pontos.ToString();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao3F.Checked)
            {
                frm_perguntas10 f10 = new frm_perguntas10();
                if ((cont > 20) && (cont < 40))
                {
                    f10.Pontos =Pontos+ 10;
                    this.Hide();
                    f10.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f10.Pontos =Pontos+ 5;
                    this.Hide();
                    f10.ShowDialog();
                }
            }
            else if ((rbd_opcao1F.Checked) || (rbd_opcao2F.Checked) || (rbd_opcao4F.Checked) || (rbd_opcao5F.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            lbl_timer9.Text = cont.ToString();
            if (cont == 0)
            {
                timer9.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
