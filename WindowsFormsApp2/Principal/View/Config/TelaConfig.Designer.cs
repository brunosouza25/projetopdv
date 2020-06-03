namespace WindowsFormsApp2.Principal.View.Config
{
    partial class TelaConfig
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
            this.painelMainConfig = new System.Windows.Forms.Panel();
            this.PainelPrincipalConfig = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btColaboladores = new System.Windows.Forms.Button();
            this.PainelPrincipalConfig.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelMainConfig
            // 
            this.painelMainConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelMainConfig.Location = new System.Drawing.Point(3, 73);
            this.painelMainConfig.Name = "painelMainConfig";
            this.painelMainConfig.Size = new System.Drawing.Size(1252, 431);
            this.painelMainConfig.TabIndex = 1;
            // 
            // PainelPrincipalConfig
            // 
            this.PainelPrincipalConfig.Controls.Add(this.tableLayoutPanel1);
            this.PainelPrincipalConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelPrincipalConfig.Location = new System.Drawing.Point(0, 0);
            this.PainelPrincipalConfig.Name = "PainelPrincipalConfig";
            this.PainelPrincipalConfig.Size = new System.Drawing.Size(1258, 507);
            this.PainelPrincipalConfig.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.painelMainConfig, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.00394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.99606F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btColaboladores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 64);
            this.panel1.TabIndex = 0;
            // 
            // btColaboladores
            // 
            this.btColaboladores.Location = new System.Drawing.Point(37, 11);
            this.btColaboladores.Name = "btColaboladores";
            this.btColaboladores.Size = new System.Drawing.Size(86, 40);
            this.btColaboladores.TabIndex = 0;
            this.btColaboladores.Text = "Colaboladores";
            this.btColaboladores.UseVisualStyleBackColor = true;
            this.btColaboladores.Click += new System.EventHandler(this.btColaboladores_Click);
            // 
            // TelaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PainelPrincipalConfig);
            this.Name = "TelaConfig";
            this.Size = new System.Drawing.Size(1258, 507);
            this.PainelPrincipalConfig.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelMainConfig;
        private System.Windows.Forms.Panel PainelPrincipalConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btColaboladores;
    }
}
