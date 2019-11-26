namespace WindowsFormsApp2
{
    partial class listaDoCaixa
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listaCaixa = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Bt_Cancelar_Venda = new System.Windows.Forms.Button();
            this.Bt_Add_Prod = new System.Windows.Forms.Button();
            this.Bt_Remover_Prod = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFinalizarVenda = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listaCaixa, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtBoxPesquisaProd, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.548388F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45161F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(908, 595);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
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
            this.listaCaixa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCaixa.FullRowSelect = true;
            this.listaCaixa.GridLines = true;
            this.listaCaixa.HideSelection = false;
            this.listaCaixa.Location = new System.Drawing.Point(3, 53);
            this.listaCaixa.Name = "listaCaixa";
            this.listaCaixa.Size = new System.Drawing.Size(902, 539);
            this.listaCaixa.TabIndex = 2;
            this.listaCaixa.UseCompatibleStateImageBehavior = false;
            this.listaCaixa.View = System.Windows.Forms.View.Details;
            this.listaCaixa.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.listaCaixa_ControlRemoved);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Cod de Barras";
            this.columnHeader13.Width = 95;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Valor";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "0";
            this.columnHeader2.Width = 0;
            // 
            // TxtBoxPesquisaProd
            // 
            this.TxtBoxPesquisaProd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxPesquisaProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxPesquisaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisaProd.Location = new System.Drawing.Point(3, 3);
            this.TxtBoxPesquisaProd.Name = "TxtBoxPesquisaProd";
            this.TxtBoxPesquisaProd.Size = new System.Drawing.Size(902, 44);
            this.TxtBoxPesquisaProd.TabIndex = 1;
            this.TxtBoxPesquisaProd.TextChanged += new System.EventHandler(this.TxtBoxPesquisaProd_TextChanged);
            this.TxtBoxPesquisaProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxPesquisaProd_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.31013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.68987F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 601);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(914, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 601);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BtnFinalizarVenda, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Cancelar_Venda, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Add_Prod, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Remover_Prod, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(344, 295);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // Bt_Cancelar_Venda
            // 
            this.Bt_Cancelar_Venda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Cancelar_Venda.Location = new System.Drawing.Point(175, 150);
            this.Bt_Cancelar_Venda.Name = "Bt_Cancelar_Venda";
            this.Bt_Cancelar_Venda.Size = new System.Drawing.Size(166, 142);
            this.Bt_Cancelar_Venda.TabIndex = 3;
            this.Bt_Cancelar_Venda.Text = "Cancelar Venda";
            this.Bt_Cancelar_Venda.UseVisualStyleBackColor = true;
            this.Bt_Cancelar_Venda.Click += new System.EventHandler(this.Bt_Cancelar_Venda_Click);
            // 
            // Bt_Add_Prod
            // 
            this.Bt_Add_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Add_Prod.Location = new System.Drawing.Point(3, 3);
            this.Bt_Add_Prod.Name = "Bt_Add_Prod";
            this.Bt_Add_Prod.Size = new System.Drawing.Size(166, 141);
            this.Bt_Add_Prod.TabIndex = 1;
            this.Bt_Add_Prod.Text = "Adicionar Produto";
            this.Bt_Add_Prod.UseVisualStyleBackColor = true;
            this.Bt_Add_Prod.Click += new System.EventHandler(this.Bt_Add_Prod_Click);
            // 
            // Bt_Remover_Prod
            // 
            this.Bt_Remover_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Remover_Prod.Location = new System.Drawing.Point(175, 3);
            this.Bt_Remover_Prod.Name = "Bt_Remover_Prod";
            this.Bt_Remover_Prod.Size = new System.Drawing.Size(166, 141);
            this.Bt_Remover_Prod.TabIndex = 4;
            this.Bt_Remover_Prod.Text = "Remover Produto";
            this.Bt_Remover_Prod.UseVisualStyleBackColor = true;
            this.Bt_Remover_Prod.Click += new System.EventHandler(this.Bt_Remover_Prod_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.67347F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(344, 294);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 240);
            this.panel1.TabIndex = 0;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(66, 125);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(197, 33);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "Total: R$ 0,00";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 42);
            this.panel2.TabIndex = 1;
            // 
            // BtnFinalizarVenda
            // 
            this.BtnFinalizarVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFinalizarVenda.Location = new System.Drawing.Point(3, 150);
            this.BtnFinalizarVenda.Name = "BtnFinalizarVenda";
            this.BtnFinalizarVenda.Size = new System.Drawing.Size(166, 142);
            this.BtnFinalizarVenda.TabIndex = 5;
            this.BtnFinalizarVenda.Text = "Finalizar Venda";
            this.BtnFinalizarVenda.UseVisualStyleBackColor = true;
            this.BtnFinalizarVenda.Click += new System.EventHandler(this.BtnFinalizarVenda_Click_1);
            // 
            // listaDoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "listaDoCaixa";
            this.Size = new System.Drawing.Size(1264, 601);
            this.Load += new System.EventHandler(this.listaDoCaixa_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listaCaixa;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TextBox TxtBoxPesquisaProd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Bt_Cancelar_Venda;
        private System.Windows.Forms.Button Bt_Add_Prod;
        private System.Windows.Forms.Button Bt_Remover_Prod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnFinalizarVenda;
    }
}
