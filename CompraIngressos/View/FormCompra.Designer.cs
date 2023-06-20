namespace CompraIngressos.View
{
    partial class FormCompra
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
            this.Calcular = new System.Windows.Forms.Button();
            this.tx_resultado = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(136, 112);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(118, 23);
            this.Calcular.TabIndex = 11;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // tx_resultado
            // 
            this.tx_resultado.BackColor = System.Drawing.SystemColors.Info;
            this.tx_resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tx_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tx_resultado.Location = new System.Drawing.Point(12, 154);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(364, 108);
            this.tx_resultado.TabIndex = 10;
            this.tx_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(231, 64);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(100, 23);
            this.Valor.TabIndex = 9;
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(231, 23);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(100, 23);
            this.Quantidade.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor de cada Ingresso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade de Ingressos:";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 271);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Ingressos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calcular;
        private Label tx_resultado;
        private TextBox Valor;
        private TextBox Quantidade;
        private Label label2;
        private Label label1;
    }
}