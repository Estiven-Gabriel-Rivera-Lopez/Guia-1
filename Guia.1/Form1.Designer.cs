namespace Guia._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPrecioOriginal = new TextBox();
            label2 = new Label();
            txtDescuento = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(62, 73);
            label1.Name = "label1";
            label1.Size = new Size(291, 38);
            label1.TabIndex = 0;
            label1.Text = "\"PRECIO ORIGINAL\":";
            // 
            // txtPrecioOriginal
            // 
            txtPrecioOriginal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtPrecioOriginal.Location = new Point(405, 73);
            txtPrecioOriginal.Name = "txtPrecioOriginal";
            txtPrecioOriginal.Size = new Size(203, 43);
            txtPrecioOriginal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(62, 130);
            label2.Name = "label2";
            label2.Size = new Size(239, 38);
            label2.TabIndex = 2;
            label2.Text = "\"DESCUENTO%\":";
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtDescuento.Location = new Point(405, 132);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(203, 43);
            txtDescuento.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(524, 198);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 77);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(44, 210);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 28);
            lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtDescuento);
            Controls.Add(label2);
            Controls.Add(txtPrecioOriginal);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrecioOriginal;
        private Label label2;
        private TextBox txtDescuento;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
