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
    public partial class frm_perguntas6 : Form
    {
        int cont = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
       
        public frm_perguntas6()
        {
            InitializeComponent();
        }

        private void frm_perguntas6_Load(object sender, EventArgs e)
        {
            lbl_score6.Text = Pontos.ToString();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            if (rbd_opcao5C.Checked)
            {
                frm_perguntas7 f7 = new frm_perguntas7();
                if ((cont > 20) && (cont < 40))
                {
                    f7.Pontos =Pontos+ 10;
                    this.Hide();
                    f7.ShowDialog();
                }
                else if ((cont > 0) && (cont < 20))
                {
                    f7.Pontos =Pontos+ 5;
                    this.Hide();
                    f7.ShowDialog();
                }
            }
            else if ((rbd_opcao1C.Checked) || (rbd_opcao2C.Checked) || (rbd_opcao3C.Checked) || (rbd_opcao4C.Checked))
            {
                MessageBox.Show("Você errou");
                Hide();

            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            lbl_timer6.Text = cont.ToString();
            if (cont == 0)
            {
                timer6.Enabled = false;
                Hide();
            }
            cont--;
        }
    }
}
