namespace WindowsFormsApp2
{
    partial class TelaPrincipalEstoque
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
            this.painelPrincipalEstoque = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.painelPrincipalDoEstoque = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaidaProduto = new System.Windows.Forms.Button();
            this.btnEntradaProduto = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.painelPrincipalEstoque.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPrincipalEstoque
            // 
            this.painelPrincipalEstoque.Controls.Add(this.tableLayoutPanel1);
            this.painelPrincipalEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipalEstoque.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipalEstoque.Name = "painelPrincipalEstoque";
            this.painelPrincipalEstoque.Size = new System.Drawing.Size(1264, 577);
            this.painelPrincipalEstoque.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.painelPrincipalDoEstoque, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.73483F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // painelPrincipalDoEstoque
            // 
            this.painelPrincipalDoEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipalDoEstoque.Location = new System.Drawing.Point(3, 67);
            this.painelPrincipalDoEstoque.Name = "painelPrincipalDoEstoque";
            this.painelPrincipalDoEstoque.Size = new System.Drawing.Size(1258, 507);
            this.painelPrincipalDoEstoque.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaidaProduto);
            this.panel2.Controls.Add(this.btnEntradaProduto);
            this.panel2.Controls.Add(this.btnEstoque);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnSaidaProduto
            // 
            this.btnSaidaProduto.Location = new System.Drawing.Point(203, 3);
            this.btnSaidaProduto.Name = "btnSaidaProduto";
            this.btnSaidaProduto.Size = new System.Drawing.Size(83, 55);
            this.btnSaidaProduto.TabIndex = 2;
            this.btnSaidaProduto.Text = "Saida de Produtos";
            this.btnSaidaProduto.UseVisualStyleBackColor = true;
            this.btnSaidaProduto.Click += new System.EventHandler(this.btnSaidaProduto_Click);
            // 
            // btnEntradaProduto
            // 
            this.btnEntradaProduto.Location = new System.Drawing.Point(114, 3);
            this.btnEntradaProduto.Name = "btnEntradaProduto";
            this.btnEntradaProduto.Size = new System.Drawing.Size(83, 55);
            this.btnEntradaProduto.TabIndex = 1;
            this.btnEntradaProduto.Text = "Entrada de Produtos";
            this.btnEntradaProduto.UseVisualStyleBackColor = true;
            this.btnEntradaProduto.Click += new System.EventHandler(this.btnEntradaProduto_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(25, 2);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(83, 55);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // TelaPrincipalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.painelPrincipalEstoque);
            this.Name = "TelaPrincipalEstoque";
            this.Size = new System.Drawing.Size(1264, 577);
            this.painelPrincipalEstoque.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelPrincipalEstoque;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel painelPrincipalDoEstoque;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaidaProduto;
        private System.Windows.Forms.Button btnEntradaProduto;
        private System.Windows.Forms.Button btnEstoque;
    }
}
