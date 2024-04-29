namespace IMC
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
            btCalcular = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbIMC = new Label();
            lbClassificacao = new Label();
            SuspendLayout();
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCalcular.ForeColor = Color.Red;
            btCalcular.Location = new Point(20, 113);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(170, 35);
            btCalcular.TabIndex = 0;
            btCalcular.Text = "Calcular IMC";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += button1_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(90, 65);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(90, 21);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 3;
            label1.Text = "Peso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 4;
            label2.Text = "Altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(240, 27);
            label3.Name = "label3";
            label3.Size = new Size(94, 18);
            label3.TabIndex = 5;
            label3.Text = "Resultado:";
            // 
            // lbIMC
            // 
            lbIMC.AutoSize = true;
            lbIMC.Font = new Font("Arial Rounded MT Bold", 16F);
            lbIMC.Location = new Point(350, 22);
            lbIMC.Name = "lbIMC";
            lbIMC.Size = new Size(53, 26);
            lbIMC.TabIndex = 6;
            lbIMC.Text = "IMC";
            lbIMC.Visible = false;
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Font = new Font("Arial Rounded MT Bold", 14F);
            lbClassificacao.Location = new Point(282, 89);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(131, 22);
            lbClassificacao.TabIndex = 7;
            lbClassificacao.Text = "Classificacao";
            lbClassificacao.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 193);
            Controls.Add(lbClassificacao);
            Controls.Add(lbIMC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(btCalcular);
            Name = "Form1";
            Text = "Cálculo de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCalcular;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbIMC;
        private Label lbClassificacao;
    }
}
