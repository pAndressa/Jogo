namespace JogoPerguntas
{
    partial class frm_perguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_resposta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbd_opcao1 = new System.Windows.Forms.RadioButton();
            this.lbl_opcao1 = new System.Windows.Forms.Label();
            this.lbl_pontuacao = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_timer1 = new System.Windows.Forms.Label();
            this.rbd_opcao2 = new System.Windows.Forms.RadioButton();
            this.rbd_opcao3 = new System.Windows.Forms.RadioButton();
            this.rbd_opcao4 = new System.Windows.Forms.RadioButton();
            this.rbd_opcao5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_resposta
            // 
            this.btn_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resposta.ForeColor = System.Drawing.Color.Red;
            this.btn_resposta.Image = global::JogoPerguntas.Properties.Resources.Dock;
            this.btn_resposta.Location = new System.Drawing.Point(12, 330);
            this.btn_resposta.Name = "btn_resposta";
            this.btn_resposta.Size = new System.Drawing.Size(128, 42);
            this.btn_resposta.TabIndex = 6;
            this.btn_resposta.Text = "Confirma";
            this.btn_resposta.UseVisualStyleBackColor = true;
            this.btn_resposta.Click += new System.EventHandler(this.btn_resposta_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbd_opcao1
            // 
            this.rbd_opcao1.AutoSize = true;
            this.rbd_opcao1.BackColor = System.Drawing.Color.Transparent;
            this.rbd_opcao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd_opcao1.Location = new System.Drawing.Point(12, 52);
            this.rbd_opcao1.Name = "rbd_opcao1";
            this.rbd_opcao1.Size = new System.Drawing.Size(143, 28);
            this.rbd_opcao1.TabIndex = 1;
            this.rbd_opcao1.TabStop = true;
            this.rbd_opcao1.Text = "José Sarney";
            this.rbd_opcao1.UseVisualStyleBackColor = false;
            // 
            // lbl_opcao1
            // 
            this.lbl_opcao1.AutoSize = true;
            this.lbl_opcao1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_opcao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opcao1.ForeColor = System.Drawing.Color.White;
            this.lbl_opcao1.Location = new System.Drawing.Point(12, 9);
            this.lbl_opcao1.Name = "lbl_opcao1";
            this.lbl_opcao1.Size = new System.Drawing.Size(356, 24);
            this.lbl_opcao1.TabIndex = 7;
            this.lbl_opcao1.Text = "Quem é o atual presidente do Brasil?";
            // 
            // lbl_pontuacao
            // 
            this.lbl_pontuacao.AutoSize = true;
            this.lbl_pontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontuacao.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_pontuacao.Location = new System.Drawing.Point(393, 52);
            this.lbl_pontuacao.Name = "lbl_pontuacao";
            this.lbl_pontuacao.Size = new System.Drawing.Size(109, 24);
            this.lbl_pontuacao.TabIndex = 7;
            this.lbl_pontuacao.Text = "Pontuação";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Lime;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(441, 105);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(21, 24);
            this.lbl_score.TabIndex = 8;
            this.lbl_score.Text = "0";
            // 
            // lbl_timer1
            // 
            this.lbl_timer1.AutoSize = true;
            this.lbl_timer1.BackColor = System.Drawing.Color.Lime;
            this.lbl_timer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer1.Location = new System.Drawing.Point(436, 338);
            this.lbl_timer1.Name = "lbl_timer1";
            this.lbl_timer1.Size = new System.Drawing.Size(0, 24);
            this.lbl_timer1.TabIndex = 9;
            // 
            // rbd_opcao2
            // 
            this.rbd_opcao2.AutoSize = true;
            this.rbd_opcao2.BackColor = System.Drawing.Color.Transparent;
            this.rbd_opcao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd_opcao2.Location = new System.Drawing.Point(12, 86);
            this.rbd_opcao2.Name = "rbd_opcao2";
            this.rbd_opcao2.Size = new System.Drawing.Size(166, 28);
            this.rbd_opcao2.TabIndex = 2;
            this.rbd_opcao2.TabStop = true;
            this.rbd_opcao2.Text = "Dilma Rousseff";
            this.rbd_opcao2.UseVisualStyleBackColor = false;
            // 
            // rbd_opcao3
            // 
            this.rbd_opcao3.AutoSize = true;
            this.rbd_opcao3.BackColor = System.Drawing.Color.Transparent;
            this.rbd_opcao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd_opcao3.Location = new System.Drawing.Point(12, 120);
            this.rbd_opcao3.Name = "rbd_opcao3";
            this.rbd_opcao3.Size = new System.Drawing.Size(143, 28);
            this.rbd_opcao3.TabIndex = 3;
            this.rbd_opcao3.TabStop = true;
            this.rbd_opcao3.Text = "José Sarney";
            this.rbd_opcao3.UseVisualStyleBackColor = false;
            // 
            // rbd_opcao4
            // 
            this.rbd_opcao4.AutoSize = true;
            this.rbd_opcao4.BackColor = System.Drawing.Color.Transparent;
            this.rbd_opcao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd_opcao4.Location = new System.Drawing.Point(12, 154);
            this.rbd_opcao4.Name = "rbd_opcao4";
            this.rbd_opcao4.Size = new System.Drawing.Size(67, 28);
            this.rbd_opcao4.TabIndex = 4;
            this.rbd_opcao4.TabStop = true;
            this.rbd_opcao4.Text = "Lula";
            this.rbd_opcao4.UseVisualStyleBackColor = false;
            // 
            // rbd_opcao5
            // 
            this.rbd_opcao5.AutoSize = true;
            this.rbd_opcao5.BackColor = System.Drawing.Color.Transparent;
            this.rbd_opcao5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd_opcao5.Location = new System.Drawing.Point(12, 188);
            this.rbd_opcao5.Name = "rbd_opcao5";
            this.rbd_opcao5.Size = new System.Drawing.Size(174, 28);
            this.rbd_opcao5.TabIndex = 5;
            this.rbd_opcao5.TabStop = true;
            this.rbd_opcao5.Text = "Antonio Palocci";
            this.rbd_opcao5.UseVisualStyleBackColor = false;
            // 
            // frm_perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::JogoPerguntas.Properties.Resources.pensar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 384);
            this.Controls.Add(this.rbd_opcao5);
            this.Controls.Add(this.rbd_opcao4);
            this.Controls.Add(this.rbd_opcao3);
            this.Controls.Add(this.rbd_opcao2);
            this.Controls.Add(this.lbl_timer1);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_pontuacao);
            this.Controls.Add(this.lbl_opcao1);
            this.Controls.Add(this.rbd_opcao1);
            this.Controls.Add(this.btn_resposta);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frm_perguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de  Perguntas ";
            this.Load += new System.EventHandler(this.frm_perguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resposta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbd_opcao1;
        private System.Windows.Forms.Label lbl_opcao1;
        private System.Windows.Forms.Label lbl_pontuacao;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_timer1;
        private System.Windows.Forms.RadioButton rbd_opcao2;
        private System.Windows.Forms.RadioButton rbd_opcao3;
        private System.Windows.Forms.RadioButton rbd_opcao4;
        private System.Windows.Forms.RadioButton rbd_opcao5;
    }
}

