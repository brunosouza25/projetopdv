namespace WindowsFormsApp2.Principal.View.Config
{
    partial class TelaCadastrarColaborador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbInativo = new System.Windows.Forms.CheckBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cbInativo);
            this.panel1.Controls.Add(this.cbCargo);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 294);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(53, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 24);
            this.label17.TabIndex = 39;
            this.label17.Text = "E-mail*:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 24);
            this.label16.TabIndex = 37;
            this.label16.Text = "Inativo:";
            // 
            // cbInativo
            // 
            this.cbInativo.AutoSize = true;
            this.cbInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInativo.Location = new System.Drawing.Point(435, 140);
            this.cbInativo.Name = "cbInativo";
            this.cbInativo.Size = new System.Drawing.Size(15, 14);
            this.cbInativo.TabIndex = 36;
            this.cbInativo.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(163, 143);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(120, 21);
            this.cbCargo.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(85, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cargo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(328, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Os campos marcados com * são obrigatórios.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(364, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 51);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(74, 198);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 51);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(198, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(199, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // TelaCadastrarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 294);
            this.Controls.Add(this.panel1);
            this.Name = "TelaCadastrarColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarColaborador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbInativo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
    }
}