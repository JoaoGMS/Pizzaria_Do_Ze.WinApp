using Pizzaria_Do_Ze;

namespace PizzariaDoZe
{
    partial class FormProduto
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
            labelProdutosNome = new Label();
            labelProdutoValor = new Label();
            labelProdutosTipo = new Label();
            labelMl = new Label();
            textBoxProdutoNome = new TextBox();
            comboBoxProdutoTipo = new ComboBox();
            maskedTextBoxProdutoML = new MaskedTextBox();
            maskedTextBoxValorProduto = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelProdutosNome
            // 
            labelProdutosNome.AutoSize = true;
            labelProdutosNome.Location = new Point(15, 34);
            labelProdutosNome.Name = "labelProdutosNome";
            labelProdutosNome.Size = new Size(53, 20);
            labelProdutosNome.TabIndex = 0;
            labelProdutosNome.Text = "Nome:";
            labelProdutosNome.Click += label1_Click;
            // 
            // labelProdutoValor
            // 
            labelProdutoValor.AutoSize = true;
            labelProdutoValor.Location = new Point(280, 34);
            labelProdutoValor.Name = "labelProdutoValor";
            labelProdutoValor.Size = new Size(46, 20);
            labelProdutoValor.TabIndex = 1;
            labelProdutoValor.Text = "Valor:";
            // 
            // labelProdutosTipo
            // 
            labelProdutosTipo.AutoSize = true;
            labelProdutosTipo.Location = new Point(280, 119);
            labelProdutosTipo.Name = "labelProdutosTipo";
            labelProdutosTipo.Size = new Size(42, 20);
            labelProdutosTipo.TabIndex = 2;
            labelProdutosTipo.Text = "Tipo:";
            // 
            // labelMl
            // 
            labelMl.AutoSize = true;
            labelMl.Location = new Point(39, 119);
            labelMl.Name = "labelMl";
            labelMl.Size = new Size(29, 20);
            labelMl.TabIndex = 3;
            labelMl.Text = "ml:";
            // 
            // textBoxProdutoNome
            // 
            textBoxProdutoNome.Location = new Point(74, 31);
            textBoxProdutoNome.Name = "textBoxProdutoNome";
            textBoxProdutoNome.Size = new Size(168, 27);
            textBoxProdutoNome.TabIndex = 13;
            // 
            // comboBoxProdutoTipo
            // 
            comboBoxProdutoTipo.FormattingEnabled = true;
            comboBoxProdutoTipo.Location = new Point(332, 116);
            comboBoxProdutoTipo.Name = "comboBoxProdutoTipo";
            comboBoxProdutoTipo.Size = new Size(151, 28);
            comboBoxProdutoTipo.TabIndex = 16;
            // 
            // maskedTextBoxProdutoML
            // 
            maskedTextBoxProdutoML.Location = new Point(74, 116);
            maskedTextBoxProdutoML.Mask = "9999ml";
            maskedTextBoxProdutoML.Name = "maskedTextBoxProdutoML";
            maskedTextBoxProdutoML.Size = new Size(168, 27);
            maskedTextBoxProdutoML.TabIndex = 15;
            // 
            // maskedTextBoxValorProduto
            // 
            maskedTextBoxValorProduto.Location = new Point(332, 31);
            maskedTextBoxValorProduto.Mask = "$999,00";
            maskedTextBoxValorProduto.Name = "maskedTextBoxValorProduto";
            maskedTextBoxValorProduto.Size = new Size(151, 27);
            maskedTextBoxValorProduto.TabIndex = 14;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 191, 193);
            ClientSize = new Size(498, 217);
            Controls.Add(maskedTextBoxValorProduto);
            Controls.Add(maskedTextBoxProdutoML);
            Controls.Add(comboBoxProdutoTipo);
            Controls.Add(textBoxProdutoNome);
            Controls.Add(labelMl);
            Controls.Add(labelProdutosTipo);
            Controls.Add(labelProdutoValor);
            Controls.Add(labelProdutosNome);
            KeyPreview = true;
            Name = "FormProduto";
            Text = "Cadastro de Produtos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProdutosNome;
        private Label labelProdutoValor;
        private Label labelProdutosTipo;
        private Label labelMl;
        private TextBox textBoxProdutoNome;
        private ComboBox comboBoxProdutoTipo;

        private MaskedTextBox maskedTextBoxProdutoML;
        private MaskedTextBox maskedTextBoxValorProduto;
    }
}