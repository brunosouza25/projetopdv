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
            this.painelPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPagamento
            // 
            this.painelPagamento.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.painelPagamento.Size = new System.Drawing.Size(573, 305);
            this.painelPagamento.TabIndex = 0;
            // 
            // LblFalta
            // 
            this.LblFalta.AutoSize = true;
            this.LblFalta.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFalta.Location = new System.Drawing.Point(297, 88);
            this.LblFalta.Name = "LblFalta";
            this.LblFalta.Size = new System.Drawing.Size(133, 33);
            this.LblFalta.TabIndex = 17;
            this.LblFalta.Text = "Falta: R$";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(65, 231);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(104, 42);
            this.BtnFinalizar.TabIndex = 16;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 232);
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
            this.LblTroco.Location = new System.Drawing.Point(297, 141);
            this.LblTroco.Name = "LblTroco";
            this.LblTroco.Size = new System.Drawing.Size(143, 33);
            this.LblTroco.TabIndex = 14;
            this.LblTroco.Text = "Troco: R$";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(297, 31);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(131, 33);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "Total: R$";
            // 
            // TxtBoxDinheiro
            // 
            this.TxtBoxDinheiro.Location = new System.Drawing.Point(145, 100);
            this.TxtBoxDinheiro.Name = "TxtBoxDinheiro";
            this.TxtBoxDinheiro.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDinheiro.TabIndex = 4;
            this.TxtBoxDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxDinheiro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinheiro";
            // 
            // TelaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 305);
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
    }
}