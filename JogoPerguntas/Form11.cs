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
    public partial class frm_perguntas11 : Form
    {
        private string pontuacao;

        public string Pontuacao
        {
            get { return pontuacao; }
            set { pontuacao = value; }
        }
        public frm_perguntas11()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_perguntas11_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja jogar novamente","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                frm_perguntas f1 = new frm_perguntas();
                this.Hide();
                f1.ShowDialog();
                
            }
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
