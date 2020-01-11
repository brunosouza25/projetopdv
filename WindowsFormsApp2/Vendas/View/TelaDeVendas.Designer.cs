namespace WindowsFormsApp2.Vendas
{
    partial class TelaDeVendas
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
            this.painelP = new System.Windows.Forms.TableLayoutPanel();
            this.painelPrincipalDeVendas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPdv = new System.Windows.Forms.Button();
            this.BtnVendas = new System.Windows.Forms.Button();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.painelP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.painelP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 577);
            this.panel1.TabIndex = 0;
            // 
            // painelP
            // 
            this.painelP.ColumnCount = 1;
            this.painelP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.painelP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.painelP.Controls.Add(this.painelPrincipalDeVendas, 0, 1);
            this.painelP.Controls.Add(this.panel3, 0, 0);
            this.painelP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelP.Location = new System.Drawing.Point(0, 0);
            this.painelP.Name = "painelP";
            this.painelP.RowCount = 2;
            this.painelP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.91854F));
            this.painelP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.08146F));
            this.painelP.Size = new System.Drawing.Size(1264, 577);
            this.painelP.TabIndex = 0;
            // 
            // painelPrincipalDeVendas
            // 
            this.painelPrincipalDeVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipalDeVendas.Location = new System.Drawing.Point(3, 65);
            this.painelPrincipalDeVendas.Name = "painelPrincipalDeVendas";
            this.painelPrincipalDeVendas.Size = new System.Drawing.Size(1258, 509);
            this.painelPrincipalDeVendas.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDevolucao);
            this.panel3.Controls.Add(this.BtnPdv);
            this.panel3.Controls.Add(this.BtnVendas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 56);
            this.panel3.TabIndex = 3;
            // 
            // BtnPdv
            // 
            this.BtnPdv.Location = new System.Drawing.Point(179, 0);
            this.BtnPdv.Name = "BtnPdv";
            this.BtnPdv.Size = new System.Drawing.Size(170, 56);
            this.BtnPdv.TabIndex = 3;
            this.BtnPdv.Text = "PDV";
            this.BtnPdv.UseVisualStyleBackColor = true;
            this.BtnPdv.Click += new System.EventHandler(this.BtnPdv_Click);
            // 
            // BtnVendas
            // 
            this.BtnVendas.Location = new System.Drawing.Point(3, 0);
            this.BtnVendas.Name = "BtnVendas";
            this.BtnVendas.Size = new System.Drawing.Size(170, 56);
            this.BtnVendas.TabIndex = 2;
            this.BtnVendas.Text = "Vendas";
            this.BtnVendas.UseVisualStyleBackColor = true;
            this.BtnVendas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.Location = new System.Drawing.Point(360, 0);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(170, 56);
            this.btnDevolucao.TabIndex = 4;
            this.btnDevolucao.Text = "Devoluções";
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // TelaDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeVendas";
            this.Size = new System.Drawing.Size(1264, 577);
            this.panel1.ResumeLayout(false);
            this.painelP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel painelP;
        private System.Windows.Forms.Panel painelPrincipalDeVendas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnVendas;
        private System.Windows.Forms.Button BtnPdv;
        private System.Windows.Forms.Button btnDevolucao;
    }
}
