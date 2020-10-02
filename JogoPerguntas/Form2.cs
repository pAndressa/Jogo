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
    public partial class frm_perguntas2 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas2()
        {
            InitializeComponent();
        }

        private void frm_perguntas2_Load(object sender, EventArgs e)
        {
            lbl_score2.Text = Pontos.ToString();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            if (rbd_opcao33.Checked)
            {
                frm_perguntas3 f3 = new frm_perguntas3();

                if ((cont > 20) && (cont < 40))
                {
                    f3.Pontos = Pontos + 10;
                    this.Hide();
                    f3.ShowDialog();

                }
                else if ((cont >= 0) && (cont < 20))
                {
                    f3.Pontos = Pontos + 5;
                    this.Hide();
                    f3.ShowDialog();
                }
                else if ((rbd_opcao11.Checked) || (rbd_opcao22.Checked) || (rbd_opcao44.Checked) || (rbd_opcao55.Checked))
                {
                    MessageBox.Show("Você errou");
                    timer2.Enabled = false;
                    Hide();

                }
            

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_timer2.Text = cont.ToString();
            if (cont == 0)
            {
                timer2.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
