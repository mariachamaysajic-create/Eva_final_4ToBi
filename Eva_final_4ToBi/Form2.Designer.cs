namespace Eva_final_4ToBi
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.TextVar1 = new System.Windows.Forms.TextBox();
            this.TextVar2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextVar1
            // 
            this.TextVar1.BackColor = System.Drawing.Color.Fuchsia;
            this.TextVar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextVar1.Location = new System.Drawing.Point(12, 95);
            this.TextVar1.Name = "TextVar1";
            this.TextVar1.Size = new System.Drawing.Size(100, 22);
            this.TextVar1.TabIndex = 0;
            // 
            // TextVar2
            // 
            this.TextVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextVar2.Location = new System.Drawing.Point(151, 95);
            this.TextVar2.Name = "TextVar2";
            this.TextVar2.Size = new System.Drawing.Size(100, 22);
            this.TextVar2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.Red;
            this.BtnProducto.Location = new System.Drawing.Point(12, 177);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(100, 41);
            this.BtnProducto.TabIndex = 3;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnSuma.Location = new System.Drawing.Point(118, 177);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(100, 41);
            this.BtnSuma.TabIndex = 4;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.BackColor = System.Drawing.Color.Yellow;
            this.BtnPotencia.Location = new System.Drawing.Point(224, 177);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(100, 46);
            this.BtnPotencia.TabIndex = 5;
            this.BtnPotencia.Text = "Potencia";
            this.BtnPotencia.UseVisualStyleBackColor = false;
            this.BtnPotencia.Click += new System.EventHandler(this.BtnPotencia_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.Cyan;
            this.BtnDivision.Location = new System.Drawing.Point(330, 177);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(100, 46);
            this.BtnDivision.TabIndex = 6;
            this.BtnDivision.Text = "Division";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.TextVar2);
            this.Controls.Add(this.TextVar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextVar1;
        private System.Windows.Forms.TextBox TextVar2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnDivision;
    }
}