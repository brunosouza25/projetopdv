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
            this.LblFalta = new System.Windows.Forms.Label();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblTroco = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtBoxDinheiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCredVista = new System.Windows.Forms.TextBox();
            this.txtCredParc = new System.Windows.Forms.TextBox();
            this.txtDeb = new System.Windows.Forms.TextBox();
            this.painelPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPagamento
            // 
            this.painelPagamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.painelPagamento.Controls.Add(this.txtDeb);
            this.painelPagamento.Controls.Add(this.txtCredParc);
            this.painelPagamento.Controls.Add(this.txtCredVista);
            this.painelPagamento.Controls.Add(this.label4);
            this.painelPagamento.Controls.Add(this.label3);
            this.painelPagamento.Controls.Add(this.label2);
            this.painelPagamento.Controls.Add(this.LblFalta);
            this.painelPagamento.Controls.Add(this.BtnFinalizar);
            this.painelPagamento.Controls.Add(this.button1);
            this.painelPagamento.Controls.Add(this.LblTroco);
            this.painelPagamento.Controls.Add(this.LblTotal);
            this.painelPagamento.Controls.Add(this.TxtBoxDinheiro);
            this.painelPagamento.Controls.Add(this.label1);
            this.painelPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPagamento.Location = new System.Drawing.Point(0, 0);
            this.painelPagamento.Name = "painelPagamento";
            this.painelPagamento.Size = new System.Drawing.Size(638, 404);
            this.painelPagamento.TabIndex = 0;
            // 
            // LblFalta
            // 
            this.LblFalta.AutoSize = true;
            this.LblFalta.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFalta.Location = new System.Drawing.Point(373, 122);
            this.LblFalta.Name = "LblFalta";
            this.LblFalta.Size = new System.Drawing.Size(133, 33);
            this.LblFalta.TabIndex = 17;
            this.LblFalta.Text = "Falta: R$";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(80, 324);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(104, 42);
            this.BtnFinalizar.TabIndex = 16;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 324);
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
            this.LblTroco.Location = new System.Drawing.Point(373, 218);
            this.LblTroco.Name = "LblTroco";
            this.LblTroco.Size = new System.Drawing.Size(143, 33);
            this.LblTroco.TabIndex = 14;
            this.LblTroco.Text = "Troco: R$";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(373, 35);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(131, 33);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "Total: R$";
            // 
            // TxtBoxDinheiro
            // 
            this.TxtBoxDinheiro.Location = new System.Drawing.Point(234, 28);
            this.TxtBoxDinheiro.Name = "TxtBoxDinheiro";
            this.TxtBoxDinheiro.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDinheiro.TabIndex = 4;
            this.TxtBoxDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxDinheiro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinheiro________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Crédito à vista___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Crédito parcelado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Débito_________";
            // 
            // txtCredVista
            // 
            this.txtCredVista.Location = new System.Drawing.Point(233, 101);
            this.txtCredVista.Name = "txtCredVista";
            this.txtCredVista.Size = new System.Drawing.Size(100, 20);
            this.txtCredVista.TabIndex = 21;
            // 
            // txtCredParc
            // 
            this.txtCredParc.Location = new System.Drawing.Point(233, 174);
            this.txtCredParc.Name = "txtCredParc";
            this.txtCredParc.Size = new System.Drawing.Size(100, 20);
            this.txtCredParc.TabIndex = 22;
            // 
            // txtDeb
            // 
            this.txtDeb.Location = new System.Drawing.Point(234, 245);
            this.txtDeb.Name = "txtDeb";
            this.txtDeb.Size = new System.Drawing.Size(100, 20);
            this.txtDeb.TabIndex = 23;
            // 
            // TelaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 404);
            this.Controls.Add(this.painelPagamento);
            this.Name = "TelaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.painelPagamento.ResumeLayout(false);
            this.painelPagamento.PerformLayout();
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
    }
}