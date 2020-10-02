namespace JogoPerguntas
{
    partial class frm_perguntas11
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
            this.lblFInal = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFInal
            // 
            this.lblFInal.AutoSize = true;
            this.lblFInal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFInal.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInal.ForeColor = System.Drawing.Color.Red;
            this.lblFInal.Location = new System.Drawing.Point(242, 126);
            this.lblFInal.Name = "lblFInal";
            this.lblFInal.Size = new System.Drawing.Size(351, 144);
            this.lblFInal.TabIndex = 1;
            this.lblFInal.Text = "Parabéns!!!\r\nFim de jogo\r\n";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Cyan;
            this.btnSair.Image = global::JogoPerguntas.Properties.Resources.Forest_Flowers;
            this.btnSair.Location = new System.Drawing.Point(691, 342);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 35);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frm_perguntas11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoPerguntas.Properties.Resources.trofeus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 407);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblFInal);
            this.Name = "frm_perguntas11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.frm_perguntas11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFInal;
        private System.Windows.Forms.Button btnSair;

    }
}