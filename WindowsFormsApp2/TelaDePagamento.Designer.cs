namespace WindowsFormsApp2
{
    partial class TelaDePagamento
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
            this.painelPagamento = new System.Windows.Forms.Panel();
            this.txtDeb = new System.Windows.Forms.TextBox();
            this.txtCredParc = new System.Windows.Forms.TextBox();
            this.txtCredVista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFalta = new System.Windows.Forms.Label();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblTroco = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtBoxDinheiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTotalAReceber = new System.Windows.Forms.Label();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.painelPagamento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPagamento
            // 
            this.painelPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.painelPagamento.Controls.Add(this.panel2);
            this.painelPagamento.Controls.Add(this.panel1);
            this.painelPagamento.Controls.Add(this.BtnFinalizar);
            this.painelPagamento.Controls.Add(this.button1);
            this.painelPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPagamento.Location = new System.Drawing.Point(0, 0);
            this.painelPagamento.Name = "painelPagamento";
            this.painelPagamento.Size = new System.Drawing.Size(881, 577);
            this.painelPagamento.TabIndex = 0;
            // 
            // txtDeb
            // 
            this.txtDeb.Location = new System.Drawing.Point(256, 237);
            this.txtDeb.Name = "txtDeb";
            this.txtDeb.Size = new System.Drawing.Size(100, 20);
            this.txtDeb.TabIndex = 6;
            this.txtDeb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeb_KeyDown);
            // 
            // txtCredParc
            // 
            this.txtCredParc.Location = new System.Drawing.Point(257, 323);
            this.txtCredParc.Name = "txtCredParc";
            this.txtCredParc.Size = new System.Drawing.Size(100, 20);
            this.txtCredParc.TabIndex = 7;
            this.txtCredParc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCredParc_KeyDown);
            // 
            // txtCredVista
            // 
            this.txtCredVista.ForeColor = System.Drawing.Color.DeepPink;
            this.txtCredVista.Location = new System.Drawing.Point(255, 154);
            this.txtCredVista.Name = "txtCredVista";
            this.txtCredVista.Size = new System.Drawing.Size(100, 20);
            this.txtCredVista.TabIndex = 5;
            this.txtCredVista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCredVista_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(38, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Débito_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(38, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Crédito parcelado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(31, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Crédito à vista___";
            // 
            // LblFalta
            // 
            this.LblFalta.AutoSize = true;
            this.LblFalta.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFalta.ForeColor = System.Drawing.Color.Red;
            this.LblFalta.Location = new System.Drawing.Point(15, 308);
            this.LblFalta.Name = "LblFalta";
            this.LblFalta.Size = new System.Drawing.Size(133, 33);
            this.LblFalta.TabIndex = 17;
            this.LblFalta.Text = "Falta: R$";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(70, 449);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(104, 42);
            this.BtnFinalizar.TabIndex = 8;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTroco
            // 
            this.LblTroco.AutoSize = true;
            this.LblTroco.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTroco.ForeColor = System.Drawing.Color.Green;
            this.LblTroco.Location = new System.Drawing.Point(9, 246);
            this.LblTroco.Name = "LblTroco";
            this.LblTroco.Size = new System.Drawing.Size(143, 33);
            this.LblTroco.TabIndex = 14;
            this.LblTroco.Text = "Troco: R$";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(15, 21);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(131, 33);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "Total: R$";
            // 
            // TxtBoxDinheiro
            // 
            this.TxtBoxDinheiro.Location = new System.Drawing.Point(256, 81);
            this.TxtBoxDinheiro.Name = "TxtBoxDinheiro";
            this.TxtBoxDinheiro.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDinheiro.TabIndex = 4;
            this.TxtBoxDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxDinheiro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinheiro________";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDeb);
            this.panel1.Controls.Add(this.TxtBoxDinheiro);
            this.panel1.Controls.Add(this.txtCredParc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCredVista);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 382);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Método";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Valor";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalAReceber);
            this.panel2.Controls.Add(this.txtBoxDesc);
            this.panel2.Controls.Add(this.lblDesc);
            this.panel2.Controls.Add(this.LblTotal);
            this.panel2.Controls.Add(this.LblTroco);
            this.panel2.Controls.Add(this.LblFalta);
            this.panel2.Location = new System.Drawing.Point(539, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 382);
            this.panel2.TabIndex = 25;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(17, 110);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(191, 33);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Desconto: R$";
            // 
            // lblTotalAReceber
            // 
            this.lblTotalAReceber.AutoSize = true;
            this.lblTotalAReceber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAReceber.Location = new System.Drawing.Point(11, 194);
            this.lblTotalAReceber.Name = "lblTotalAReceber";
            this.lblTotalAReceber.Size = new System.Drawing.Size(197, 24);
            this.lblTotalAReceber.TabIndex = 20;
            this.lblTotalAReceber.Text = "Total a Receber: R$";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDesc.Location = new System.Drawing.Point(214, 107);
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(100, 40);
            this.txtBoxDesc.TabIndex = 19;
            this.txtBoxDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxDesc_KeyDown);
            // 
            // TelaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 577);
            this.Controls.Add(this.painelPagamento);
            this.Name = "TelaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.painelPagamento.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTroco;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Label LblFalta;
        private System.Windows.Forms.TextBox TxtBoxDinheiro;
        private System.Windows.Forms.TextBox txtDeb;
        private System.Windows.Forms.TextBox txtCredParc;
        private System.Windows.Forms.TextBox txtCredVista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAReceber;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtBoxDesc;
    }
}