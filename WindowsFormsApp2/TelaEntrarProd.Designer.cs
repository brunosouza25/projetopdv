namespace WindowsFormsApp2
{
    partial class TelaEntrarProd
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
            this.painel_CriarProd = new System.Windows.Forms.Panel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.TxtBoxQuant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtEntrarQuant = new System.Windows.Forms.Button();
            this.painel_CriarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_CriarProd
            // 
            this.painel_CriarProd.BackColor = System.Drawing.SystemColors.Highlight;
            this.painel_CriarProd.Controls.Add(this.BtCancelar);
            this.painel_CriarProd.Controls.Add(this.TxtBoxQuant);
            this.painel_CriarProd.Controls.Add(this.label3);
            this.painel_CriarProd.Controls.Add(this.BtEntrarQuant);
            this.painel_CriarProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_CriarProd.Location = new System.Drawing.Point(0, 0);
            this.painel_CriarProd.Name = "painel_CriarProd";
            this.painel_CriarProd.Size = new System.Drawing.Size(419, 248);
            this.painel_CriarProd.TabIndex = 1;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(267, 158);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 40);
            this.BtCancelar.TabIndex = 9;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // TxtBoxQuant
            // 
            this.TxtBoxQuant.Location = new System.Drawing.Point(250, 72);
            this.TxtBoxQuant.Name = "TxtBoxQuant";
            this.TxtBoxQuant.Size = new System.Drawing.Size(92, 20);
            this.TxtBoxQuant.TabIndex = 8;
            this.TxtBoxQuant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxQuant_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // BtEntrarQuant
            // 
            this.BtEntrarQuant.Location = new System.Drawing.Point(72, 158);
            this.BtEntrarQuant.Name = "BtEntrarQuant";
            this.BtEntrarQuant.Size = new System.Drawing.Size(80, 40);
            this.BtEntrarQuant.TabIndex = 0;
            this.BtEntrarQuant.Text = "Entrar";
            this.BtEntrarQuant.UseVisualStyleBackColor = true;
            this.BtEntrarQuant.Click += new System.EventHandler(this.BtEntrarQuant_Click);
            // 
            // TelaEntrarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 248);
            this.Controls.Add(this.painel_CriarProd);
            this.Name = "TelaEntrarProd";
            this.Load += new System.EventHandler(this.TelaEntrarProd_Load);
            this.painel_CriarProd.ResumeLayout(false);
            this.painel_CriarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_CriarProd;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.TextBox TxtBoxQuant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtEntrarQuant;
    }
}