namespace WindowsFormsApp2.Principal.View.Config
{
    partial class TelaPrincipalColaboladores
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogins = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btColaboladores = new System.Windows.Forms.Button();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.painelPrincipal, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.16705F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogins);
            this.panel1.Controls.Add(this.btnCargos);
            this.panel1.Controls.Add(this.btColaboladores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnLogins
            // 
            this.btnLogins.Location = new System.Drawing.Point(242, 3);
            this.btnLogins.Name = "btnLogins";
            this.btnLogins.Size = new System.Drawing.Size(86, 40);
            this.btnLogins.TabIndex = 3;
            this.btnLogins.Text = "Logins";
            this.btnLogins.UseVisualStyleBackColor = true;
            this.btnLogins.Click += new System.EventHandler(this.btnLogins_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(131, 2);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(86, 40);
            this.btnCargos.TabIndex = 2;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btColaboladores
            // 
            this.btColaboladores.Location = new System.Drawing.Point(20, 3);
            this.btColaboladores.Name = "btColaboladores";
            this.btColaboladores.Size = new System.Drawing.Size(86, 40);
            this.btColaboladores.TabIndex = 1;
            this.btColaboladores.Text = "Colaboladores";
            this.btColaboladores.UseVisualStyleBackColor = true;
            this.btColaboladores.Click += new System.EventHandler(this.btColaboladores_Click);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(3, 54);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1246, 374);
            this.painelPrincipal.TabIndex = 1;
            // 
            // TelaPrincipalColaboladores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TelaPrincipalColaboladores";
            this.Size = new System.Drawing.Size(1252, 431);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Button btnLogins;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btColaboladores;
    }
}
