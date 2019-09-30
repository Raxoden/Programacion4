namespace Figuras
{
    partial class frmFiguras
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
            this.lblFiguras = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.cbFiguras = new System.Windows.Forms.ComboBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.resPerimetro = new System.Windows.Forms.Label();
            this.resArea = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado4 = new System.Windows.Forms.Label();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFiguras
            // 
            this.lblFiguras.AutoSize = true;
            this.lblFiguras.Location = new System.Drawing.Point(31, 40);
            this.lblFiguras.Name = "lblFiguras";
            this.lblFiguras.Size = new System.Drawing.Size(52, 17);
            this.lblFiguras.TabIndex = 0;
            this.lblFiguras.Text = "Figura:";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(12, 94);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(56, 17);
            this.lblLado1.TabIndex = 1;
            this.lblLado1.Text = "Lado 1:";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(267, 94);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(56, 17);
            this.lblLado2.TabIndex = 2;
            this.lblLado2.Text = "Lado 2:";
            // 
            // cbFiguras
            // 
            this.cbFiguras.FormattingEnabled = true;
            this.cbFiguras.Items.AddRange(new object[] {
            "Cuadrado",
            "Rectangulo",
            "Circulo",
            "Triangulo"});
            this.cbFiguras.Location = new System.Drawing.Point(93, 37);
            this.cbFiguras.Name = "cbFiguras";
            this.cbFiguras.Size = new System.Drawing.Size(380, 24);
            this.cbFiguras.TabIndex = 4;
            this.cbFiguras.SelectedIndexChanged += new System.EventHandler(this.CbFiguras_SelectedIndexChanged);
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(105, 91);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(144, 22);
            this.txtLado1.TabIndex = 5;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(329, 91);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(144, 22);
            this.txtLado2.TabIndex = 6;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(31, 321);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(73, 17);
            this.lblPerimetro.TabIndex = 7;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(267, 321);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Área:";
            // 
            // resPerimetro
            // 
            this.resPerimetro.AutoSize = true;
            this.resPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPerimetro.Location = new System.Drawing.Point(125, 314);
            this.resPerimetro.Name = "resPerimetro";
            this.resPerimetro.Size = new System.Drawing.Size(0, 25);
            this.resPerimetro.TabIndex = 9;
            // 
            // resArea
            // 
            this.resArea.AutoSize = true;
            this.resArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resArea.Location = new System.Drawing.Point(361, 314);
            this.resArea.Name = "resArea";
            this.resArea.Size = new System.Drawing.Size(0, 25);
            this.resArea.TabIndex = 10;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(12, 151);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(56, 17);
            this.lblLado3.TabIndex = 11;
            this.lblLado3.Text = "Lado 3:";
            this.lblLado3.Visible = false;
            // 
            // lblLado4
            // 
            this.lblLado4.AutoSize = true;
            this.lblLado4.Location = new System.Drawing.Point(267, 154);
            this.lblLado4.Name = "lblLado4";
            this.lblLado4.Size = new System.Drawing.Size(56, 17);
            this.lblLado4.TabIndex = 12;
            this.lblLado4.Text = "Lado 4:";
            this.lblLado4.Visible = false;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(105, 148);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(144, 22);
            this.txtLado3.TabIndex = 13;
            this.txtLado3.Visible = false;
            // 
            // txtLado4
            // 
            this.txtLado4.Location = new System.Drawing.Point(329, 151);
            this.txtLado4.Name = "txtLado4";
            this.txtLado4.Size = new System.Drawing.Size(144, 22);
            this.txtLado4.TabIndex = 14;
            this.txtLado4.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 223);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(181, 44);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // frmFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 372);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLado4);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.lblLado4);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.resArea);
            this.Controls.Add(this.resPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.cbFiguras);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblFiguras);
            this.Name = "frmFiguras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras";
            this.Load += new System.EventHandler(this.FrmFiguras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiguras;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.ComboBox cbFiguras;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label resPerimetro;
        private System.Windows.Forms.Label resArea;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado4;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado4;
        private System.Windows.Forms.Button btnCalcular;
    }
}

