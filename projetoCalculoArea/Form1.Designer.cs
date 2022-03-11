namespace projetoCalculoArea
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.BntCalcularArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o raio do circulo:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(29, 51);
            this.txtRaio.MaxLength = 10;
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(280, 23);
            this.txtRaio.TabIndex = 1;
            this.txtRaio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRaio_KeyPress);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.White;
            this.lbResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResposta.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.Black;
            this.lbResposta.Location = new System.Drawing.Point(29, 202);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(280, 59);
            this.lbResposta.TabIndex = 2;
            this.lbResposta.Text = "Resposta:";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BntCalcularArea
            // 
            this.BntCalcularArea.BackColor = System.Drawing.Color.Tomato;
            this.BntCalcularArea.ForeColor = System.Drawing.Color.White;
            this.BntCalcularArea.Location = new System.Drawing.Point(84, 95);
            this.BntCalcularArea.Name = "BntCalcularArea";
            this.BntCalcularArea.Size = new System.Drawing.Size(167, 78);
            this.BntCalcularArea.TabIndex = 3;
            this.BntCalcularArea.Text = "Calcular Area";
            this.BntCalcularArea.UseVisualStyleBackColor = false;
            this.BntCalcularArea.Click += new System.EventHandler(this.BntCalcularArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(340, 285);
            this.Controls.Add(this.BntCalcularArea);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA DE AREA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Button BntCalcularArea;
    }
}

