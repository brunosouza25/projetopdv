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
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1685, 128);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.painel_hora, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1685, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // painel_hora
            // 
            this.painel_hora.Controls.Add(this.Lab_Hora);
            this.painel_hora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_hora.Location = new System.Drawing.Point(846, 4);
            this.painel_hora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.painel_hora.Name = "painel_hora";
            this.painel_hora.Size = new System.Drawing.Size(835, 120);
            this.painel_hora.TabIndex = 4;
            // 
            // Lab_Hora
            // 
            this.Lab_Hora.AutoSize = true;
            this.Lab_Hora.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lab_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Hora.Location = new System.Drawing.Point(709, 0);
            this.Lab_Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Hora.Name = "Lab_Hora";
            this.Lab_Hora.Size = new System.Drawing.Size(126, 46);
            this.Lab_Hora.TabIndex = 0;
            this.Lab_Hora.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConfiguracoes);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblEstoque);
            this.panel1.Controls.Add(this.lblVendas);
            this.panel1.Controls.Add(this.btCaixa);
            this.panel1.Controls.Add(this.BtEstoque);
            this.panel1.Controls.Add(this.BtRelatorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 120);
            this.panel1.TabIndex = 5;
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(537, 95);
            this.lblConfiguracoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(152, 25);
            this.lblConfiguracoes.TabIndex = 7;
            this.lblConfiguracoes.Text = "Configurações";
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.relatorios;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Location = new System.Drawing.Point(555, 0);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(127, 91);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.BtConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Relatórios";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(196, 95);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(91, 25);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.Location = new System.Drawing.Point(28, 95);
            this.lblVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(86, 25);
            this.lblVendas.TabIndex = 3;
            this.lblVendas.Text = "Vendas";
            // 
            // btCaixa
            // 
            this.btCaixa.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.caixa_de_dinheiro;
            this.btCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCaixa.Location = new System.Drawing.Point(0, 0);
            this.btCaixa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCaixa.Name = "btCaixa";
            this.btCaixa.Size = new System.Drawing.Size(127, 91);
            this.btCaixa.TabIndex = 1;
            this.btCaixa.UseVisualStyleBackColor = true;
            this.btCaixa.Click += new System.EventHandler(this.BtCaixa_Click);
            // 
            // BtEstoque
            // 
            this.BtEstoque.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.estoque;
            this.BtEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEstoque.Location = new System.Drawing.Point(184, 0);
            this.BtEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtEstoque.Name = "BtEstoque";
            this.BtEstoque.Size = new System.Drawing.Size(127, 91);
            this.BtEstoque.TabIndex = 1;
            this.BtEstoque.UseVisualStyleBackColor = true;
            this.BtEstoque.Click += new System.EventHandler(this.BtEstoque_Click);
            // 
            // BtRelatorio
            // 
            this.BtRelatorio.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.relatorios;
            this.BtRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRelatorio.Location = new System.Drawing.Point(368, 0);
            this.BtRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtRelatorio.Name = "BtRelatorio";
            this.BtRelatorio.Size = new System.Drawing.Size(127, 91);
            this.BtRelatorio.TabIndex = 2;
            this.BtRelatorio.UseVisualStyleBackColor = true;
            this.BtRelatorio.Click += new System.EventHandler(this.BtRelatorio_Click);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 128);
            this.painelPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1685, 710);
            this.painelPrincipal.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Button btnConfig;
    }
}

