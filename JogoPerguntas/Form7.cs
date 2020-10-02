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
    public partial class frm_perguntas7 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
       
        public frm_perguntas7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lbl_score7.Text = Pontos.ToString();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao2D.Checked)
            {
                frm_perguntas8 f8 = new frm_perguntas8();
                if ((cont > 20) && (cont < 40))
                {
                    f8.Pontos =Pontos+ 10;
                    this.Hide();
                    f8.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f8.Pontos =Pontos+ 5;
                    this.Hide();
                    f8.ShowDialog();
                }

            }
            else if ((rbd_opcao1D.Checked) || (rbd_opcao3D.Checked) || (rbd_opcao4D.Checked) || (rbd_opcao5D.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();

            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            lbl_timer7.Text = cont.ToString();
            if (cont == 0)
            {
                timer7.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
