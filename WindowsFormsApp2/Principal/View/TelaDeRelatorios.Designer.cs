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
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.relatorioCaixaToolStrip = new System.Windows.Forms.ToolStrip();
            this.relatorioCaixaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.caixa1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dados1 = new WindowsFormsApp2.Dados();
            this.caixa1TableAdapter = new WindowsFormsApp2.DadosTableAdapters.Caixa1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DadosTableAdapters.TableAdapterManager();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dados = new WindowsFormsApp2.Dados();
            this.dataTable2TableAdapter = new WindowsFormsApp2.DadosTableAdapters.DataTable2TableAdapter();
            this.fillBy1ToolStrip.SuspendLayout();
            this.relatorioCaixaToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caixa1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            this.SuspendLayout();
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
            // relatorioCaixaToolStrip
            // 
            this.relatorioCaixaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioCaixaToolStripButton});
            this.relatorioCaixaToolStrip.Location = new System.Drawing.Point(0, 25);
            this.relatorioCaixaToolStrip.Name = "relatorioCaixaToolStrip";
            this.relatorioCaixaToolStrip.Size = new System.Drawing.Size(1310, 25);
            this.relatorioCaixaToolStrip.TabIndex = 3;
            this.relatorioCaixaToolStrip.Text = "relatorioCaixaToolStrip";
            // 
            // relatorioCaixaToolStripButton
            // 
            this.relatorioCaixaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.relatorioCaixaToolStripButton.Name = "relatorioCaixaToolStripButton";
            this.relatorioCaixaToolStripButton.Size = new System.Drawing.Size(115, 22);
            this.relatorioCaixaToolStripButton.Text = "Relatório dos caixas";
            this.relatorioCaixaToolStripButton.Click += new System.EventHandler(this.relatorioCaixaToolStripButton_Click_1);
            // 
            // caixa1BindingSource
            // 
            this.caixa1BindingSource.DataMember = "Caixa1";
            this.caixa1BindingSource.DataSource = this.dados1;
            // 
            // dados1
            // 
            this.dados1.DataSetName = "Dados";
            this.dados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // caixa1TableAdapter
            // 
            this.caixa1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Caixa1TableAdapter = this.caixa1TableAdapter;
            this.tableAdapterManager.CaixaTableAdapter = null;
            this.tableAdapterManager.ItensDaVendaTableAdapter = null;
            this.tableAdapterManager.MetodoDePagamentoTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dados;
            // 
            // dados
            // 
            this.dados.DataSetName = "Dados";
            this.dados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // TelaDeRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.relatorioCaixaToolStrip);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Name = "TelaDeRelatorios";
            this.Size = new System.Drawing.Size(1310, 609);
            this.Load += new System.EventHandler(this.TelaDeRelatorios_Load);
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.relatorioCaixaToolStrip.ResumeLayout(false);
            this.relatorioCaixaToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caixa1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dados dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DadosTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private DadosTableAdapters.Caixa1TableAdapter caixa1TableAdapter;
        private DadosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource caixa1BindingSource;
        private Dados dados1;
        private System.Windows.Forms.ToolStrip relatorioCaixaToolStrip;
        private System.Windows.Forms.ToolStripButton relatorioCaixaToolStripButton;
    }
}
