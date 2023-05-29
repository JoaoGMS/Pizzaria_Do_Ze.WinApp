using Pizzaria_Do_Ze.WinApp;

namespace PizzariaDoZe
{
    partial class FormCliente
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
            labelNomeCliente = new Label();
            labelClienteEmail = new Label();
            labelClienteTelefone = new Label();
            labelClienteCPF = new Label();
            labelClienteEndereco = new Label();
            textBoxClienteEndereco = new TextBox();
            textBoxClienteNome = new TextBox();
            maskedTextBoxTelefoneCliente = new MaskedTextBox();
            maskedTextBoxCPFCliente = new MaskedTextBox();
            textBoxEmailCliente = new TextBox();
            buttonCancelarClienteCadastro = new Button();
            buttonLimparClienteCadastro = new Button();
            buttonSalvarClienteCadastro = new Button();
            SuspendLayout();
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Location = new Point(27, 31);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(53, 20);
            labelNomeCliente.TabIndex = 2;
            labelNomeCliente.Text = "Nome:";
            labelNomeCliente.Click += label1_Click;
            // 
            // labelClienteEmail
            // 
            labelClienteEmail.AutoSize = true;
            labelClienteEmail.Location = new Point(31, 88);
            labelClienteEmail.Name = "labelClienteEmail";
            labelClienteEmail.Size = new Size(49, 20);
            labelClienteEmail.TabIndex = 3;
            labelClienteEmail.Text = "Email:";
            // 
            // labelClienteTelefone
            // 
            labelClienteTelefone.AutoSize = true;
            labelClienteTelefone.Location = new Point(11, 144);
            labelClienteTelefone.Name = "labelClienteTelefone";
            labelClienteTelefone.Size = new Size(69, 20);
            labelClienteTelefone.TabIndex = 5;
            labelClienteTelefone.Text = "Telefone:";
            // 
            // labelClienteCPF
            // 
            labelClienteCPF.AutoSize = true;
            labelClienteCPF.Location = new Point(260, 147);
            labelClienteCPF.Name = "labelClienteCPF";
            labelClienteCPF.Size = new Size(36, 20);
            labelClienteCPF.TabIndex = 7;
            labelClienteCPF.Text = "CPF:";
            // 
            // labelClienteEndereco
            // 
            labelClienteEndereco.AutoSize = true;
            labelClienteEndereco.Location = new Point(6, 197);
            labelClienteEndereco.Name = "labelClienteEndereco";
            labelClienteEndereco.Size = new Size(74, 20);
            labelClienteEndereco.TabIndex = 10;
            labelClienteEndereco.Text = "Endereço:";
            // 
            // textBoxClienteEndereco
            // 
            textBoxClienteEndereco.Location = new Point(95, 194);
            textBoxClienteEndereco.Name = "textBoxClienteEndereco";
            textBoxClienteEndereco.Size = new Size(362, 27);
            textBoxClienteEndereco.TabIndex = 17;
            // 
            // textBoxClienteNome
            // 
            textBoxClienteNome.Location = new Point(95, 28);
            textBoxClienteNome.Name = "textBoxClienteNome";
            textBoxClienteNome.Size = new Size(362, 27);
            textBoxClienteNome.TabIndex = 13;
            // 
            // maskedTextBoxTelefoneCliente
            // 
            maskedTextBoxTelefoneCliente.Location = new Point(95, 140);
            maskedTextBoxTelefoneCliente.Mask = "(+)99-999999999";
            maskedTextBoxTelefoneCliente.Name = "maskedTextBoxTelefoneCliente";
            maskedTextBoxTelefoneCliente.Size = new Size(159, 27);
            maskedTextBoxTelefoneCliente.TabIndex = 15;
            // 
            // maskedTextBoxCPFCliente
            // 
            maskedTextBoxCPFCliente.Location = new Point(302, 140);
            maskedTextBoxCPFCliente.Mask = "999,999,999-99";
            maskedTextBoxCPFCliente.Name = "maskedTextBoxCPFCliente";
            maskedTextBoxCPFCliente.Size = new Size(155, 27);
            maskedTextBoxCPFCliente.TabIndex = 16;
            // 
            // textBoxEmailCliente
            // 
            textBoxEmailCliente.Location = new Point(95, 85);
            textBoxEmailCliente.Name = "textBoxEmailCliente";
            textBoxEmailCliente.Size = new Size(362, 27);
            textBoxEmailCliente.TabIndex = 14;
            // 
            // buttonCancelarClienteCadastro
            // 
            buttonCancelarClienteCadastro.BackColor = Color.Crimson;
            buttonCancelarClienteCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelarClienteCadastro.ForeColor = Color.White;
            buttonCancelarClienteCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Cancel;
            buttonCancelarClienteCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonCancelarClienteCadastro.Location = new Point(205, 248);
            buttonCancelarClienteCadastro.Name = "buttonCancelarClienteCadastro";
            buttonCancelarClienteCadastro.Size = new Size(80, 50);
            buttonCancelarClienteCadastro.TabIndex = 25;
            buttonCancelarClienteCadastro.Text = "Cancelar";
            buttonCancelarClienteCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonCancelarClienteCadastro.UseVisualStyleBackColor = false;
            buttonCancelarClienteCadastro.Click += buttonCancelarClienteCadastro_Click;
            // 
            // buttonLimparClienteCadastro
            // 
            buttonLimparClienteCadastro.BackColor = Color.Orange;
            buttonLimparClienteCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimparClienteCadastro.ForeColor = Color.White;
            buttonLimparClienteCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Broom;
            buttonLimparClienteCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonLimparClienteCadastro.Location = new Point(291, 248);
            buttonLimparClienteCadastro.Name = "buttonLimparClienteCadastro";
            buttonLimparClienteCadastro.Size = new Size(80, 50);
            buttonLimparClienteCadastro.TabIndex = 26;
            buttonLimparClienteCadastro.Text = "Limpar";
            buttonLimparClienteCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonLimparClienteCadastro.UseVisualStyleBackColor = false;
            buttonLimparClienteCadastro.Click += buttonLimparClienteCadastro_Click;
            // 
            // buttonSalvarClienteCadastro
            // 
            buttonSalvarClienteCadastro.BackColor = Color.ForestGreen;
            buttonSalvarClienteCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvarClienteCadastro.ForeColor = Color.White;
            buttonSalvarClienteCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Double_Tick;
            buttonSalvarClienteCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonSalvarClienteCadastro.Location = new Point(377, 248);
            buttonSalvarClienteCadastro.Name = "buttonSalvarClienteCadastro";
            buttonSalvarClienteCadastro.Size = new Size(80, 50);
            buttonSalvarClienteCadastro.TabIndex = 27;
            buttonSalvarClienteCadastro.Text = "Salvar";
            buttonSalvarClienteCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonSalvarClienteCadastro.UseVisualStyleBackColor = false;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 191, 193);
            ClientSize = new Size(480, 310);
            Controls.Add(buttonCancelarClienteCadastro);
            Controls.Add(buttonLimparClienteCadastro);
            Controls.Add(buttonSalvarClienteCadastro);
            Controls.Add(textBoxEmailCliente);
            Controls.Add(maskedTextBoxCPFCliente);
            Controls.Add(maskedTextBoxTelefoneCliente);
            Controls.Add(labelClienteEndereco);
            Controls.Add(textBoxClienteEndereco);
            Controls.Add(labelClienteCPF);
            Controls.Add(labelClienteTelefone);
            Controls.Add(labelClienteEmail);
            Controls.Add(labelNomeCliente);
            Controls.Add(textBoxClienteNome);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormCliente";
            ShowIcon = false;
            Text = "Cadastro Cliente";
            Load += Cliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNomeCliente;
        private Label labelClienteEmail;
        private Label labelClienteTelefone;
        private Label labelClienteCPF;
        private Label labelClienteEndereco;
        private TextBox textBoxClienteEndereco;
        private TextBox textBoxClienteNome;
        private MaskedTextBox maskedTextBoxTelefoneCliente;
        private MaskedTextBox maskedTextBoxCPFCliente;
        private TextBox textBoxEmailCliente;
        public Button buttonCancelarClienteCadastro;
        public Button buttonLimparClienteCadastro;
        public Button buttonSalvarClienteCadastro;
    }
}