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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnTributacao = new System.Windows.Forms.Button();
            this.BtnGeral = new System.Windows.Forms.Button();
            this.PainelPrincipal = new System.Windows.Forms.Panel();
            this.painel_CriarProd.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_CriarProd
            // 
            this.painel_CriarProd.BackColor = System.Drawing.SystemColors.Control;
            this.painel_CriarProd.Controls.Add(this.tableLayoutPanel1);
            this.painel_CriarProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_CriarProd.Location = new System.Drawing.Point(0, 0);
            this.painel_CriarProd.Name = "painel_CriarProd";
            this.painel_CriarProd.Size = new System.Drawing.Size(573, 585);
            this.painel_CriarProd.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PainelPrincipal, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.78143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 62);
            this.panel2.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(384, 8);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 47);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(105, 8);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 47);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnTributacao);
            this.panel1.Controls.Add(this.BtnGeral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 52);
            this.panel1.TabIndex = 0;
            // 
            // BtnTributacao
            // 
            this.BtnTributacao.Location = new System.Drawing.Point(105, 2);
            this.BtnTributacao.Name = "BtnTributacao";
            this.BtnTributacao.Size = new System.Drawing.Size(98, 47);
            this.BtnTributacao.TabIndex = 15;
            this.BtnTributacao.Text = "Tributação";
            this.BtnTributacao.UseVisualStyleBackColor = true;
            // 
            // BtnGeral
            // 
            this.BtnGeral.Location = new System.Drawing.Point(1, 2);
            this.BtnGeral.Name = "BtnGeral";
            this.BtnGeral.Size = new System.Drawing.Size(98, 47);
            this.BtnGeral.TabIndex = 14;
            this.BtnGeral.Text = "Geral";
            this.BtnGeral.UseVisualStyleBackColor = true;
            this.BtnGeral.Click += new System.EventHandler(this.BtnGeral_Click);
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelPrincipal.Location = new System.Drawing.Point(3, 61);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.Size = new System.Drawing.Size(567, 453);
            this.PainelPrincipal.TabIndex = 1;
            // 
            // TelaCriarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 585);
            this.Controls.Add(this.painel_CriarProd);
            this.Name = "TelaCriarProd";
            this.Text = "Criar Produto";
            this.painel_CriarProd.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_CriarProd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnTributacao;
        private System.Windows.Forms.Button BtnGeral;
        private System.Windows.Forms.Panel PainelPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
    }
}