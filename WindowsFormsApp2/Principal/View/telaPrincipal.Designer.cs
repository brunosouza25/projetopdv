namespace WindowsFormsApp2
{
    partial class TelaPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.painel_hora = new System.Windows.Forms.Panel();
            this.Lab_Hora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCaixa = new System.Windows.Forms.Button();
            this.BtEstoque = new System.Windows.Forms.Button();
            this.BtRelatorio = new System.Windows.Forms.Button();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.painel_hora.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 104);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.painel_hora, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // painel_hora
            // 
            this.painel_hora.Controls.Add(this.Lab_Hora);
            this.painel_hora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_hora.Location = new System.Drawing.Point(635, 3);
            this.painel_hora.Name = "painel_hora";
            this.painel_hora.Size = new System.Drawing.Size(626, 98);
            this.painel_hora.TabIndex = 4;
            // 
            // Lab_Hora
            // 
            this.Lab_Hora.AutoSize = true;
            this.Lab_Hora.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lab_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Hora.Location = new System.Drawing.Point(526, 0);
            this.Lab_Hora.Name = "Lab_Hora";
            this.Lab_Hora.Size = new System.Drawing.Size(100, 37);
            this.Lab_Hora.TabIndex = 0;
            this.Lab_Hora.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btCaixa);
            this.panel1.Controls.Add(this.BtEstoque);
            this.panel1.Controls.Add(this.BtRelatorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 98);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Configurações";
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.relatorios;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Location = new System.Drawing.Point(416, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(95, 74);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.BtConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Relatórios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vendas";
            // 
            // btCaixa
            // 
            this.btCaixa.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.caixa_de_dinheiro;
            this.btCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCaixa.Location = new System.Drawing.Point(0, 0);
            this.btCaixa.Name = "btCaixa";
            this.btCaixa.Size = new System.Drawing.Size(95, 74);
            this.btCaixa.TabIndex = 1;
            this.btCaixa.UseVisualStyleBackColor = true;
            this.btCaixa.Click += new System.EventHandler(this.BtCaixa_Click);
            // 
            // BtEstoque
            // 
            this.BtEstoque.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.estoque;
            this.BtEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEstoque.Location = new System.Drawing.Point(138, 0);
            this.BtEstoque.Name = "BtEstoque";
            this.BtEstoque.Size = new System.Drawing.Size(95, 74);
            this.BtEstoque.TabIndex = 1;
            this.BtEstoque.UseVisualStyleBackColor = true;
            this.BtEstoque.Click += new System.EventHandler(this.BtEstoque_Click);
            // 
            // BtRelatorio
            // 
            this.BtRelatorio.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.relatorios;
            this.BtRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRelatorio.Location = new System.Drawing.Point(276, 0);
            this.BtRelatorio.Name = "BtRelatorio";
            this.BtRelatorio.Size = new System.Drawing.Size(95, 74);
            this.BtRelatorio.TabIndex = 2;
            this.BtRelatorio.UseVisualStyleBackColor = true;
            this.BtRelatorio.Click += new System.EventHandler(this.BtRelatorio_Click);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 104);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1264, 577);
            this.painelPrincipal.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.panel2);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.painel_hora.ResumeLayout(false);
            this.painel_hora.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtRelatorio;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Panel painel_hora;
        private System.Windows.Forms.Label Lab_Hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtEstoque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCaixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfig;
    }
}

