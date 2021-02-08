namespace WindowsFormsApp2
{
    partial class TelaDeSangria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxCaixaAtual = new System.Windows.Forms.TextBox();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxObs = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSangria = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtBoxCaixaAtual);
            this.panel1.Controls.Add(this.lblCaixa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxObs);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConcluir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxSangria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 354);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBoxCaixaAtual
            // 
            this.txtBoxCaixaAtual.Enabled = false;
            this.txtBoxCaixaAtual.Location = new System.Drawing.Point(239, 70);
            this.txtBoxCaixaAtual.Name = "txtBoxCaixaAtual";
            this.txtBoxCaixaAtual.Size = new System.Drawing.Size(112, 20);
            this.txtBoxCaixaAtual.TabIndex = 8;
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(23, 61);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(187, 29);
            this.lblCaixa.TabIndex = 7;
            this.lblCaixa.Text = "Caixa atual: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo: *";
            // 
            // txtBoxObs
            // 
            this.txtBoxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObs.Location = new System.Drawing.Point(62, 152);
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(419, 125);
            this.txtBoxObs.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(116, 294);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(83, 38);
            this.btnConcluir.TabIndex = 3;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sangria: R$";
            // 
            // txtBoxSangria
            // 
            this.txtBoxSangria.Location = new System.Drawing.Point(239, 12);
            this.txtBoxSangria.Name = "txtBoxSangria";
            this.txtBoxSangria.Size = new System.Drawing.Size(112, 20);
            this.txtBoxSangria.TabIndex = 1;
            this.txtBoxSangria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSangria_KeyDown);
            // 
            // TelaDeSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 354);
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSangria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxObs;
        private System.Windows.Forms.TextBox txtBoxCaixaAtual;
        private System.Windows.Forms.Label lblCaixa;
    }
}