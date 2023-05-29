using Pizzaria_do_Zé;

namespace PizzariaDoZe
{
    partial class FormIngrediente
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
            labelIngredientesNome = new Label();
            textBoxIngredientesNome = new TextBox();
            label2 = new Label();
            textBoxIngredientesID = new TextBox();
            buttonCancelarIngredienteCadastro = new Button();
            buttonLimparIngredienteCadastro = new Button();
            buttonSalvarIngredienteCadastro = new Button();
            SuspendLayout();
            // 
            // labelIngredientesNome
            // 
            labelIngredientesNome.AutoSize = true;
            labelIngredientesNome.Location = new Point(31, 77);
            labelIngredientesNome.Name = "labelIngredientesNome";
            labelIngredientesNome.Size = new Size(53, 20);
            labelIngredientesNome.TabIndex = 4;
            labelIngredientesNome.Text = "Nome:";
            // 
            // textBoxIngredientesNome
            // 
            textBoxIngredientesNome.Location = new Point(99, 74);
            textBoxIngredientesNome.Name = "textBoxIngredientesNome";
            textBoxIngredientesNome.Size = new Size(256, 27);
            textBoxIngredientesNome.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 31);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // textBoxIngredientesID
            // 
            textBoxIngredientesID.Location = new Point(99, 31);
            textBoxIngredientesID.Name = "textBoxIngredientesID";
            textBoxIngredientesID.Size = new Size(129, 27);
            textBoxIngredientesID.TabIndex = 5;
            textBoxIngredientesID.TabStop = false;
            // 
            // buttonCancelarIngredienteCadastro
            // 
            buttonCancelarIngredienteCadastro.BackColor = Color.Crimson;
            buttonCancelarIngredienteCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelarIngredienteCadastro.ForeColor = Color.White;
            buttonCancelarIngredienteCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Cancel;
            buttonCancelarIngredienteCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonCancelarIngredienteCadastro.Location = new Point(103, 108);
            buttonCancelarIngredienteCadastro.Name = "buttonCancelarIngredienteCadastro";
            buttonCancelarIngredienteCadastro.Size = new Size(80, 50);
            buttonCancelarIngredienteCadastro.TabIndex = 28;
            buttonCancelarIngredienteCadastro.Text = "Cancelar";
            buttonCancelarIngredienteCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonCancelarIngredienteCadastro.UseVisualStyleBackColor = false;
            buttonCancelarIngredienteCadastro.Click += buttonCancelarIngredienteCadastro_Click;
            // 
            // buttonLimparIngredienteCadastro
            // 
            buttonLimparIngredienteCadastro.BackColor = Color.Orange;
            buttonLimparIngredienteCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimparIngredienteCadastro.ForeColor = Color.White;
            buttonLimparIngredienteCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Broom;
            buttonLimparIngredienteCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonLimparIngredienteCadastro.Location = new Point(189, 108);
            buttonLimparIngredienteCadastro.Name = "buttonLimparIngredienteCadastro";
            buttonLimparIngredienteCadastro.Size = new Size(80, 50);
            buttonLimparIngredienteCadastro.TabIndex = 29;
            buttonLimparIngredienteCadastro.Text = "Limpar";
            buttonLimparIngredienteCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonLimparIngredienteCadastro.UseVisualStyleBackColor = false;
            buttonLimparIngredienteCadastro.Click += buttonLimparIngredienteCadastro_Click;
            // 
            // buttonSalvarIngredienteCadastro
            // 
            buttonSalvarIngredienteCadastro.BackColor = Color.ForestGreen;
            buttonSalvarIngredienteCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvarIngredienteCadastro.ForeColor = Color.White;
            buttonSalvarIngredienteCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Double_Tick;
            buttonSalvarIngredienteCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonSalvarIngredienteCadastro.Location = new Point(275, 108);
            buttonSalvarIngredienteCadastro.Name = "buttonSalvarIngredienteCadastro";
            buttonSalvarIngredienteCadastro.Size = new Size(80, 50);
            buttonSalvarIngredienteCadastro.TabIndex = 30;
            buttonSalvarIngredienteCadastro.Text = "Salvar";
            buttonSalvarIngredienteCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonSalvarIngredienteCadastro.UseVisualStyleBackColor = false;
            buttonSalvarIngredienteCadastro.Click += buttonSalvarIngredienteCadastro_Click;
            // 
            // FormIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 191, 193);
            ClientSize = new Size(367, 170);
            Controls.Add(buttonCancelarIngredienteCadastro);
            Controls.Add(buttonLimparIngredienteCadastro);
            Controls.Add(buttonSalvarIngredienteCadastro);
            Controls.Add(label2);
            Controls.Add(textBoxIngredientesID);
            Controls.Add(labelIngredientesNome);
            Controls.Add(textBoxIngredientesNome);
            ForeColor = Color.Black;
            KeyPreview = true;
            Name = "FormIngrediente";
            Text = "Cadastro de Ingredientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngredientesNome;
        private TextBox textBoxIngredientesNome;
        private Label label2;
        private TextBox textBoxIngredientesID;
        public Button buttonCancelarIngredienteCadastro;
        public Button buttonLimparIngredienteCadastro;
        public Button buttonSalvarIngredienteCadastro;
    }
}