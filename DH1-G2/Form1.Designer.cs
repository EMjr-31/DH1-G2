namespace DH1_G2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSaln = new System.Windows.Forms.TextBox();
            this.Cargo = new System.Windows.Forms.GroupBox();
            this.rbtnGerente = new System.Windows.Forms.RadioButton();
            this.rbtnSubGerente = new System.Windows.Forms.RadioButton();
            this.rbtnSegretario = new System.Windows.Forms.RadioButton();
            this.Cargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario Bruto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario neto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(367, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(124, 107);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalBruto.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(124, 139);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 9;
            // 
            // txtSaln
            // 
            this.txtSaln.Location = new System.Drawing.Point(124, 179);
            this.txtSaln.Name = "txtSaln";
            this.txtSaln.Size = new System.Drawing.Size(100, 20);
            this.txtSaln.TabIndex = 10;
            // 
            // Cargo
            // 
            this.Cargo.Controls.Add(this.rbtnSegretario);
            this.Cargo.Controls.Add(this.rbtnSubGerente);
            this.Cargo.Controls.Add(this.rbtnGerente);
            this.Cargo.Location = new System.Drawing.Point(267, 99);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(200, 100);
            this.Cargo.TabIndex = 11;
            this.Cargo.TabStop = false;
            this.Cargo.Text = "Cargo";
            // 
            // rbtnGerente
            // 
            this.rbtnGerente.AutoSize = true;
            this.rbtnGerente.Location = new System.Drawing.Point(48, 20);
            this.rbtnGerente.Name = "rbtnGerente";
            this.rbtnGerente.Size = new System.Drawing.Size(63, 17);
            this.rbtnGerente.TabIndex = 0;
            this.rbtnGerente.TabStop = true;
            this.rbtnGerente.Text = "Gerente";
            this.rbtnGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnSubGerente
            // 
            this.rbtnSubGerente.AutoSize = true;
            this.rbtnSubGerente.Location = new System.Drawing.Point(48, 44);
            this.rbtnSubGerente.Name = "rbtnSubGerente";
            this.rbtnSubGerente.Size = new System.Drawing.Size(82, 17);
            this.rbtnSubGerente.TabIndex = 1;
            this.rbtnSubGerente.TabStop = true;
            this.rbtnSubGerente.Text = "SubGerente";
            this.rbtnSubGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnSegretario
            // 
            this.rbtnSegretario.AutoSize = true;
            this.rbtnSegretario.Location = new System.Drawing.Point(48, 75);
            this.rbtnSegretario.Name = "rbtnSegretario";
            this.rbtnSegretario.Size = new System.Drawing.Size(73, 17);
            this.rbtnSegretario.TabIndex = 2;
            this.rbtnSegretario.TabStop = true;
            this.rbtnSegretario.Text = "Secretaria";
            this.rbtnSegretario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 245);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.txtSaln);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Cargo.ResumeLayout(false);
            this.Cargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtSaln;
        private System.Windows.Forms.GroupBox Cargo;
        private System.Windows.Forms.RadioButton rbtnSegretario;
        private System.Windows.Forms.RadioButton rbtnSubGerente;
        private System.Windows.Forms.RadioButton rbtnGerente;
    }
}

