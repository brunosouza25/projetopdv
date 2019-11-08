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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesquisaProd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Bt_Cancelar_Venda = new System.Windows.Forms.Button();
            this.Bt_Vendas = new System.Windows.Forms.Button();
            this.Bt_Remover_Prod = new System.Windows.Forms.Button();
            this.Bt_Add_Prod = new System.Windows.Forms.Button();
            this.panel_Total = new System.Windows.Forms.Panel();
            this.Lab_Subt_Total = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pesquisaProd, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.548388F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45161F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(908, 475);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(902, 429);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código de Barras";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tamanho";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cor";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valor";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Desconto";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total";
            // 
            // pesquisaProd
            // 
            this.pesquisaProd.BackColor = System.Drawing.SystemColors.Info;
            this.pesquisaProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesquisaProd.Location = new System.Drawing.Point(3, 3);
            this.pesquisaProd.Multiline = true;
            this.pesquisaProd.Name = "pesquisaProd";
            this.pesquisaProd.Size = new System.Drawing.Size(902, 34);
            this.pesquisaProd.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 481);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel_Total, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(914, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 481);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Bt_Cancelar_Venda, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Vendas, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Add_Prod, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Remover_Prod, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(344, 235);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // Bt_Cancelar_Venda
            // 
            this.Bt_Cancelar_Venda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Cancelar_Venda.Location = new System.Drawing.Point(3, 120);
            this.Bt_Cancelar_Venda.Name = "Bt_Cancelar_Venda";
            this.Bt_Cancelar_Venda.Size = new System.Drawing.Size(166, 112);
            this.Bt_Cancelar_Venda.TabIndex = 3;
            this.Bt_Cancelar_Venda.Text = "Cancelar Venda";
            this.Bt_Cancelar_Venda.UseVisualStyleBackColor = true;
            // 
            // Bt_Vendas
            // 
            this.Bt_Vendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Vendas.Location = new System.Drawing.Point(175, 120);
            this.Bt_Vendas.Name = "Bt_Vendas";
            this.Bt_Vendas.Size = new System.Drawing.Size(166, 112);
            this.Bt_Vendas.TabIndex = 2;
            this.Bt_Vendas.Text = "Vendas";
            this.Bt_Vendas.UseVisualStyleBackColor = true;
            // 
            // Bt_Remover_Prod
            // 
            this.Bt_Remover_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Remover_Prod.Location = new System.Drawing.Point(175, 3);
            this.Bt_Remover_Prod.Name = "Bt_Remover_Prod";
            this.Bt_Remover_Prod.Size = new System.Drawing.Size(166, 111);
            this.Bt_Remover_Prod.TabIndex = 4;
            this.Bt_Remover_Prod.Text = "Remover Produto";
            this.Bt_Remover_Prod.UseVisualStyleBackColor = true;
            // 
            // Bt_Add_Prod
            // 
            this.Bt_Add_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Add_Prod.Location = new System.Drawing.Point(3, 3);
            this.Bt_Add_Prod.Name = "Bt_Add_Prod";
            this.Bt_Add_Prod.Size = new System.Drawing.Size(166, 111);
            this.Bt_Add_Prod.TabIndex = 1;
            this.Bt_Add_Prod.Text = "Adicionar Produto";
            this.Bt_Add_Prod.UseVisualStyleBackColor = true;
            // 
            // panel_Total
            // 
            this.panel_Total.Controls.Add(this.Lab_Subt_Total);
            this.panel_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Total.Location = new System.Drawing.Point(3, 3);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(344, 234);
            this.panel_Total.TabIndex = 1;
            // 
            // Lab_Subt_Total
            // 
            this.Lab_Subt_Total.AutoSize = true;
            this.Lab_Subt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Subt_Total.Location = new System.Drawing.Point(56, 106);
            this.Lab_Subt_Total.Name = "Lab_Subt_Total";
            this.Lab_Subt_Total.Size = new System.Drawing.Size(125, 31);
            this.Lab_Subt_Total.TabIndex = 0;
            this.Lab_Subt_Total.Text = "R$: 0,00";
            // 
            // listaDoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "listaDoCaixa";
            this.Size = new System.Drawing.Size(1264, 481);
            this.Load += new System.EventHandler(this.listaDoCaixa_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel_Total.ResumeLayout(false);
            this.panel_Total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox pesquisaProd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button Bt_Vendas;
        private System.Windows.Forms.Button Bt_Cancelar_Venda;
        private System.Windows.Forms.Button Bt_Remover_Prod;
        private System.Windows.Forms.Button Bt_Add_Prod;
        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.Label Lab_Subt_Total;
    }
}
