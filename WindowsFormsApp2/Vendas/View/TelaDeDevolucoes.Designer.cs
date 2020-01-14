namespace WindowsFormsApp2.Vendas.View
{
    partial class TelaDeDevolucoes
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
            this.TxtBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPerso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAteMes = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxDeMes = new System.Windows.Forms.MaskedTextBox();
            this.btnUltimos3Meses = new System.Windows.Forms.Button();
            this.btnMesPassado = new System.Windows.Forms.Button();
            this.btnEsteMes = new System.Windows.Forms.Button();
            this.btn7Dias = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaDevolucoes = new System.Windows.Forms.ListView();
            this.btnOntem = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoje = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDevo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBoxPesquisaProd
            // 
            this.TxtBoxPesquisaProd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxPesquisaProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxPesquisaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisaProd.Location = new System.Drawing.Point(0, 0);
            this.TxtBoxPesquisaProd.Name = "TxtBoxPesquisaProd";
            this.TxtBoxPesquisaProd.Size = new System.Drawing.Size(948, 40);
            this.TxtBoxPesquisaProd.TabIndex = 3;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Produto";
            this.columnHeader4.Width = 359;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data da Devolução";
            this.columnHeader3.Width = 155;
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(4, 349);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(274, 35);
            this.btnPerso.TabIndex = 22;
            this.btnPerso.Text = "Personalizado";
            this.btnPerso.UseVisualStyleBackColor = true;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "De";
            // 
            // txtBoxAteMes
            // 
            this.txtBoxAteMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAteMes.Location = new System.Drawing.Point(154, 300);
            this.txtBoxAteMes.Mask = "00/00/0000";
            this.txtBoxAteMes.Name = "txtBoxAteMes";
            this.txtBoxAteMes.Size = new System.Drawing.Size(130, 35);
            this.txtBoxAteMes.TabIndex = 19;
            this.txtBoxAteMes.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxDeMes
            // 
            this.txtBoxDeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDeMes.Location = new System.Drawing.Point(13, 300);
            this.txtBoxDeMes.Mask = "00/00/0000";
            this.txtBoxDeMes.Name = "txtBoxDeMes";
            this.txtBoxDeMes.Size = new System.Drawing.Size(130, 35);
            this.txtBoxDeMes.TabIndex = 18;
            this.txtBoxDeMes.ValidatingType = typeof(System.DateTime);
            // 
            // btnUltimos3Meses
            // 
            this.btnUltimos3Meses.Location = new System.Drawing.Point(3, 219);
            this.btnUltimos3Meses.Name = "btnUltimos3Meses";
            this.btnUltimos3Meses.Size = new System.Drawing.Size(277, 35);
            this.btnUltimos3Meses.TabIndex = 17;
            this.btnUltimos3Meses.Text = "Ultimos 3 meses";
            this.btnUltimos3Meses.UseVisualStyleBackColor = true;
            this.btnUltimos3Meses.Click += new System.EventHandler(this.btnUltimos3Meses_Click);
            // 
            // btnMesPassado
            // 
            this.btnMesPassado.Location = new System.Drawing.Point(3, 178);
            this.btnMesPassado.Name = "btnMesPassado";
            this.btnMesPassado.Size = new System.Drawing.Size(277, 35);
            this.btnMesPassado.TabIndex = 16;
            this.btnMesPassado.Text = "Mês passado";
            this.btnMesPassado.UseVisualStyleBackColor = true;
            this.btnMesPassado.Click += new System.EventHandler(this.btnMesPassado_Click);
            // 
            // btnEsteMes
            // 
            this.btnEsteMes.Location = new System.Drawing.Point(3, 137);
            this.btnEsteMes.Name = "btnEsteMes";
            this.btnEsteMes.Size = new System.Drawing.Size(277, 35);
            this.btnEsteMes.TabIndex = 15;
            this.btnEsteMes.Text = "Este mês";
            this.btnEsteMes.UseVisualStyleBackColor = true;
            this.btnEsteMes.Click += new System.EventHandler(this.btnEsteMes_Click);
            // 
            // btn7Dias
            // 
            this.btn7Dias.Location = new System.Drawing.Point(3, 97);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Size = new System.Drawing.Size(277, 35);
            this.btn7Dias.TabIndex = 14;
            this.btn7Dias.Text = "Ultimos 7 dias";
            this.btn7Dias.UseVisualStyleBackColor = true;
            this.btn7Dias.Click += new System.EventHandler(this.btn7Dias_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código da Venda";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código Devolução";
            this.columnHeader1.Width = 204;
            // 
            // nulo
            // 
            this.nulo.Width = 0;
            // 
            // listaDevolucoes
            // 
            this.listaDevolucoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listaDevolucoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nulo,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listaDevolucoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaDevolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDevolucoes.FullRowSelect = true;
            this.listaDevolucoes.GridLines = true;
            this.listaDevolucoes.HideSelection = false;
            this.listaDevolucoes.Location = new System.Drawing.Point(3, 3);
            this.listaDevolucoes.MultiSelect = false;
            this.listaDevolucoes.Name = "listaDevolucoes";
            this.listaDevolucoes.Size = new System.Drawing.Size(940, 453);
            this.listaDevolucoes.TabIndex = 4;
            this.listaDevolucoes.UseCompatibleStateImageBehavior = false;
            this.listaDevolucoes.View = System.Windows.Forms.View.Details;
            // 
            // btnOntem
            // 
            this.btnOntem.Location = new System.Drawing.Point(3, 58);
            this.btnOntem.Name = "btnOntem";
            this.btnOntem.Size = new System.Drawing.Size(277, 35);
            this.btnOntem.TabIndex = 13;
            this.btnOntem.Text = "Ontem";
            this.btnOntem.UseVisualStyleBackColor = true;
            this.btnOntem.Click += new System.EventHandler(this.btnOntem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.823183F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.17682F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 503);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listaDevolucoes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 448);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtBoxPesquisaProd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 43);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 503);
            this.panel2.TabIndex = 0;
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(3, 21);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(277, 35);
            this.btnHoje.TabIndex = 12;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDevo);
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
            this.panel4.Location = new System.Drawing.Point(963, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 503);
            this.panel4.TabIndex = 1;
            // 
            // btnDevo
            // 
            this.btnDevo.Location = new System.Drawing.Point(4, 432);
            this.btnDevo.Name = "btnDevo";
            this.btnDevo.Size = new System.Drawing.Size(280, 68);
            this.btnDevo.TabIndex = 23;
            this.btnDevo.Text = "Nova Devolução";
            this.btnDevo.UseVisualStyleBackColor = true;
            this.btnDevo.Click += new System.EventHandler(this.btnDevo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.31161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68839F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 509);
            this.panel1.TabIndex = 1;
            // 
            // TelaDeDevolucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeDevolucoes";
            this.Size = new System.Drawing.Size(1258, 509);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxPesquisaProd;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxAteMes;
        private System.Windows.Forms.MaskedTextBox txtBoxDeMes;
        private System.Windows.Forms.Button btnUltimos3Meses;
        private System.Windows.Forms.Button btnMesPassado;
        private System.Windows.Forms.Button btnEsteMes;
        private System.Windows.Forms.Button btn7Dias;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader nulo;
        private System.Windows.Forms.ListView listaDevolucoes;
        private System.Windows.Forms.Button btnOntem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDevo;
    }
}
