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
    public partial class frm_perguntas3 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas3()
        {
            InitializeComponent();
        }


        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao222.Checked)
            {
                frm_perguntas4 f4 = new frm_perguntas4();
                if ((cont > 20) && (cont < 40))
                {
                    f4.Pontos = Pontos + 10 ;
                    this.Hide();
                    f4.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f4.Pontos = Pontos + 5;
                    this.Hide();
                    f4.ShowDialog();
                }
            }
            else if ((rbd_opcao111.Checked) || (rbd_opcao333.Checked) || (rbd_opcao444.Checked) || (rbd_opcao555.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();

            }
        }

        private void lbl_score1_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_perguntas3_Load(object sender, EventArgs e)
        {
            lbl_score3.Text = Pontos.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbl_timer3.Text = cont.ToString();
            if (cont == 0)
            {
                timer3.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
