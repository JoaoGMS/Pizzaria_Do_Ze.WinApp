using Pizzaria_Do_Ze;

namespace PizzariaDoZe
{
    partial class FormFuncionario
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
            labelFuncionarioNome = new Label();
            textBoxFuncionarioNome = new TextBox();
            labelFuncionarioCPF = new Label();
            labelFuncionarioMatricula = new Label();
            textBoxFuncionarioMatricula = new TextBox();
            labelFuncionarioTelefone = new Label();
            labelFuncionarioSenha = new Label();
            textBoxFuncionarioSenha = new TextBox();
            comboBoxFuncionarioFuncao = new ComboBox();
            labelFuncionarioFuncao = new Label();
            richTextBox1 = new RichTextBox();
            labelFuncionarioCarteiraMotorista = new Label();
            radioButtonFuncionarioSim = new RadioButton();
            radioButtonFuncionarioNao = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            labelFuncionarioValidadeDaCarteira = new Label();
            labelFuncionarioObservacao = new Label();
            maskedTextBoxCPFFuncionario = new MaskedTextBox();
            maskedTextBoxTelefoneFuncionario = new MaskedTextBox();
            buttonCancelarFuncionarioCadastro = new Button();
            buttonLimparFuncionarioCadastro = new Button();
            buttonSalvarFuncionarioCadastro = new Button();
            SuspendLayout();
            // 
            // labelFuncionarioNome
            // 
            labelFuncionarioNome.AutoSize = true;
            labelFuncionarioNome.Location = new Point(46, 46);
            labelFuncionarioNome.Name = "labelFuncionarioNome";
            labelFuncionarioNome.Size = new Size(53, 20);
            labelFuncionarioNome.TabIndex = 4;
            labelFuncionarioNome.Text = "Nome:";
            // 
            // textBoxFuncionarioNome
            // 
            textBoxFuncionarioNome.Location = new Point(114, 43);
            textBoxFuncionarioNome.Name = "textBoxFuncionarioNome";
            textBoxFuncionarioNome.Size = new Size(362, 27);
            textBoxFuncionarioNome.TabIndex = 13;
            textBoxFuncionarioNome.TextChanged += textBox1_TextChanged;
            // 
            // labelFuncionarioCPF
            // 
            labelFuncionarioCPF.AutoSize = true;
            labelFuncionarioCPF.Location = new Point(63, 103);
            labelFuncionarioCPF.Name = "labelFuncionarioCPF";
            labelFuncionarioCPF.Size = new Size(36, 20);
            labelFuncionarioCPF.TabIndex = 6;
            labelFuncionarioCPF.Text = "CPF:";
            // 
            // labelFuncionarioMatricula
            // 
            labelFuncionarioMatricula.AutoSize = true;
            labelFuncionarioMatricula.Location = new Point(250, 103);
            labelFuncionarioMatricula.Name = "labelFuncionarioMatricula";
            labelFuncionarioMatricula.Size = new Size(74, 20);
            labelFuncionarioMatricula.TabIndex = 8;
            labelFuncionarioMatricula.Text = "Matrícula:";
            labelFuncionarioMatricula.Click += label3_Click;
            // 
            // textBoxFuncionarioMatricula
            // 
            textBoxFuncionarioMatricula.Location = new Point(330, 96);
            textBoxFuncionarioMatricula.Name = "textBoxFuncionarioMatricula";
            textBoxFuncionarioMatricula.Size = new Size(146, 27);
            textBoxFuncionarioMatricula.TabIndex = 15;
            // 
            // labelFuncionarioTelefone
            // 
            labelFuncionarioTelefone.AutoSize = true;
            labelFuncionarioTelefone.Location = new Point(30, 151);
            labelFuncionarioTelefone.Name = "labelFuncionarioTelefone";
            labelFuncionarioTelefone.Size = new Size(69, 20);
            labelFuncionarioTelefone.TabIndex = 10;
            labelFuncionarioTelefone.Text = "Telefone:";
            labelFuncionarioTelefone.Click += label4_Click;
            // 
            // labelFuncionarioSenha
            // 
            labelFuncionarioSenha.AutoSize = true;
            labelFuncionarioSenha.Location = new Point(272, 155);
            labelFuncionarioSenha.Name = "labelFuncionarioSenha";
            labelFuncionarioSenha.Size = new Size(52, 20);
            labelFuncionarioSenha.TabIndex = 12;
            labelFuncionarioSenha.Text = "Senha:";
            // 
            // textBoxFuncionarioSenha
            // 
            textBoxFuncionarioSenha.Location = new Point(351, 151);
            textBoxFuncionarioSenha.Name = "textBoxFuncionarioSenha";
            textBoxFuncionarioSenha.Size = new Size(125, 27);
            textBoxFuncionarioSenha.TabIndex = 17;
            textBoxFuncionarioSenha.TextChanged += textBox5_TextChanged;
            // 
            // comboBoxFuncionarioFuncao
            // 
            comboBoxFuncionarioFuncao.FormattingEnabled = true;
            comboBoxFuncionarioFuncao.Location = new Point(115, 207);
            comboBoxFuncionarioFuncao.Name = "comboBoxFuncionarioFuncao";
            comboBoxFuncionarioFuncao.Size = new Size(146, 28);
            comboBoxFuncionarioFuncao.TabIndex = 18;
            // 
            // labelFuncionarioFuncao
            // 
            labelFuncionarioFuncao.AutoSize = true;
            labelFuncionarioFuncao.Location = new Point(40, 210);
            labelFuncionarioFuncao.Name = "labelFuncionarioFuncao";
            labelFuncionarioFuncao.Size = new Size(59, 20);
            labelFuncionarioFuncao.TabIndex = 14;
            labelFuncionarioFuncao.Text = "Função:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(300, 239);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(176, 142);
            richTextBox1.TabIndex = 15;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "";
            // 
            // labelFuncionarioCarteiraMotorista
            // 
            labelFuncionarioCarteiraMotorista.AutoSize = true;
            labelFuncionarioCarteiraMotorista.Location = new Point(23, 269);
            labelFuncionarioCarteiraMotorista.Name = "labelFuncionarioCarteiraMotorista";
            labelFuncionarioCarteiraMotorista.Size = new Size(86, 40);
            labelFuncionarioCarteiraMotorista.TabIndex = 16;
            labelFuncionarioCarteiraMotorista.Text = "Carteira de \r\nMotorista:\r\n";
            // 
            // radioButtonFuncionarioSim
            // 
            radioButtonFuncionarioSim.AutoSize = true;
            radioButtonFuncionarioSim.Location = new Point(141, 285);
            radioButtonFuncionarioSim.Name = "radioButtonFuncionarioSim";
            radioButtonFuncionarioSim.Size = new Size(55, 24);
            radioButtonFuncionarioSim.TabIndex = 19;
            radioButtonFuncionarioSim.Text = "Sim";
            radioButtonFuncionarioSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFuncionarioNao
            // 
            radioButtonFuncionarioNao.AutoSize = true;
            radioButtonFuncionarioNao.Location = new Point(202, 285);
            radioButtonFuncionarioNao.Name = "radioButtonFuncionarioNao";
            radioButtonFuncionarioNao.Size = new Size(58, 24);
            radioButtonFuncionarioNao.TabIndex = 20;
            radioButtonFuncionarioNao.Text = "Não";
            radioButtonFuncionarioNao.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 354);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 27);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.TabStop = false;
            // 
            // labelFuncionarioValidadeDaCarteira
            // 
            labelFuncionarioValidadeDaCarteira.AutoSize = true;
            labelFuncionarioValidadeDaCarteira.Location = new Point(14, 341);
            labelFuncionarioValidadeDaCarteira.Name = "labelFuncionarioValidadeDaCarteira";
            labelFuncionarioValidadeDaCarteira.Size = new Size(85, 40);
            labelFuncionarioValidadeDaCarteira.TabIndex = 20;
            labelFuncionarioValidadeDaCarteira.Text = "Validade\r\nda Carteira:";
            labelFuncionarioValidadeDaCarteira.TextAlign = ContentAlignment.TopCenter;
            labelFuncionarioValidadeDaCarteira.Click += label8_Click;
            // 
            // labelFuncionarioObservacao
            // 
            labelFuncionarioObservacao.AutoSize = true;
            labelFuncionarioObservacao.Location = new Point(300, 215);
            labelFuncionarioObservacao.Name = "labelFuncionarioObservacao";
            labelFuncionarioObservacao.Size = new Size(96, 20);
            labelFuncionarioObservacao.TabIndex = 24;
            labelFuncionarioObservacao.Text = "Observações:";
            // 
            // maskedTextBoxCPFFuncionario
            // 
            maskedTextBoxCPFFuncionario.Location = new Point(114, 96);
            maskedTextBoxCPFFuncionario.Mask = "999,999,999-99";
            maskedTextBoxCPFFuncionario.Name = "maskedTextBoxCPFFuncionario";
            maskedTextBoxCPFFuncionario.Size = new Size(126, 27);
            maskedTextBoxCPFFuncionario.TabIndex = 14;
            // 
            // maskedTextBoxTelefoneFuncionario
            // 
            maskedTextBoxTelefoneFuncionario.Location = new Point(115, 151);
            maskedTextBoxTelefoneFuncionario.Mask = "(99) 99999-9999";
            maskedTextBoxTelefoneFuncionario.Name = "maskedTextBoxTelefoneFuncionario";
            maskedTextBoxTelefoneFuncionario.Size = new Size(146, 27);
            maskedTextBoxTelefoneFuncionario.TabIndex = 16;
            // 
            // buttonCancelarFuncionarioCadastro
            // 
            buttonCancelarFuncionarioCadastro.BackColor = Color.Crimson;
            buttonCancelarFuncionarioCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelarFuncionarioCadastro.ForeColor = Color.White;
            buttonCancelarFuncionarioCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Cancel;
            buttonCancelarFuncionarioCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonCancelarFuncionarioCadastro.Location = new Point(224, 399);
            buttonCancelarFuncionarioCadastro.Name = "buttonCancelarFuncionarioCadastro";
            buttonCancelarFuncionarioCadastro.Size = new Size(80, 50);
            buttonCancelarFuncionarioCadastro.TabIndex = 28;
            buttonCancelarFuncionarioCadastro.Text = "Cancelar";
            buttonCancelarFuncionarioCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonCancelarFuncionarioCadastro.UseVisualStyleBackColor = false;
            // 
            // buttonLimparFuncionarioCadastro
            // 
            buttonLimparFuncionarioCadastro.BackColor = Color.Orange;
            buttonLimparFuncionarioCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimparFuncionarioCadastro.ForeColor = Color.White;
            buttonLimparFuncionarioCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Broom;
            buttonLimparFuncionarioCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonLimparFuncionarioCadastro.Location = new Point(310, 399);
            buttonLimparFuncionarioCadastro.Name = "buttonLimparFuncionarioCadastro";
            buttonLimparFuncionarioCadastro.Size = new Size(80, 50);
            buttonLimparFuncionarioCadastro.TabIndex = 29;
            buttonLimparFuncionarioCadastro.Text = "Limpar";
            buttonLimparFuncionarioCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonLimparFuncionarioCadastro.UseVisualStyleBackColor = false;
            // 
            // buttonSalvarFuncionarioCadastro
            // 
            buttonSalvarFuncionarioCadastro.BackColor = Color.ForestGreen;
            buttonSalvarFuncionarioCadastro.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvarFuncionarioCadastro.ForeColor = Color.White;
            buttonSalvarFuncionarioCadastro.Image = Pizzaria_Do_Ze.WinApp.Properties.Resources.Double_Tick;
            buttonSalvarFuncionarioCadastro.ImageAlign = ContentAlignment.TopLeft;
            buttonSalvarFuncionarioCadastro.Location = new Point(396, 399);
            buttonSalvarFuncionarioCadastro.Name = "buttonSalvarFuncionarioCadastro";
            buttonSalvarFuncionarioCadastro.Size = new Size(80, 50);
            buttonSalvarFuncionarioCadastro.TabIndex = 30;
            buttonSalvarFuncionarioCadastro.Text = "Salvar";
            buttonSalvarFuncionarioCadastro.TextAlign = ContentAlignment.BottomCenter;
            buttonSalvarFuncionarioCadastro.UseVisualStyleBackColor = false;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 191, 193);
            ClientSize = new Size(506, 461);
            Controls.Add(buttonCancelarFuncionarioCadastro);
            Controls.Add(buttonLimparFuncionarioCadastro);
            Controls.Add(buttonSalvarFuncionarioCadastro);
            Controls.Add(maskedTextBoxTelefoneFuncionario);
            Controls.Add(maskedTextBoxCPFFuncionario);
            Controls.Add(labelFuncionarioObservacao);
            Controls.Add(labelFuncionarioValidadeDaCarteira);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButtonFuncionarioNao);
            Controls.Add(radioButtonFuncionarioSim);
            Controls.Add(labelFuncionarioCarteiraMotorista);
            Controls.Add(richTextBox1);
            Controls.Add(labelFuncionarioFuncao);
            Controls.Add(comboBoxFuncionarioFuncao);
            Controls.Add(labelFuncionarioSenha);
            Controls.Add(textBoxFuncionarioSenha);
            Controls.Add(labelFuncionarioTelefone);
            Controls.Add(labelFuncionarioMatricula);
            Controls.Add(textBoxFuncionarioMatricula);
            Controls.Add(labelFuncionarioCPF);
            Controls.Add(labelFuncionarioNome);
            Controls.Add(textBoxFuncionarioNome);
            KeyPreview = true;
            Name = "FormFuncionario";
            Text = "Cadastro de Funcionários";
            Load += FormFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFuncionarioNome;
        private TextBox textBoxFuncionarioNome;
        private Label labelFuncionarioCPF;
        private Label labelFuncionarioMatricula;
        private TextBox textBoxFuncionarioMatricula;
        private Label labelFuncionarioTelefone;
        private Label labelFuncionarioSenha;
        private TextBox textBoxFuncionarioSenha;
        private ComboBox comboBoxFuncionarioFuncao;
        private Label labelFuncionarioFuncao;
        private RichTextBox richTextBox1;
        private Label labelFuncionarioCarteiraMotorista;
        private RadioButton radioButtonFuncionarioSim;
        private RadioButton radioButtonFuncionarioNao;
        private DateTimePicker dateTimePicker1;
        private Label labelFuncionarioValidadeDaCarteira;
        private Label labelFuncionarioObservacao;
        private MaskedTextBox maskedTextBoxCPFFuncionario;
        private MaskedTextBox maskedTextBoxTelefoneFuncionario;
        public Button buttonCancelarFuncionarioCadastro;
        public Button buttonLimparFuncionarioCadastro;
        public Button buttonSalvarFuncionarioCadastro;
    }
}