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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtBoxQnt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxPesquisaProd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Bt_Remover_Prod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Add_Prod = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFinalizarVenda = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_Cancelar_Venda = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.btnSangria = new System.Windows.Forms.Button();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listaCaixa, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.548388F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45161F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 575);
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
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.listaCaixa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCaixa.FullRowSelect = true;
            this.listaCaixa.GridLines = true;
            this.listaCaixa.HideSelection = false;
            this.listaCaixa.Location = new System.Drawing.Point(3, 52);
            this.listaCaixa.Name = "listaCaixa";
            this.listaCaixa.Size = new System.Drawing.Size(1010, 520);
            this.listaCaixa.TabIndex = 2;
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
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Cod de Barras";
            this.columnHeader13.Width = 159;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Valor";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qnt";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sub Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "0";
            this.columnHeader2.Width = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtBoxQnt);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.TxtBoxPesquisaProd);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1010, 43);
            this.panel8.TabIndex = 3;
            // 
            // txtBoxQnt
            // 
            this.txtBoxQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQnt.Location = new System.Drawing.Point(915, 3);
            this.txtBoxQnt.Mask = "00000";
            this.txtBoxQnt.Name = "txtBoxQnt";
            this.txtBoxQnt.Size = new System.Drawing.Size(92, 38);
            this.txtBoxQnt.TabIndex = 5;
            this.txtBoxQnt.ValidatingType = typeof(int);
            this.txtBoxQnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxQnt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            // 
            // TxtBoxPesquisaProd
            // 
            this.TxtBoxPesquisaProd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxPesquisaProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtBoxPesquisaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisaProd.Location = new System.Drawing.Point(0, 0);
            this.TxtBoxPesquisaProd.Name = "TxtBoxPesquisaProd";
            this.TxtBoxPesquisaProd.Size = new System.Drawing.Size(873, 40);
            this.TxtBoxPesquisaProd.TabIndex = 2;
            this.TxtBoxPesquisaProd.TextChanged += new System.EventHandler(this.TxtBoxPesquisaProd_TextChanged);
            this.TxtBoxPesquisaProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxPesquisaProd_KeyDown);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1022, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.03786F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.96214F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(242, 581);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.02817F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.97183F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(236, 355);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Bt_Remover_Prod);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(121, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 129);
            this.panel4.TabIndex = 7;
            // 
            // Bt_Remover_Prod
            // 
            this.Bt_Remover_Prod.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.remover_do_carrinho1;
            this.Bt_Remover_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Remover_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Remover_Prod.Location = new System.Drawing.Point(0, 0);
            this.Bt_Remover_Prod.Name = "Bt_Remover_Prod";
            this.Bt_Remover_Prod.Size = new System.Drawing.Size(112, 104);
            this.Bt_Remover_Prod.TabIndex = 6;
            this.Bt_Remover_Prod.UseVisualStyleBackColor = true;
            this.Bt_Remover_Prod.Click += new System.EventHandler(this.Bt_Remover_Prod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Retirar item";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Bt_Add_Prod);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 129);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar item";
            // 
            // Bt_Add_Prod
            // 
            this.Bt_Add_Prod.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.adicionar_ao_carrinho1;
            this.Bt_Add_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Add_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Add_Prod.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bt_Add_Prod.Location = new System.Drawing.Point(0, 0);
            this.Bt_Add_Prod.Name = "Bt_Add_Prod";
            this.Bt_Add_Prod.Size = new System.Drawing.Size(112, 104);
            this.Bt_Add_Prod.TabIndex = 2;
            this.Bt_Add_Prod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Add_Prod.UseVisualStyleBackColor = true;
            this.Bt_Add_Prod.Click += new System.EventHandler(this.Bt_Add_Prod_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.BtnFinalizarVenda);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 214);
            this.panel5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Finalizar venda";
            // 
            // BtnFinalizarVenda
            // 
            this.BtnFinalizarVenda.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.shopping_bag;
            this.BtnFinalizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFinalizarVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFinalizarVenda.Location = new System.Drawing.Point(0, 0);
            this.BtnFinalizarVenda.Name = "BtnFinalizarVenda";
            this.BtnFinalizarVenda.Size = new System.Drawing.Size(112, 97);
            this.BtnFinalizarVenda.TabIndex = 8;
            this.BtnFinalizarVenda.UseVisualStyleBackColor = true;
            this.BtnFinalizarVenda.Click += new System.EventHandler(this.BtnFinalizarVenda_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.Bt_Cancelar_Venda);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(121, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 214);
            this.panel6.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cancelar venda";
            // 
            // Bt_Cancelar_Venda
            // 
            this.Bt_Cancelar_Venda.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.error;
            this.Bt_Cancelar_Venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Cancelar_Venda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bt_Cancelar_Venda.Location = new System.Drawing.Point(0, 0);
            this.Bt_Cancelar_Venda.Name = "Bt_Cancelar_Venda";
            this.Bt_Cancelar_Venda.Size = new System.Drawing.Size(112, 94);
            this.Bt_Cancelar_Venda.TabIndex = 7;
            this.Bt_Cancelar_Venda.UseVisualStyleBackColor = true;
            this.Bt_Cancelar_Venda.Click += new System.EventHandler(this.Bt_Cancelar_Venda_Click);
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
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.05085F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.94915F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(236, 214);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 86);
            this.panel1.TabIndex = 0;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(3, 25);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(197, 33);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "Total: R$ 0,00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 116);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.lblCaixa);
            this.panel7.Controls.Add(this.btnSangria);
            this.panel7.Controls.Add(this.btnFecharCaixa);
            this.panel7.Controls.Add(this.btnAbrirCaixa);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 116);
            this.panel7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sangria";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(3, 96);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(84, 16);
            this.lblCaixa.TabIndex = 4;
            this.lblCaixa.Text = "Abrir caixa";
            // 
            // btnSangria
            // 
            this.btnSangria.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.retirar;
            this.btnSangria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSangria.Location = new System.Drawing.Point(118, 0);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(105, 93);
            this.btnSangria.TabIndex = 2;
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.fechar_caixa;
            this.btnFecharCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharCaixa.Location = new System.Drawing.Point(0, 0);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(105, 93);
            this.btnFecharCaixa.TabIndex = 1;
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Visible = false;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.abrir;
            this.btnAbrirCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(0, 0);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(105, 93);
            this.btnAbrirCaixa.TabIndex = 0;
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // listaDoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "listaDoCaixa";
            this.Size = new System.Drawing.Size(1264, 581);
            this.Load += new System.EventHandler(this.listaDoCaixa_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listaCaixa;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Bt_Add_Prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Bt_Remover_Prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFinalizarVenda;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_Cancelar_Venda;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBoxPesquisaProd;
        private System.Windows.Forms.MaskedTextBox txtBoxQnt;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
