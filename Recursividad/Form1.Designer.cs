namespace Recursividad
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
            btnCalcular = new Button();
            txtNumero = new TextBox();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(237, 60);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 51);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular Factorial";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 72);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(219, 27);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 114);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 3;
            label1.Text = "Ingrese un numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(367, 202);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            ForeColor = Color.Bisque;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de factoriales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNumero;
        private Label lblResultado;
        private Label label1;
    }
}
