namespace WindowsFormsApp2.Estoque.View
{
    partial class SaidaDeProduto
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
            this.btnSaidaDeProduto = new System.Windows.Forms.Button();
            this.btnUltimos3Meses = new System.Windows.Forms.Button();
            this.btnPerso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAteMes = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxDeMes = new System.Windows.Forms.MaskedTextBox();
            this.btnMesPassado = new System.Windows.Forms.Button();
            this.btnEsteMes = new System.Windows.Forms.Button();
            this.btn7Dias = new System.Windows.Forms.Button();
            this.btnOntem = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoje = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listaSaidas = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaidaDeProduto
            // 
            this.btnSaidaDeProduto.Location = new System.Drawing.Point(91, 5);
            this.btnSaidaDeProduto.Name = "btnSaidaDeProduto";
            this.btnSaidaDeProduto.Size = new System.Drawing.Size(112, 81);
            this.btnSaidaDeProduto.TabIndex = 0;
            this.btnSaidaDeProduto.Text = "Nova Saida de Produto";
            this.btnSaidaDeProduto.UseVisualStyleBackColor = true;
            this.btnSaidaDeProduto.Click += new System.EventHandler(this.btnSaidaDeProduto_Click);
            // 
            // btnUltimos3Meses
            // 
            this.btnUltimos3Meses.Location = new System.Drawing.Point(0, 229);
            this.btnUltimos3Meses.Name = "btnUltimos3Meses";
            this.btnUltimos3Meses.Size = new System.Drawing.Size(277, 35);
            this.btnUltimos3Meses.TabIndex = 11;
            this.btnUltimos3Meses.Text = "Ultimos 3 meses";
            this.btnUltimos3Meses.UseVisualStyleBackColor = true;
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(3, 364);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(274, 35);
            this.btnPerso.TabIndex = 10;
            this.btnPerso.Text = "Personalizado";
            this.btnPerso.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "De";
            // 
            // txtBoxAteMes
            // 
            this.txtBoxAteMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAteMes.Location = new System.Drawing.Point(144, 315);
            this.txtBoxAteMes.Mask = "00/00/0000";
            this.txtBoxAteMes.Name = "txtBoxAteMes";
            this.txtBoxAteMes.Size = new System.Drawing.Size(130, 35);
            this.txtBoxAteMes.TabIndex = 7;
            this.txtBoxAteMes.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxDeMes
            // 
            this.txtBoxDeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeMes.Location = new System.Drawing.Point(3, 315);
            this.txtBoxDeMes.Mask = "00/00/0000";
            this.txtBoxDeMes.Name = "txtBoxDeMes";
            this.txtBoxDeMes.Size = new System.Drawing.Size(130, 35);
            this.txtBoxDeMes.TabIndex = 6;
            this.txtBoxDeMes.ValidatingType = typeof(System.DateTime);
            // 
            // btnMesPassado
            // 
            this.btnMesPassado.Location = new System.Drawing.Point(0, 188);
            this.btnMesPassado.Name = "btnMesPassado";
            this.btnMesPassado.Size = new System.Drawing.Size(277, 35);
            this.btnMesPassado.TabIndex = 5;
            this.btnMesPassado.Text = "Mês passado";
            this.btnMesPassado.UseVisualStyleBackColor = true;
            // 
            // btnEsteMes
            // 
            this.btnEsteMes.Location = new System.Drawing.Point(0, 147);
            this.btnEsteMes.Name = "btnEsteMes";
            this.btnEsteMes.Size = new System.Drawing.Size(277, 35);
            this.btnEsteMes.TabIndex = 4;
            this.btnEsteMes.Text = "Este mês";
            this.btnEsteMes.UseVisualStyleBackColor = true;
            // 
            // btn7Dias
            // 
            this.btn7Dias.Location = new System.Drawing.Point(0, 107);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Size = new System.Drawing.Size(277, 35);
            this.btn7Dias.TabIndex = 3;
            this.btn7Dias.Text = "Ultimos 7 dias";
            this.btn7Dias.UseVisualStyleBackColor = true;
            // 
            // btnOntem
            // 
            this.btnOntem.Location = new System.Drawing.Point(0, 68);
            this.btnOntem.Name = "btnOntem";
            this.btnOntem.Size = new System.Drawing.Size(277, 35);
            this.btnOntem.TabIndex = 2;
            this.btnOntem.Text = "Ontem";
            this.btnOntem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(966, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.85404F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.14596F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 507);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.30508F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 408);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUltimos3Meses);
            this.panel1.Controls.Add(this.btnPerso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxAteMes);
            this.panel1.Controls.Add(this.txtBoxDeMes);
            this.panel1.Controls.Add(this.btnMesPassado);
            this.panel1.Controls.Add(this.btnEsteMes);
            this.panel1.Controls.Add(this.btn7Dias);
            this.panel1.Controls.Add(this.btnOntem);
            this.panel1.Controls.Add(this.btnHoje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 402);
            this.panel1.TabIndex = 0;
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(0, 31);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(277, 35);
            this.btnHoje.TabIndex = 1;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaidaDeProduto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 87);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.86804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.13196F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 507);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listaSaidas, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.548388F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 501);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listaSaidas
            // 
            this.listaSaidas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listaSaidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader13,
            this.columnHeader12,
            this.columnHeader2});
            this.listaSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSaidas.FullRowSelect = true;
            this.listaSaidas.GridLines = true;
            this.listaSaidas.HideSelection = false;
            this.listaSaidas.Location = new System.Drawing.Point(3, 3);
            this.listaSaidas.Name = "listaSaidas";
            this.listaSaidas.Size = new System.Drawing.Size(954, 495);
            this.listaSaidas.TabIndex = 3;
            this.listaSaidas.UseCompatibleStateImageBehavior = false;
            this.listaSaidas.View = System.Windows.Forms.View.Details;
            this.listaSaidas.DoubleClick += new System.EventHandler(this.listaSaidas_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Saida";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Data Saida";
            this.columnHeader13.Width = 164;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Funcionario";
            this.columnHeader12.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Observação";
            this.columnHeader2.Width = 598;
            // 
            // SaidaDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SaidaDeProduto";
            this.Size = new System.Drawing.Size(1258, 507);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaidaDeProduto;
        private System.Windows.Forms.Button btnUltimos3Meses;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxAteMes;
        private System.Windows.Forms.MaskedTextBox txtBoxDeMes;
        private System.Windows.Forms.Button btnMesPassado;
        private System.Windows.Forms.Button btnEsteMes;
        private System.Windows.Forms.Button btn7Dias;
        private System.Windows.Forms.Button btnOntem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listaSaidas;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
