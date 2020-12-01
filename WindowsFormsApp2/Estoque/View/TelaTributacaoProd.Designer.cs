
namespace WindowsFormsApp2.Estoque.View
{
    partial class TelaTributacaoProd
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIcms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCofins = new System.Windows.Forms.TextBox();
            this.LabCofins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtPis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabCofins);
            this.panel1.Controls.Add(this.TxtIcms);
            this.panel1.Controls.Add(this.TxtCofins);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 343);
            this.panel1.TabIndex = 0;
            // 
            // TxtPis
            // 
            this.TxtPis.Location = new System.Drawing.Point(250, 100);
            this.TxtPis.Name = "TxtPis";
            this.TxtPis.Size = new System.Drawing.Size(128, 20);
            this.TxtPis.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pis";
            // 
            // TxtIcms
            // 
            this.TxtIcms.Location = new System.Drawing.Point(250, 241);
            this.TxtIcms.Name = "TxtIcms";
            this.TxtIcms.Size = new System.Drawing.Size(128, 20);
            this.TxtIcms.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ICMS";
            // 
            // TxtCofins
            // 
            this.TxtCofins.Location = new System.Drawing.Point(250, 170);
            this.TxtCofins.Name = "TxtCofins";
            this.TxtCofins.Size = new System.Drawing.Size(128, 20);
            this.TxtCofins.TabIndex = 10;
            // 
            // LabCofins
            // 
            this.LabCofins.AutoSize = true;
            this.LabCofins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCofins.Location = new System.Drawing.Point(94, 163);
            this.LabCofins.Name = "LabCofins";
            this.LabCofins.Size = new System.Drawing.Size(79, 25);
            this.LabCofins.TabIndex = 9;
            this.LabCofins.Text = "Cofins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tributação";
            // 
            // TelaTributacaoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaTributacaoProd";
            this.Size = new System.Drawing.Size(477, 343);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabCofins;
        private System.Windows.Forms.TextBox TxtIcms;
        private System.Windows.Forms.TextBox TxtCofins;
        private System.Windows.Forms.Label label1;
    }
}
