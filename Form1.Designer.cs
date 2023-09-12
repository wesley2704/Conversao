namespace AppConversao
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Buscar = new Button();
            Gerar = new Button();
            Limpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 95);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 220);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 46);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(230, 159);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 40);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(512, 94);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(57, 44);
            Buscar.TabIndex = 3;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // Gerar
            // 
            Gerar.Location = new Point(440, 272);
            Gerar.Name = "Gerar";
            Gerar.Size = new Size(66, 38);
            Gerar.TabIndex = 4;
            Gerar.Text = "Gerar";
            Gerar.UseVisualStyleBackColor = true;
            Gerar.Click += Gerar_Click;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(358, 272);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(66, 38);
            Limpar.TabIndex = 5;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 77);
            label1.Name = "label1";
            label1.Size = new Size(222, 15);
            label1.TabIndex = 6;
            label1.Text = "Imforme Aqui o Arquivo a ser Importado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 141);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 7;
            label2.Text = "Arquivo Funcionario Gerado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 202);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 8;
            label3.Text = "Arquivo Credencial Gerado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Limpar);
            Controls.Add(Gerar);
            Controls.Add(Buscar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Buscar;
        private Button Gerar;
        private Button Limpar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}