namespace WindowsFormsApp2
{
    partial class TelaDeEstoque
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBoxPesquisaProdEstoque = new System.Windows.Forms.TextBox();
            this.listaProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Bt_Criar_Prod = new System.Windows.Forms.Button();
            this.Bt_Editar_Prod = new System.Windows.Forms.Button();
            this.Bt_Entrar_Prod = new System.Windows.Forms.Button();
            this.Bt_Retirar_Prod = new System.Windows.Forms.Button();
            this.panel_Total = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 581);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.7057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.2943F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 581);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.TxtBoxPesquisaProdEstoque, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listaProdutos, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.548388F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45161F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(913, 575);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // TxtBoxPesquisaProdEstoque
            // 
            this.TxtBoxPesquisaProdEstoque.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxPesquisaProdEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxPesquisaProdEstoque.Location = new System.Drawing.Point(3, 3);
            this.TxtBoxPesquisaProdEstoque.Multiline = true;
            this.TxtBoxPesquisaProdEstoque.Name = "TxtBoxPesquisaProdEstoque";
            this.TxtBoxPesquisaProdEstoque.Size = new System.Drawing.Size(907, 43);
            this.TxtBoxPesquisaProdEstoque.TabIndex = 1;
            // 
            // listaProdutos
            // 
            this.listaProdutos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader6,
            this.columnHeader7});
            this.listaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProdutos.FullRowSelect = true;
            this.listaProdutos.GridLines = true;
            this.listaProdutos.HideSelection = false;
            this.listaProdutos.Location = new System.Drawing.Point(3, 52);
            this.listaProdutos.MultiSelect = false;
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(907, 520);
            this.listaProdutos.TabIndex = 2;
            this.listaProdutos.UseCompatibleStateImageBehavior = false;
            this.listaProdutos.View = System.Windows.Forms.View.Details;
            this.listaProdutos.SelectedIndexChanged += new System.EventHandler(this.listaProdutos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Custo";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cod de Barras";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantidade";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.Width = 89;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel_Total, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(919, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.91394F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.08606F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(345, 581);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Bt_Criar_Prod, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Editar_Prod, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Entrar_Prod, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Bt_Retirar_Prod, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 292);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(339, 286);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // Bt_Criar_Prod
            // 
            this.Bt_Criar_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Criar_Prod.Location = new System.Drawing.Point(3, 146);
            this.Bt_Criar_Prod.Name = "Bt_Criar_Prod";
            this.Bt_Criar_Prod.Size = new System.Drawing.Size(163, 137);
            this.Bt_Criar_Prod.TabIndex = 3;
            this.Bt_Criar_Prod.Text = "Criar Produto";
            this.Bt_Criar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Criar_Prod.Click += new System.EventHandler(this.Bt_Criar_Prod_Click);
            // 
            // Bt_Editar_Prod
            // 
            this.Bt_Editar_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Editar_Prod.Location = new System.Drawing.Point(172, 146);
            this.Bt_Editar_Prod.Name = "Bt_Editar_Prod";
            this.Bt_Editar_Prod.Size = new System.Drawing.Size(164, 137);
            this.Bt_Editar_Prod.TabIndex = 2;
            this.Bt_Editar_Prod.Text = "Editar Produto";
            this.Bt_Editar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Editar_Prod.Click += new System.EventHandler(this.Bt_Editar_Prod_Click);
            // 
            // Bt_Entrar_Prod
            // 
            this.Bt_Entrar_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Entrar_Prod.Location = new System.Drawing.Point(3, 3);
            this.Bt_Entrar_Prod.Name = "Bt_Entrar_Prod";
            this.Bt_Entrar_Prod.Size = new System.Drawing.Size(163, 137);
            this.Bt_Entrar_Prod.TabIndex = 1;
            this.Bt_Entrar_Prod.Text = "Entrar Produto";
            this.Bt_Entrar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Entrar_Prod.Click += new System.EventHandler(this.Bt_Entrar_Prod_Click);
            // 
            // Bt_Retirar_Prod
            // 
            this.Bt_Retirar_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Retirar_Prod.Location = new System.Drawing.Point(172, 3);
            this.Bt_Retirar_Prod.Name = "Bt_Retirar_Prod";
            this.Bt_Retirar_Prod.Size = new System.Drawing.Size(164, 137);
            this.Bt_Retirar_Prod.TabIndex = 4;
            this.Bt_Retirar_Prod.Text = "Retirar Produto";
            this.Bt_Retirar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Retirar_Prod.Click += new System.EventHandler(this.Bt_Retirar_Prod_Click);
            // 
            // panel_Total
            // 
            this.panel_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Total.Location = new System.Drawing.Point(3, 3);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(339, 283);
            this.panel_Total.TabIndex = 1;
            // 
            // TelaDeEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeEstoque";
            this.Size = new System.Drawing.Size(1264, 581);
            this.Load += new System.EventHandler(this.TelaDeEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtBoxPesquisaProdEstoque;
        private System.Windows.Forms.ListView listaProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Bt_Criar_Prod;
        private System.Windows.Forms.Button Bt_Editar_Prod;
        private System.Windows.Forms.Button Bt_Entrar_Prod;
        private System.Windows.Forms.Button Bt_Retirar_Prod;
        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
