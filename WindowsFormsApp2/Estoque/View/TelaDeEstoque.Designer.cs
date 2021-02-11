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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Entrar_Prod = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Retirar_Prod = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_Editar_Prod = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Criar_Prod = new System.Windows.Forms.Button();
            this.panel_Total = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 507);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.21519F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.78481F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 507);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(965, 501);
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
            this.TxtBoxPesquisaProdEstoque.Size = new System.Drawing.Size(959, 36);
            this.TxtBoxPesquisaProdEstoque.TabIndex = 1;
            this.TxtBoxPesquisaProdEstoque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxPesquisaProdEstoque_KeyUp);
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
            this.listaProdutos.Location = new System.Drawing.Point(3, 45);
            this.listaProdutos.MultiSelect = false;
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(959, 453);
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
            this.columnHeader2.Width = 309;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Custo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor de venda";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cod de Barras";
            this.columnHeader5.Width = 152;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(971, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.65878F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.34122F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 507);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(281, 305);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Bt_Entrar_Prod);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 146);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entrar produtos";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Bt_Entrar_Prod
            // 
            this.Bt_Entrar_Prod.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.seta_de_download;
            this.Bt_Entrar_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Entrar_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Entrar_Prod.Enabled = false;
            this.Bt_Entrar_Prod.Location = new System.Drawing.Point(0, 0);
            this.Bt_Entrar_Prod.Name = "Bt_Entrar_Prod";
            this.Bt_Entrar_Prod.Size = new System.Drawing.Size(134, 123);
            this.Bt_Entrar_Prod.TabIndex = 2;
            this.Bt_Entrar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Entrar_Prod.Visible = false;
            this.Bt_Entrar_Prod.Click += new System.EventHandler(this.Bt_Entrar_Prod_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Bt_Retirar_Prod);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(143, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 146);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remover produtos";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bt_Retirar_Prod
            // 
            this.Bt_Retirar_Prod.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.seta_para_cima;
            this.Bt_Retirar_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Retirar_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Retirar_Prod.Enabled = false;
            this.Bt_Retirar_Prod.Location = new System.Drawing.Point(0, 0);
            this.Bt_Retirar_Prod.Name = "Bt_Retirar_Prod";
            this.Bt_Retirar_Prod.Size = new System.Drawing.Size(135, 123);
            this.Bt_Retirar_Prod.TabIndex = 5;
            this.Bt_Retirar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Retirar_Prod.Visible = false;
            this.Bt_Retirar_Prod.Click += new System.EventHandler(this.Bt_Retirar_Prod_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Bt_Editar_Prod);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(143, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 147);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Editar produto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bt_Editar_Prod
            // 
            this.Bt_Editar_Prod.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lapis;
            this.Bt_Editar_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Editar_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Editar_Prod.Location = new System.Drawing.Point(0, 0);
            this.Bt_Editar_Prod.Name = "Bt_Editar_Prod";
            this.Bt_Editar_Prod.Size = new System.Drawing.Size(135, 123);
            this.Bt_Editar_Prod.TabIndex = 3;
            this.Bt_Editar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Editar_Prod.Click += new System.EventHandler(this.Bt_Editar_Prod_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.Bt_Criar_Prod);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 147);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Criar produto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Bt_Criar_Prod
            // 
            this.Bt_Criar_Prod.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.criar_produto;
            this.Bt_Criar_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Criar_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Criar_Prod.Location = new System.Drawing.Point(0, 0);
            this.Bt_Criar_Prod.Name = "Bt_Criar_Prod";
            this.Bt_Criar_Prod.Size = new System.Drawing.Size(134, 123);
            this.Bt_Criar_Prod.TabIndex = 4;
            this.Bt_Criar_Prod.UseVisualStyleBackColor = true;
            this.Bt_Criar_Prod.Click += new System.EventHandler(this.Bt_Criar_Prod_Click);
            // 
            // panel_Total
            // 
            this.panel_Total.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Total.Location = new System.Drawing.Point(3, 3);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(281, 189);
            this.panel_Total.TabIndex = 1;
            this.panel_Total.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Total_Paint);
            // 
            // TelaDeEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeEstoque";
            this.Size = new System.Drawing.Size(1258, 507);
            this.Load += new System.EventHandler(this.TelaDeEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bt_Entrar_Prod;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Bt_Retirar_Prod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Bt_Editar_Prod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Bt_Criar_Prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
