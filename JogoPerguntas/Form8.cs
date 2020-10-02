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
    public partial class frm_perguntas8 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            lbl_score8.Text = Pontos.ToString();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao4E.Checked)
            {
                frm_perguntas9 f9 = new frm_perguntas9();
                if ((cont > 20) && (cont < 40))
                {
                    f9.Pontos =Pontos+ 10;
                    this.Hide();
                    f9.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f9.Pontos =Pontos+ 5;
                    this.Hide();
                    f9.ShowDialog();
                }
            }
            else if ((rbd_opcao1E.Checked) || (rbd_opcao2E.Checked) || (rbd_opcao3E.Checked) || (rbd_opcao5E.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            lbl_timer8.Text = cont.ToString();
            if (cont == 0)
            {
                timer8.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
