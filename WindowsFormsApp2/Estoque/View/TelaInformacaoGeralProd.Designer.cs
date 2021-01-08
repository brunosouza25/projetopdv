
namespace WindowsFormsApp2.Estoque.View
{
    partial class TelaInformacaoGeralProd
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
            this.painel_CriarProd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInativo = new System.Windows.Forms.Label();
            this.ckboxInativo = new System.Windows.Forms.CheckBox();
            this.TxtBoxCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCusto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.LabNomeProd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.painel_CriarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.painel_CriarProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 538);
            this.panel1.TabIndex = 0;
            // 
            // painel_CriarProd
            // 
            this.painel_CriarProd.BackColor = System.Drawing.SystemColors.Control;
            this.painel_CriarProd.Controls.Add(this.label4);
            this.painel_CriarProd.Controls.Add(this.lblInativo);
            this.painel_CriarProd.Controls.Add(this.ckboxInativo);
            this.painel_CriarProd.Controls.Add(this.TxtBoxCodBarras);
            this.painel_CriarProd.Controls.Add(this.label3);
            this.painel_CriarProd.Controls.Add(this.TxtBoxValor);
            this.painel_CriarProd.Controls.Add(this.label2);
            this.painel_CriarProd.Controls.Add(this.TxtBoxCusto);
            this.painel_CriarProd.Controls.Add(this.label1);
            this.painel_CriarProd.Controls.Add(this.TxtBoxNome);
            this.painel_CriarProd.Controls.Add(this.LabNomeProd);
            this.painel_CriarProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_CriarProd.Location = new System.Drawing.Point(0, 0);
            this.painel_CriarProd.Name = "painel_CriarProd";
            this.painel_CriarProd.Size = new System.Drawing.Size(561, 538);
            this.painel_CriarProd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Geral";
            // 
            // lblInativo
            // 
            this.lblInativo.AutoSize = true;
            this.lblInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInativo.Location = new System.Drawing.Point(320, 340);
            this.lblInativo.Name = "lblInativo";
            this.lblInativo.Size = new System.Drawing.Size(82, 29);
            this.lblInativo.TabIndex = 11;
            this.lblInativo.Text = "Inativo";
            // 
            // ckboxInativo
            // 
            this.ckboxInativo.AutoSize = true;
            this.ckboxInativo.Location = new System.Drawing.Point(417, 349);
            this.ckboxInativo.Name = "ckboxInativo";
            this.ckboxInativo.Size = new System.Drawing.Size(15, 14);
            this.ckboxInativo.TabIndex = 10;
            this.ckboxInativo.UseVisualStyleBackColor = true;
            // 
            // TxtBoxCodBarras
            // 
            this.TxtBoxCodBarras.Location = new System.Drawing.Point(349, 82);
            this.TxtBoxCodBarras.Name = "TxtBoxCodBarras";
            this.TxtBoxCodBarras.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxCodBarras.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cod de Barras:";
            // 
            // TxtBoxValor
            // 
            this.TxtBoxValor.Location = new System.Drawing.Point(349, 294);
            this.TxtBoxValor.Name = "TxtBoxValor";
            this.TxtBoxValor.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxValor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor de venda:";
            // 
            // TxtBoxCusto
            // 
            this.TxtBoxCusto.Location = new System.Drawing.Point(349, 223);
            this.TxtBoxCusto.Name = "TxtBoxCusto";
            this.TxtBoxCusto.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxCusto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custo:";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.Location = new System.Drawing.Point(349, 152);
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxNome.TabIndex = 2;
            // 
            // LabNomeProd
            // 
            this.LabNomeProd.AutoSize = true;
            this.LabNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNomeProd.Location = new System.Drawing.Point(68, 150);
            this.LabNomeProd.Name = "LabNomeProd";
            this.LabNomeProd.Size = new System.Drawing.Size(201, 25);
            this.LabNomeProd.TabIndex = 1;
            this.LabNomeProd.Text = "Nome do Produto:";
            // 
            // TelaInformacaoGeralProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaInformacaoGeralProd";
            this.Size = new System.Drawing.Size(561, 538);
            this.panel1.ResumeLayout(false);
            this.painel_CriarProd.ResumeLayout(false);
            this.painel_CriarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painel_CriarProd;
        private System.Windows.Forms.Label lblInativo;
        private System.Windows.Forms.CheckBox ckboxInativo;
        private System.Windows.Forms.TextBox TxtBoxCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Label LabNomeProd;
        private System.Windows.Forms.Label label4;
    }

    partial class CopyOfTelaInformacaoGeralProd
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
            this.painel_CriarProd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInativo = new System.Windows.Forms.Label();
            this.ckboxInativo = new System.Windows.Forms.CheckBox();
            this.TxtBoxCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCusto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.LabNomeProd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.painel_CriarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.painel_CriarProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 538);
            this.panel1.TabIndex = 0;
            // 
            // painel_CriarProd
            // 
            this.painel_CriarProd.BackColor = System.Drawing.SystemColors.Control;
            this.painel_CriarProd.Controls.Add(this.label4);
            this.painel_CriarProd.Controls.Add(this.lblInativo);
            this.painel_CriarProd.Controls.Add(this.ckboxInativo);
            this.painel_CriarProd.Controls.Add(this.TxtBoxCodBarras);
            this.painel_CriarProd.Controls.Add(this.label3);
            this.painel_CriarProd.Controls.Add(this.TxtBoxValor);
            this.painel_CriarProd.Controls.Add(this.label2);
            this.painel_CriarProd.Controls.Add(this.TxtBoxCusto);
            this.painel_CriarProd.Controls.Add(this.label1);
            this.painel_CriarProd.Controls.Add(this.TxtBoxNome);
            this.painel_CriarProd.Controls.Add(this.LabNomeProd);
            this.painel_CriarProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_CriarProd.Location = new System.Drawing.Point(0, 0);
            this.painel_CriarProd.Name = "painel_CriarProd";
            this.painel_CriarProd.Size = new System.Drawing.Size(561, 538);
            this.painel_CriarProd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Geral";
            // 
            // lblInativo
            // 
            this.lblInativo.AutoSize = true;
            this.lblInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInativo.Location = new System.Drawing.Point(320, 340);
            this.lblInativo.Name = "lblInativo";
            this.lblInativo.Size = new System.Drawing.Size(82, 29);
            this.lblInativo.TabIndex = 11;
            this.lblInativo.Text = "Inativo";
            // 
            // ckboxInativo
            // 
            this.ckboxInativo.AutoSize = true;
            this.ckboxInativo.Location = new System.Drawing.Point(417, 349);
            this.ckboxInativo.Name = "ckboxInativo";
            this.ckboxInativo.Size = new System.Drawing.Size(15, 14);
            this.ckboxInativo.TabIndex = 10;
            this.ckboxInativo.UseVisualStyleBackColor = true;
            // 
            // TxtBoxCodBarras
            // 
            this.TxtBoxCodBarras.Location = new System.Drawing.Point(349, 82);
            this.TxtBoxCodBarras.Name = "TxtBoxCodBarras";
            this.TxtBoxCodBarras.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxCodBarras.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cod de Barras:";
            // 
            // TxtBoxValor
            // 
            this.TxtBoxValor.Location = new System.Drawing.Point(349, 294);
            this.TxtBoxValor.Name = "TxtBoxValor";
            this.TxtBoxValor.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxValor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor de venda:";
            // 
            // TxtBoxCusto
            // 
            this.TxtBoxCusto.Location = new System.Drawing.Point(349, 223);
            this.TxtBoxCusto.Name = "TxtBoxCusto";
            this.TxtBoxCusto.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxCusto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custo:";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.Location = new System.Drawing.Point(349, 152);
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxNome.TabIndex = 2;
            // 
            // LabNomeProd
            // 
            this.LabNomeProd.AutoSize = true;
            this.LabNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNomeProd.Location = new System.Drawing.Point(68, 150);
            this.LabNomeProd.Name = "LabNomeProd";
            this.LabNomeProd.Size = new System.Drawing.Size(201, 25);
            this.LabNomeProd.TabIndex = 1;
            this.LabNomeProd.Text = "Nome do Produto:";
            // 
            // CopyOfTelaInformacaoGeralProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CopyOfTelaInformacaoGeralProd";
            this.Size = new System.Drawing.Size(561, 538);
            this.panel1.ResumeLayout(false);
            this.painel_CriarProd.ResumeLayout(false);
            this.painel_CriarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painel_CriarProd;
        private System.Windows.Forms.Label lblInativo;
        private System.Windows.Forms.CheckBox ckboxInativo;
        private System.Windows.Forms.TextBox TxtBoxCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Label LabNomeProd;
        private System.Windows.Forms.Label label4;
    }
}
