using Pizzaria_Do_Ze;

namespace PizzariaDoZe
{
    partial class FormValores
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
            textBoxValoresValor = new TextBox();
            comboBoxValoresTamanho = new ComboBox();
            comboBoxValoresCategoria = new ComboBox();
            labelValoresTamanho = new Label();
            labelValoresValor = new Label();
            labelValorCategoria = new Label();
            labelValoresValorDaBorda = new Label();
            maskedTextBoxValorBordaValores = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxValoresValor
            // 
            textBoxValoresValor.Location = new Point(95, 107);
            textBoxValoresValor.Name = "textBoxValoresValor";
            textBoxValoresValor.Size = new Size(151, 27);
            textBoxValoresValor.TabIndex = 15;
            // 
            // comboBoxValoresTamanho
            // 
            comboBoxValoresTamanho.FormattingEnabled = true;
            comboBoxValoresTamanho.Location = new Point(95, 36);
            comboBoxValoresTamanho.Name = "comboBoxValoresTamanho";
            comboBoxValoresTamanho.Size = new Size(151, 28);
            comboBoxValoresTamanho.TabIndex = 13;
            // 
            // comboBoxValoresCategoria
            // 
            comboBoxValoresCategoria.FormattingEnabled = true;
            comboBoxValoresCategoria.Location = new Point(389, 38);
            comboBoxValoresCategoria.Name = "comboBoxValoresCategoria";
            comboBoxValoresCategoria.Size = new Size(176, 28);
            comboBoxValoresCategoria.TabIndex = 14;
            // 
            // labelValoresTamanho
            // 
            labelValoresTamanho.AutoSize = true;
            labelValoresTamanho.Location = new Point(17, 36);
            labelValoresTamanho.Name = "labelValoresTamanho";
            labelValoresTamanho.Size = new Size(72, 20);
            labelValoresTamanho.TabIndex = 4;
            labelValoresTamanho.Text = "Tamanho:";
            // 
            // labelValoresValor
            // 
            labelValoresValor.AutoSize = true;
            labelValoresValor.Location = new Point(43, 107);
            labelValoresValor.Name = "labelValoresValor";
            labelValoresValor.Size = new Size(46, 20);
            labelValoresValor.TabIndex = 5;
            labelValoresValor.Text = "Valor:";
            // 
            // labelValorCategoria
            // 
            labelValorCategoria.AutoSize = true;
            labelValorCategoria.Location = new Point(306, 41);
            labelValorCategoria.Name = "labelValorCategoria";
            labelValorCategoria.Size = new Size(77, 20);
            labelValorCategoria.TabIndex = 6;
            labelValorCategoria.Text = "Categoria:";
            // 
            // labelValoresValorDaBorda
            // 
            labelValoresValorDaBorda.AutoSize = true;
            labelValoresValorDaBorda.Location = new Point(275, 107);
            labelValoresValorDaBorda.Name = "labelValoresValorDaBorda";
            labelValoresValorDaBorda.Size = new Size(111, 20);
            labelValoresValorDaBorda.TabIndex = 7;
            labelValoresValorDaBorda.Text = "Valor da Borda:";
            labelValoresValorDaBorda.Click += label4_Click;
            // 
            // maskedTextBoxValorBordaValores
            // 
            maskedTextBoxValorBordaValores.Location = new Point(393, 107);
            maskedTextBoxValorBordaValores.Mask = "999,99";
            maskedTextBoxValorBordaValores.Name = "maskedTextBoxValorBordaValores";
            maskedTextBoxValorBordaValores.Size = new Size(176, 27);
            maskedTextBoxValorBordaValores.TabIndex = 16;
            // 
            // FormValores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 191, 193);
            ClientSize = new Size(581, 202);
            Controls.Add(maskedTextBoxValorBordaValores);
            Controls.Add(labelValoresValorDaBorda);
            Controls.Add(labelValorCategoria);
            Controls.Add(labelValoresValor);
            Controls.Add(labelValoresTamanho);
            Controls.Add(comboBoxValoresCategoria);
            Controls.Add(comboBoxValoresTamanho);
            Controls.Add(textBoxValoresValor);
            KeyPreview = true;
            Name = "FormValores";
            Text = "Cadastro de Valores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValoresValor;
        private ComboBox comboBoxValoresTamanho;
        private ComboBox comboBoxValoresCategoria;
        private Label labelValoresTamanho;
        private Label labelValoresValor;
        private Label labelValorCategoria;
        private Label labelValoresValorDaBorda;
        private MaskedTextBox maskedTextBoxValorBordaValores;
    }
}