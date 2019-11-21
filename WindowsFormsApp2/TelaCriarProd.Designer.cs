namespace WindowsFormsApp2
{
    partial class TelaCriarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel_CriarProd = new System.Windows.Forms.Panel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.TxtBoxCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCusto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.LabNomeProd = new System.Windows.Forms.Label();
            this.BtCriar = new System.Windows.Forms.Button();
            this.ckboxInativo = new System.Windows.Forms.CheckBox();
            this.lblInativo = new System.Windows.Forms.Label();
            this.painel_CriarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_CriarProd
            // 
            this.painel_CriarProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.painel_CriarProd.Controls.Add(this.lblInativo);
            this.painel_CriarProd.Controls.Add(this.ckboxInativo);
            this.painel_CriarProd.Controls.Add(this.BtCancelar);
            this.painel_CriarProd.Controls.Add(this.TxtBoxCodBarras);
            this.painel_CriarProd.Controls.Add(this.label3);
            this.painel_CriarProd.Controls.Add(this.TxtBoxValor);
            this.painel_CriarProd.Controls.Add(this.label2);
            this.painel_CriarProd.Controls.Add(this.TxtBoxCusto);
            this.painel_CriarProd.Controls.Add(this.label1);
            this.painel_CriarProd.Controls.Add(this.TxtBoxNome);
            this.painel_CriarProd.Controls.Add(this.LabNomeProd);
            this.painel_CriarProd.Controls.Add(this.BtCriar);
            this.painel_CriarProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_CriarProd.Location = new System.Drawing.Point(0, 0);
            this.painel_CriarProd.Name = "painel_CriarProd";
            this.painel_CriarProd.Size = new System.Drawing.Size(443, 450);
            this.painel_CriarProd.TabIndex = 0;
            this.painel_CriarProd.Leave += new System.EventHandler(this.painel_CriarProd_Leave);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(293, 356);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 9;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // TxtBoxCodBarras
            // 
            this.TxtBoxCodBarras.Location = new System.Drawing.Point(239, 258);
            this.TxtBoxCodBarras.Name = "TxtBoxCodBarras";
            this.TxtBoxCodBarras.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxCodBarras.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cod de Barras:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtBoxValor
            // 
            this.TxtBoxValor.Location = new System.Drawing.Point(239, 185);
            this.TxtBoxValor.Name = "TxtBoxValor";
            this.TxtBoxValor.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxValor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor:";
            // 
            // TxtBoxCusto
            // 
            this.TxtBoxCusto.Location = new System.Drawing.Point(239, 114);
            this.TxtBoxCusto.Name = "TxtBoxCusto";
            this.TxtBoxCusto.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxCusto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custo:";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.Location = new System.Drawing.Point(239, 43);
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxNome.TabIndex = 2;
            // 
            // LabNomeProd
            // 
            this.LabNomeProd.AutoSize = true;
            this.LabNomeProd.Location = new System.Drawing.Point(83, 50);
            this.LabNomeProd.Name = "LabNomeProd";
            this.LabNomeProd.Size = new System.Drawing.Size(93, 13);
            this.LabNomeProd.TabIndex = 1;
            this.LabNomeProd.Text = "Nome do Produto:";
            // 
            // BtCriar
            // 
            this.BtCriar.Location = new System.Drawing.Point(62, 356);
            this.BtCriar.Name = "BtCriar";
            this.BtCriar.Size = new System.Drawing.Size(75, 23);
            this.BtCriar.TabIndex = 0;
            this.BtCriar.Text = "Criar";
            this.BtCriar.UseVisualStyleBackColor = true;
            this.BtCriar.Click += new System.EventHandler(this.BtCriar_Click);
            // 
            // ckboxInativo
            // 
            this.ckboxInativo.AutoSize = true;
            this.ckboxInativo.Location = new System.Drawing.Point(352, 317);
            this.ckboxInativo.Name = "ckboxInativo";
            this.ckboxInativo.Size = new System.Drawing.Size(15, 14);
            this.ckboxInativo.TabIndex = 10;
            this.ckboxInativo.UseVisualStyleBackColor = true;
            // 
            // lblInativo
            // 
            this.lblInativo.AutoSize = true;
            this.lblInativo.Location = new System.Drawing.Point(307, 317);
            this.lblInativo.Name = "lblInativo";
            this.lblInativo.Size = new System.Drawing.Size(39, 13);
            this.lblInativo.TabIndex = 11;
            this.lblInativo.Text = "Inativo";
            // 
            // TelaCriarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.painel_CriarProd);
            this.Name = "TelaCriarProd";
            this.Text = "TelaCriarProd";
            this.painel_CriarProd.ResumeLayout(false);
            this.painel_CriarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_CriarProd;
        private System.Windows.Forms.TextBox TxtBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Label LabNomeProd;
        private System.Windows.Forms.Button BtCriar;
        private System.Windows.Forms.TextBox TxtBoxCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label lblInativo;
        private System.Windows.Forms.CheckBox ckboxInativo;
    }
}