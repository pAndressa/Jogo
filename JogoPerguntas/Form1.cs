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
    public partial class frm_perguntas : Form
    {
        int cont1 = 40;
        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        public frm_perguntas()
        {
            InitializeComponent();
        }

        private void btn_resposta_Click(object sender, EventArgs e)
        {
            
            
            if (rbd_opcao2.Checked)
            {
                frm_perguntas2 f2 = new frm_perguntas2();

                if ((cont1 > 20) && (cont1 < 40))
                {
                    f2.Pontos = Pontos +10;
                    this.Hide();
                    f2.ShowDialog();

                }
                else if ((cont1 >= 0) && (cont1 < 20))
                {
                    f2.Pontos = Pontos + 5;
                    this.Hide();
                    f2.ShowDialog();
                }
         
            
           
            }
            else if ((rbd_opcao1.Checked) || (rbd_opcao3.Checked) || (rbd_opcao4.Checked) || (rbd_opcao5.Checked))
            {
                MessageBox.Show("Você errou");
                timer1.Enabled = false;
                Hide();
       
            }
            
      
          
        }

        private void frm_perguntas_Load(object sender, EventArgs e)
        {

        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer1.Text = cont1.ToString();
            if (cont1 == 0)
            {
                timer1.Enabled = false;
                Hide();
            }
            cont1--;
          
        }
    }
}
