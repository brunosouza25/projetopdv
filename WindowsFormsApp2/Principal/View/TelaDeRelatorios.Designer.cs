namespace WindowsFormsApp2
{
    partial class TelaDeRelatorios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeRelatorios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPerso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAteMes = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxDeMes = new System.Windows.Forms.MaskedTextBox();
            this.btnUltimos3Meses = new System.Windows.Forms.Button();
            this.btnMesPassado = new System.Windows.Forms.Button();
            this.btnEsteMes = new System.Windows.Forms.Button();
            this.btn7Dias = new System.Windows.Forms.Button();
            this.btnOntem = new System.Windows.Forms.Button();
            this.btnHoje = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnRelatorioDevolucoes = new System.Windows.Forms.Button();
            this.btnSangria = new System.Windows.Forms.Button();
            this.btnRelatorioCaixa = new System.Windows.Forms.Button();
            this.btnFechamentoDiario = new System.Windows.Forms.Button();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caixa1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixa1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 609);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.78978F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.21021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.painelPrincipal, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 609);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPerso);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtBoxAteMes);
            this.panel4.Controls.Add(this.txtBoxDeMes);
            this.panel4.Controls.Add(this.btnUltimos3Meses);
            this.panel4.Controls.Add(this.btnMesPassado);
            this.panel4.Controls.Add(this.btnEsteMes);
            this.panel4.Controls.Add(this.btn7Dias);
            this.panel4.Controls.Add(this.btnOntem);
            this.panel4.Controls.Add(this.btnHoje);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1014, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 603);
            this.panel4.TabIndex = 2;
            // 
            // btnPerso
            // 
            this.btnPerso.BackColor = System.Drawing.Color.Silver;
            this.btnPerso.Location = new System.Drawing.Point(7, 433);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(283, 35);
            this.btnPerso.TabIndex = 33;
            this.btnPerso.Text = "Personalizado";
            this.btnPerso.UseVisualStyleBackColor = true;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "De";
            // 
            // txtBoxAteMes
            // 
            this.txtBoxAteMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAteMes.Location = new System.Drawing.Point(154, 384);
            this.txtBoxAteMes.Mask = "00/00/0000";
            this.txtBoxAteMes.Name = "txtBoxAteMes";
            this.txtBoxAteMes.Size = new System.Drawing.Size(125, 35);
            this.txtBoxAteMes.TabIndex = 30;
            this.txtBoxAteMes.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxDeMes
            // 
            this.txtBoxDeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeMes.Location = new System.Drawing.Point(13, 384);
            this.txtBoxDeMes.Mask = "00/00/0000";
            this.txtBoxDeMes.Name = "txtBoxDeMes";
            this.txtBoxDeMes.Size = new System.Drawing.Size(118, 35);
            this.txtBoxDeMes.TabIndex = 29;
            this.txtBoxDeMes.ValidatingType = typeof(System.DateTime);
            // 
            // btnUltimos3Meses
            // 
            this.btnUltimos3Meses.BackColor = System.Drawing.Color.Silver;
            this.btnUltimos3Meses.Location = new System.Drawing.Point(3, 303);
            this.btnUltimos3Meses.Name = "btnUltimos3Meses";
            this.btnUltimos3Meses.Size = new System.Drawing.Size(286, 35);
            this.btnUltimos3Meses.TabIndex = 28;
            this.btnUltimos3Meses.Text = "Ultimos 3 meses";
            this.btnUltimos3Meses.UseVisualStyleBackColor = true;
            this.btnUltimos3Meses.Click += new System.EventHandler(this.btnUltimos3Meses_Click);
            // 
            // btnMesPassado
            // 
            this.btnMesPassado.BackColor = System.Drawing.Color.Silver;
            this.btnMesPassado.Location = new System.Drawing.Point(3, 262);
            this.btnMesPassado.Name = "btnMesPassado";
            this.btnMesPassado.Size = new System.Drawing.Size(286, 35);
            this.btnMesPassado.TabIndex = 27;
            this.btnMesPassado.Text = "Mês passado";
            this.btnMesPassado.UseVisualStyleBackColor = true;
            this.btnMesPassado.Click += new System.EventHandler(this.btnMesPassado_Click);
            // 
            // btnEsteMes
            // 
            this.btnEsteMes.BackColor = System.Drawing.Color.Silver;
            this.btnEsteMes.Location = new System.Drawing.Point(3, 221);
            this.btnEsteMes.Name = "btnEsteMes";
            this.btnEsteMes.Size = new System.Drawing.Size(286, 35);
            this.btnEsteMes.TabIndex = 26;
            this.btnEsteMes.Text = "Este mês";
            this.btnEsteMes.UseVisualStyleBackColor = true;
            this.btnEsteMes.Click += new System.EventHandler(this.btnEsteMes_Click);
            // 
            // btn7Dias
            // 
            this.btn7Dias.BackColor = System.Drawing.Color.Silver;
            this.btn7Dias.Location = new System.Drawing.Point(3, 181);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Size = new System.Drawing.Size(286, 35);
            this.btn7Dias.TabIndex = 25;
            this.btn7Dias.Text = "Ultimos 7 dias";
            this.btn7Dias.UseVisualStyleBackColor = true;
            this.btn7Dias.Click += new System.EventHandler(this.btn7Dias_Click);
            // 
            // btnOntem
            // 
            this.btnOntem.BackColor = System.Drawing.Color.Silver;
            this.btnOntem.Location = new System.Drawing.Point(3, 142);
            this.btnOntem.Name = "btnOntem";
            this.btnOntem.Size = new System.Drawing.Size(286, 35);
            this.btnOntem.TabIndex = 24;
            this.btnOntem.Text = "Ontem";
            this.btnOntem.UseVisualStyleBackColor = true;
            this.btnOntem.Click += new System.EventHandler(this.btnOntem_Click);
            // 
            // btnHoje
            // 
            this.btnHoje.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHoje.Location = new System.Drawing.Point(3, 105);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(286, 35);
            this.btnHoje.TabIndex = 23;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.UseVisualStyleBackColor = false;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnVendas);
            this.panel3.Controls.Add(this.btnRelatorioDevolucoes);
            this.panel3.Controls.Add(this.btnSangria);
            this.panel3.Controls.Add(this.btnRelatorioCaixa);
            this.panel3.Controls.Add(this.btnFechamentoDiario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 603);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Vendas canceladas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(0, 32);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(224, 23);
            this.btnVendas.TabIndex = 13;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRelatorioDevolucoes
            // 
            this.btnRelatorioDevolucoes.Location = new System.Drawing.Point(3, 161);
            this.btnRelatorioDevolucoes.Name = "btnRelatorioDevolucoes";
            this.btnRelatorioDevolucoes.Size = new System.Drawing.Size(224, 23);
            this.btnRelatorioDevolucoes.TabIndex = 12;
            this.btnRelatorioDevolucoes.Text = "Devoluções";
            this.btnRelatorioDevolucoes.UseVisualStyleBackColor = true;
            this.btnRelatorioDevolucoes.Click += new System.EventHandler(this.btnRelatorioDevolucoes_Click);
            // 
            // btnSangria
            // 
            this.btnSangria.Location = new System.Drawing.Point(3, 125);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(224, 23);
            this.btnSangria.TabIndex = 11;
            this.btnSangria.Text = "Sangria";
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // btnRelatorioCaixa
            // 
            this.btnRelatorioCaixa.Location = new System.Drawing.Point(3, 90);
            this.btnRelatorioCaixa.Name = "btnRelatorioCaixa";
            this.btnRelatorioCaixa.Size = new System.Drawing.Size(224, 23);
            this.btnRelatorioCaixa.TabIndex = 10;
            this.btnRelatorioCaixa.Text = "Caixa atual";
            this.btnRelatorioCaixa.UseVisualStyleBackColor = true;
            this.btnRelatorioCaixa.Click += new System.EventHandler(this.btnRelatorioCaixa_Click);
            // 
            // btnFechamentoDiario
            // 
            this.btnFechamentoDiario.Location = new System.Drawing.Point(0, 3);
            this.btnFechamentoDiario.Name = "btnFechamentoDiario";
            this.btnFechamentoDiario.Size = new System.Drawing.Size(224, 23);
            this.btnFechamentoDiario.TabIndex = 9;
            this.btnFechamentoDiario.Text = "Fechamento diário";
            this.btnFechamentoDiario.UseVisualStyleBackColor = true;
            this.btnFechamentoDiario.Click += new System.EventHandler(this.btnFechamentoDiario_Click_1);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.axAcroPDF1);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(233, 3);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(775, 603);
            this.painelPrincipal.TabIndex = 0;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(775, 603);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            // 
            // caixa1BindingSource
            // 
            this.caixa1BindingSource.DataMember = "Caixa1";
            // 
            // TelaDeRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeRelatorios";
            this.Size = new System.Drawing.Size(1310, 609);
            this.Load += new System.EventHandler(this.TelaDeRelatorios_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.painelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixa1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxAteMes;
        private System.Windows.Forms.MaskedTextBox txtBoxDeMes;
        private System.Windows.Forms.Button btnUltimos3Meses;
        private System.Windows.Forms.Button btnMesPassado;
        private System.Windows.Forms.Button btnEsteMes;
        private System.Windows.Forms.Button btn7Dias;
        private System.Windows.Forms.Button btnOntem;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.BindingSource caixa1BindingSource;
        private Dados dados1;
        private DadosTableAdapters.Caixa1TableAdapter caixa1TableAdapter;
        private DadosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private Dados dados;
        private DadosTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.Button btnFechamentoDiario;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnRelatorioDevolucoes;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.Button btnRelatorioCaixa;
        private System.Windows.Forms.Button button2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}
