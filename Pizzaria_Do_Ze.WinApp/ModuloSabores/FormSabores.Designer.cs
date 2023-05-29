using Pizzaria_Do_Ze;

namespace PizzariaDoZe
{
    partial class FormSabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSabores));
            labelSaboresNome = new Label();
            textBoxSaboresNome = new TextBox();
            labelSaboresIngredientes = new Label();
            pictureBoxAdicionarFotoSabor = new PictureBox();
            treeViewSaboresIngredientes = new TreeView();
            comboBoxSaboresCategoria = new ComboBox();
            labelSaboresCategoria = new Label();
            labelSaboresTipo = new Label();
            comboBoxSaboresTipo = new ComboBox();
            linkLabelSaboresAdicionar = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdicionarFotoSabor).BeginInit();
            SuspendLayout();
            // 
            // labelSaboresNome
            // 
            labelSaboresNome.AutoSize = true;
            labelSaboresNome.Location = new Point(30, 73);
            labelSaboresNome.Name = "labelSaboresNome";
            labelSaboresNome.Size = new Size(53, 20);
            labelSaboresNome.TabIndex = 28;
            labelSaboresNome.Text = "Nome:";
            // 
            // textBoxSaboresNome
            // 
            textBoxSaboresNome.Location = new Point(98, 70);
            textBoxSaboresNome.Name = "textBoxSaboresNome";
            textBoxSaboresNome.Size = new Size(314, 27);
            textBoxSaboresNome.TabIndex = 13;
            // 
            // labelSaboresIngredientes
            // 
            labelSaboresIngredientes.AutoSize = true;
            labelSaboresIngredientes.Location = new Point(30, 142);
            labelSaboresIngredientes.Name = "labelSaboresIngredientes";
            labelSaboresIngredientes.Size = new Size(94, 20);
            labelSaboresIngredientes.TabIndex = 29;
            labelSaboresIngredientes.Text = "Ingredientes:";
            // 
            // pictureBoxAdicionarFotoSabor
            // 
            pictureBoxAdicionarFotoSabor.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxAdicionarFotoSabor.Image = (Image)resources.GetObject("pictureBoxAdicionarFotoSabor.Image");
            pictureBoxAdicionarFotoSabor.Location = new Point(454, 12);
            pictureBoxAdicionarFotoSabor.Name = "pictureBoxAdicionarFotoSabor";
            pictureBoxAdicionarFotoSabor.Size = new Size(130, 130);
            pictureBoxAdicionarFotoSabor.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxAdicionarFotoSabor.TabIndex = 30;
            pictureBoxAdicionarFotoSabor.TabStop = false;
            // 
            // treeViewSaboresIngredientes
            // 
            treeViewSaboresIngredientes.Location = new Point(30, 175);
            treeViewSaboresIngredientes.Name = "treeViewSaboresIngredientes";
            treeViewSaboresIngredientes.Size = new Size(554, 222);
            treeViewSaboresIngredientes.TabIndex = 0;
            treeViewSaboresIngredientes.TabStop = false;
            // 
            // comboBoxSaboresCategoria
            // 
            comboBoxSaboresCategoria.FormattingEnabled = true;
            comboBoxSaboresCategoria.Location = new Point(130, 439);
            comboBoxSaboresCategoria.Name = "comboBoxSaboresCategoria";
            comboBoxSaboresCategoria.Size = new Size(151, 28);
            comboBoxSaboresCategoria.TabIndex = 15;
            // 
            // labelSaboresCategoria
            // 
            labelSaboresCategoria.AutoSize = true;
            labelSaboresCategoria.Location = new Point(47, 439);
            labelSaboresCategoria.Name = "labelSaboresCategoria";
            labelSaboresCategoria.Size = new Size(77, 20);
            labelSaboresCategoria.TabIndex = 33;
            labelSaboresCategoria.Text = "Categoria:";
            // 
            // labelSaboresTipo
            // 
            labelSaboresTipo.AutoSize = true;
            labelSaboresTipo.Location = new Point(342, 442);
            labelSaboresTipo.Name = "labelSaboresTipo";
            labelSaboresTipo.Size = new Size(42, 20);
            labelSaboresTipo.TabIndex = 34;
            labelSaboresTipo.Text = "Tipo:";
            // 
            // comboBoxSaboresTipo
            // 
            comboBoxSaboresTipo.FormattingEnabled = true;
            comboBoxSaboresTipo.Location = new Point(390, 440);
            comboBoxSaboresTipo.Name = "comboBoxSaboresTipo";
            comboBoxSaboresTipo.Size = new Size(194, 28);
            comboBoxSaboresTipo.TabIndex = 16;
            comboBoxSaboresTipo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // linkLabelSaboresAdicionar
            // 
            linkLabelSaboresAdicionar.AutoSize = true;
            linkLabelSaboresAdicionar.Location = new Point(483, 145);
            linkLabelSaboresAdicionar.Name = "linkLabelSaboresAdicionar";
            linkLabelSaboresAdicionar.Size = new Size(73, 20);
            linkLabelSaboresAdicionar.TabIndex = 14;
            linkLabelSaboresAdicionar.TabStop = true;
            linkLabelSaboresAdicionar.Text = "Adicionar";
            // 
            // FormSabores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 191, 193);
            ClientSize = new Size(613, 545);
            Controls.Add(linkLabelSaboresAdicionar);
            Controls.Add(comboBoxSaboresTipo);
            Controls.Add(labelSaboresTipo);
            Controls.Add(labelSaboresCategoria);
            Controls.Add(comboBoxSaboresCategoria);
            Controls.Add(treeViewSaboresIngredientes);
            Controls.Add(pictureBoxAdicionarFotoSabor);
            Controls.Add(labelSaboresIngredientes);
            Controls.Add(labelSaboresNome);
            Controls.Add(textBoxSaboresNome);
            KeyPreview = true;
            Name = "FormSabores";
            Text = "Cadasro de Sabores/Pizzas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdicionarFotoSabor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelSaboresNome;
        private TextBox textBoxSaboresNome;
        private Label labelSaboresIngredientes;
        private PictureBox pictureBoxAdicionarFotoSabor;
        private TreeView treeViewSaboresIngredientes;
        private ComboBox comboBoxSaboresCategoria;
        private Label labelSaboresCategoria;
        private Label labelSaboresTipo;
        private ComboBox comboBoxSaboresTipo;
        private LinkLabel linkLabelSaboresAdicionar;

    }
}