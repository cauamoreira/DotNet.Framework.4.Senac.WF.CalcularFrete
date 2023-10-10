namespace CalcularFrete
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalFrete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFreteminimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularFrete = new System.Windows.Forms.Button();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CALCULAR FRETE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalFrete);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(33, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 209);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS DO FRETE";
            // 
            // txtTotalFrete
            // 
            this.txtTotalFrete.Location = new System.Drawing.Point(149, 54);
            this.txtTotalFrete.Name = "txtTotalFrete";
            this.txtTotalFrete.Size = new System.Drawing.Size(159, 29);
            this.txtTotalFrete.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Frete:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUF);
            this.groupBox2.Controls.Add(this.txtFreteminimo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCalcularFrete);
            this.groupBox2.Location = new System.Drawing.Point(33, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO PACOTE";
            // 
            // txtFreteminimo
            // 
            this.txtFreteminimo.Location = new System.Drawing.Point(149, 36);
            this.txtFreteminimo.Name = "txtFreteminimo";
            this.txtFreteminimo.Size = new System.Drawing.Size(159, 29);
            this.txtFreteminimo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frete mínimo:";
            // 
            // btnCalcularFrete
            // 
            this.btnCalcularFrete.Location = new System.Drawing.Point(6, 138);
            this.btnCalcularFrete.Name = "btnCalcularFrete";
            this.btnCalcularFrete.Size = new System.Drawing.Size(192, 36);
            this.btnCalcularFrete.TabIndex = 0;
            this.btnCalcularFrete.Text = "CALCULAR FRETE";
            this.btnCalcularFrete.UseVisualStyleBackColor = true;
            this.btnCalcularFrete.Click += new System.EventHandler(this.btnCalcularFrete_Click_1);
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "RS",
            "SC",
            "PR",
            "SP"});
            this.cbxUF.Location = new System.Drawing.Point(149, 82);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(159, 32);
            this.cbxUF.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 545);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcularFrete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFreteminimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalFrete;
        private System.Windows.Forms.ComboBox cbxUF;
    }
}

