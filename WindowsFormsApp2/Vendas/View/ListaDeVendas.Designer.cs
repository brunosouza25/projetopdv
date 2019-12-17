namespace WindowsFormsApp2.Vendas.View
{
    partial class ListaDeVendas
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
            this.listaVendas = new System.Windows.Forms.ListView();
            this.nulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listaVendas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 509);
            this.panel1.TabIndex = 0;
            // 
            // listaVendas
            // 
            this.listaVendas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listaVendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nulo,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listaVendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaVendas.FullRowSelect = true;
            this.listaVendas.GridLines = true;
            this.listaVendas.HideSelection = false;
            this.listaVendas.Location = new System.Drawing.Point(0, 0);
            this.listaVendas.MultiSelect = false;
            this.listaVendas.Name = "listaVendas";
            this.listaVendas.Size = new System.Drawing.Size(1258, 509);
            this.listaVendas.TabIndex = 3;
            this.listaVendas.UseCompatibleStateImageBehavior = false;
            this.listaVendas.View = System.Windows.Forms.View.Details;
            this.listaVendas.SelectedIndexChanged += new System.EventHandler(this.listaVendas_SelectedIndexChanged);
            this.listaVendas.DoubleClick += new System.EventHandler(this.listaVendas_DoubleClick);
            // 
            // nulo
            // 
            this.nulo.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código da venda";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data da venda";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 98;
            // 
            // ListaDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListaDeVendas";
            this.Size = new System.Drawing.Size(1258, 509);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listaVendas;
        private System.Windows.Forms.ColumnHeader nulo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
