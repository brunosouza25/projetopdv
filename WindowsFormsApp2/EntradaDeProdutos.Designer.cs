namespace WindowsFormsApp2
{
    partial class EntradaDeProdutos
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
            this.btnOntem = new System.Windows.Forms.Button();
            this.btnHoje = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listaCaixa = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEntrarProd = new System.Windows.Forms.Button();
            this.btn7Dias = new System.Windows.Forms.Button();
            this.btnEsteMes = new System.Windows.Forms.Button();
            this.btnMesPassado = new System.Windows.Forms.Button();
            this.txtBoxDeMes = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxAteMes = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPerso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 402);
            this.panel1.TabIndex = 0;
            // 
            // btnOntem
            // 
            this.btnOntem.Location = new System.Drawing.Point(0, 118);
            this.btnOntem.Name = "btnOntem";
            this.btnOntem.Size = new System.Drawing.Size(228, 35);
            this.btnOntem.TabIndex = 2;
            this.btnOntem.Text = "Ontem";
            this.btnOntem.UseVisualStyleBackColor = true;
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(0, 81);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(228, 35);
            this.btnHoje.TabIndex = 1;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(10, 10);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(215, 33);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "99/99/99  99:99";
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
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(234, 408);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listaCaixa, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.548388F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 501);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listaCaixa
            // 
            this.listaCaixa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listaCaixa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader13,
            this.columnHeader12,
            this.columnHeader2});
            this.listaCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCaixa.FullRowSelect = true;
            this.listaCaixa.GridLines = true;
            this.listaCaixa.HideSelection = false;
            this.listaCaixa.Location = new System.Drawing.Point(3, 3);
            this.listaCaixa.Name = "listaCaixa";
            this.listaCaixa.Size = new System.Drawing.Size(1006, 495);
            this.listaCaixa.TabIndex = 3;
            this.listaCaixa.UseCompatibleStateImageBehavior = false;
            this.listaCaixa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número entrada";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Data Entrada";
            this.columnHeader13.Width = 106;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Funcionario";
            this.columnHeader12.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Observação";
            this.columnHeader2.Width = 617;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.93355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.06646F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 507);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1018, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.85404F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.14596F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(240, 507);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEntrarProd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 87);
            this.panel2.TabIndex = 2;
            // 
            // btnEntrarProd
            // 
            this.btnEntrarProd.Location = new System.Drawing.Point(61, 3);
            this.btnEntrarProd.Name = "btnEntrarProd";
            this.btnEntrarProd.Size = new System.Drawing.Size(112, 81);
            this.btnEntrarProd.TabIndex = 0;
            this.btnEntrarProd.Text = "Entrar Produto";
            this.btnEntrarProd.UseVisualStyleBackColor = true;
            // 
            // btn7Dias
            // 
            this.btn7Dias.Location = new System.Drawing.Point(0, 157);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Size = new System.Drawing.Size(228, 35);
            this.btn7Dias.TabIndex = 3;
            this.btn7Dias.Text = "Ultimos 7 dias";
            this.btn7Dias.UseVisualStyleBackColor = true;
            // 
            // btnEsteMes
            // 
            this.btnEsteMes.Location = new System.Drawing.Point(0, 197);
            this.btnEsteMes.Name = "btnEsteMes";
            this.btnEsteMes.Size = new System.Drawing.Size(228, 35);
            this.btnEsteMes.TabIndex = 4;
            this.btnEsteMes.Text = "Este mês";
            this.btnEsteMes.UseVisualStyleBackColor = true;
            // 
            // btnMesPassado
            // 
            this.btnMesPassado.Location = new System.Drawing.Point(0, 238);
            this.btnMesPassado.Name = "btnMesPassado";
            this.btnMesPassado.Size = new System.Drawing.Size(228, 35);
            this.btnMesPassado.TabIndex = 5;
            this.btnMesPassado.Text = "Mês passado";
            this.btnMesPassado.UseVisualStyleBackColor = true;
            // 
            // txtBoxDeMes
            // 
            this.txtBoxDeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeMes.Location = new System.Drawing.Point(3, 315);
            this.txtBoxDeMes.Mask = "00/00/0000";
            this.txtBoxDeMes.Name = "txtBoxDeMes";
            this.txtBoxDeMes.Size = new System.Drawing.Size(100, 35);
            this.txtBoxDeMes.TabIndex = 6;
            this.txtBoxDeMes.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxAteMes
            // 
            this.txtBoxAteMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAteMes.Location = new System.Drawing.Point(125, 315);
            this.txtBoxAteMes.Mask = "00/00/0000";
            this.txtBoxAteMes.Name = "txtBoxAteMes";
            this.txtBoxAteMes.Size = new System.Drawing.Size(100, 35);
            this.txtBoxAteMes.TabIndex = 7;
            this.txtBoxAteMes.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Até";
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(3, 364);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(228, 35);
            this.btnPerso.TabIndex = 10;
            this.btnPerso.Text = "Personalizado";
            this.btnPerso.UseVisualStyleBackColor = true;
            // 
            // EntradaDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EntradaDeProdutos";
            this.Size = new System.Drawing.Size(1258, 507);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listaCaixa;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEntrarProd;
        private System.Windows.Forms.Button btnOntem;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxAteMes;
        private System.Windows.Forms.MaskedTextBox txtBoxDeMes;
        private System.Windows.Forms.Button btnMesPassado;
        private System.Windows.Forms.Button btnEsteMes;
        private System.Windows.Forms.Button btn7Dias;
    }
}
