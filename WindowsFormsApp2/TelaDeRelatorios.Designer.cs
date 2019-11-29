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
            this.dados = new WindowsFormsApp2.Dados();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new WindowsFormsApp2.DadosTableAdapters.DataTable2TableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BtnSalvarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dados
            // 
            this.dados.DataSetName = "Dados";
            this.dados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.vendDataDataGridViewTextBoxColumn,
            this.valorCompraDataGridViewTextBoxColumn,
            this.pagamentoTipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1310, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "Código da Venda";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            this.idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendDataDataGridViewTextBoxColumn
            // 
            this.vendDataDataGridViewTextBoxColumn.DataPropertyName = "vendData";
            this.vendDataDataGridViewTextBoxColumn.HeaderText = "Data da Venda";
            this.vendDataDataGridViewTextBoxColumn.Name = "vendDataDataGridViewTextBoxColumn";
            this.vendDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            this.valorCompraDataGridViewTextBoxColumn.DataPropertyName = "valorCompra";
            this.valorCompraDataGridViewTextBoxColumn.HeaderText = "Valor da Venda";
            this.valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            this.valorCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagamentoTipoDataGridViewTextBoxColumn
            // 
            this.pagamentoTipoDataGridViewTextBoxColumn.DataPropertyName = "pagamentoTipo";
            this.pagamentoTipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Pagamento";
            this.pagamentoTipoDataGridViewTextBoxColumn.Name = "pagamentoTipoDataGridViewTextBoxColumn";
            this.pagamentoTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dados;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1310, 25);
            this.fillBy1ToolStrip.TabIndex = 1;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(142, 22);
            this.fillBy1ToolStripButton.Text = "Gerar relatório de vendas";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // BtnSalvarPDF
            // 
            this.BtnSalvarPDF.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pdf;
            this.BtnSalvarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalvarPDF.Location = new System.Drawing.Point(205, 3);
            this.BtnSalvarPDF.Name = "BtnSalvarPDF";
            this.BtnSalvarPDF.Size = new System.Drawing.Size(81, 77);
            this.BtnSalvarPDF.TabIndex = 2;
            this.BtnSalvarPDF.UseVisualStyleBackColor = true;
            this.BtnSalvarPDF.Click += new System.EventHandler(this.BtnSalvarPDF_Click);
            // 
            // TelaDeRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSalvarPDF);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaDeRelatorios";
            this.Size = new System.Drawing.Size(1310, 581);
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dados dados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DadosTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.Button BtnSalvarPDF;
    }
}
