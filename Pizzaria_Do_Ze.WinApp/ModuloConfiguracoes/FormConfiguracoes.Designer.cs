namespace Pizzaria_do_Zé
{
    partial class FormConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracoes));
            labelConfiguracoes = new Label();
            tabControlConfiguracoes = new TabControl();
            tabPageIdiomaRegiao = new TabPage();
            labelIdioma = new Label();
            buttonCancelar = new Button();
            buttonSalvarIdioma = new Button();
            checkBoxIdiomaReiniciar = new CheckBox();
            labelIdiomaRegiao = new Label();
            comboBoxCultura = new ComboBox();
            tabPageArmazenamentoLog = new TabPage();
            tabPageFecharAoSair = new TabPage();
            tabPageParametros = new TabPage();
            tabPageBancoDeDados = new TabPage();
            textBoxStringDeConexao = new TextBox();
            labelBancoDados = new Label();
            buttonCancelarBancoDeDados = new Button();
            buttonSalvarBD = new Button();
            labelStringDeConexão = new Label();
            labelProvider = new Label();
            comboBoxProvider = new ComboBox();
            textBox1 = new TextBox();
            tabControlConfiguracoes.SuspendLayout();
            tabPageIdiomaRegiao.SuspendLayout();
            tabPageBancoDeDados.SuspendLayout();
            SuspendLayout();
            // 
            // labelConfiguracoes
            // 
            labelConfiguracoes.AutoSize = true;
            labelConfiguracoes.BackColor = Color.Transparent;
            labelConfiguracoes.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelConfiguracoes.ForeColor = Color.FromArgb(241, 241, 241);
            labelConfiguracoes.Location = new Point(1, 0);
            labelConfiguracoes.Name = "labelConfiguracoes";
            labelConfiguracoes.Size = new Size(199, 31);
            labelConfiguracoes.TabIndex = 0;
            labelConfiguracoes.Text = "CONFIGURAÇÕES";
            labelConfiguracoes.Click += labelConfiguracoes_Click;
            // 
            // tabControlConfiguracoes
            // 
            tabControlConfiguracoes.Controls.Add(tabPageIdiomaRegiao);
            tabControlConfiguracoes.Controls.Add(tabPageArmazenamentoLog);
            tabControlConfiguracoes.Controls.Add(tabPageFecharAoSair);
            tabControlConfiguracoes.Controls.Add(tabPageParametros);
            tabControlConfiguracoes.Controls.Add(tabPageBancoDeDados);
            tabControlConfiguracoes.Location = new Point(1, 47);
            tabControlConfiguracoes.Name = "tabControlConfiguracoes";
            tabControlConfiguracoes.SelectedIndex = 0;
            tabControlConfiguracoes.Size = new Size(799, 330);
            tabControlConfiguracoes.TabIndex = 1;
            // 
            // tabPageIdiomaRegiao
            // 
            tabPageIdiomaRegiao.BackColor = Color.Transparent;
            tabPageIdiomaRegiao.Controls.Add(labelIdioma);
            tabPageIdiomaRegiao.Controls.Add(buttonCancelar);
            tabPageIdiomaRegiao.Controls.Add(buttonSalvarIdioma);
            tabPageIdiomaRegiao.Controls.Add(checkBoxIdiomaReiniciar);
            tabPageIdiomaRegiao.Controls.Add(labelIdiomaRegiao);
            tabPageIdiomaRegiao.Controls.Add(comboBoxCultura);
            tabPageIdiomaRegiao.Location = new Point(4, 29);
            tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            tabPageIdiomaRegiao.Padding = new Padding(3);
            tabPageIdiomaRegiao.Size = new Size(791, 297);
            tabPageIdiomaRegiao.TabIndex = 0;
            tabPageIdiomaRegiao.Text = "Idioma/Região";
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdioma.ForeColor = Color.FromArgb(0, 41, 52);
            labelIdioma.Location = new Point(544, 12);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(168, 31);
            labelIdioma.TabIndex = 5;
            labelIdioma.Text = "Idioma/Região";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Crimson;
            buttonCancelar.BackgroundImage = (Image)resources.GetObject("buttonCancelar.BackgroundImage");
            buttonCancelar.BackgroundImageLayout = ImageLayout.None;
            buttonCancelar.ForeColor = SystemColors.ButtonFace;
            buttonCancelar.ImageAlign = ContentAlignment.TopCenter;
            buttonCancelar.Location = new Point(619, 237);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(80, 50);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.BottomCenter;
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvarIdioma
            // 
            buttonSalvarIdioma.BackColor = Color.ForestGreen;
            buttonSalvarIdioma.BackgroundImage = (Image)resources.GetObject("buttonSalvarIdioma.BackgroundImage");
            buttonSalvarIdioma.BackgroundImageLayout = ImageLayout.None;
            buttonSalvarIdioma.ForeColor = SystemColors.ButtonFace;
            buttonSalvarIdioma.Location = new Point(705, 237);
            buttonSalvarIdioma.Name = "buttonSalvarIdioma";
            buttonSalvarIdioma.Size = new Size(80, 50);
            buttonSalvarIdioma.TabIndex = 3;
            buttonSalvarIdioma.Text = "Salvar";
            buttonSalvarIdioma.TextAlign = ContentAlignment.BottomCenter;
            buttonSalvarIdioma.UseVisualStyleBackColor = false;
            buttonSalvarIdioma.Click += buttonSalvarIdioma_Click_1;
            // 
            // checkBoxIdiomaReiniciar
            // 
            checkBoxIdiomaReiniciar.AutoSize = true;
            checkBoxIdiomaReiniciar.Location = new Point(23, 108);
            checkBoxIdiomaReiniciar.Name = "checkBoxIdiomaReiniciar";
            checkBoxIdiomaReiniciar.Size = new Size(650, 24);
            checkBoxIdiomaReiniciar.TabIndex = 2;
            checkBoxIdiomaReiniciar.Text = "Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!\r\n";
            checkBoxIdiomaReiniciar.UseVisualStyleBackColor = true;
            // 
            // labelIdiomaRegiao
            // 
            labelIdiomaRegiao.AutoSize = true;
            labelIdiomaRegiao.Location = new Point(23, 41);
            labelIdiomaRegiao.Name = "labelIdiomaRegiao";
            labelIdiomaRegiao.Size = new Size(109, 20);
            labelIdiomaRegiao.TabIndex = 1;
            labelIdiomaRegiao.Text = "Idioma/Região";
            // 
            // comboBoxCultura
            // 
            comboBoxCultura.FormattingEnabled = true;
            comboBoxCultura.Location = new Point(23, 64);
            comboBoxCultura.Name = "comboBoxCultura";
            comboBoxCultura.Size = new Size(151, 28);
            comboBoxCultura.TabIndex = 0;
            // 
            // tabPageArmazenamentoLog
            // 
            tabPageArmazenamentoLog.Location = new Point(4, 29);
            tabPageArmazenamentoLog.Name = "tabPageArmazenamentoLog";
            tabPageArmazenamentoLog.Padding = new Padding(3);
            tabPageArmazenamentoLog.Size = new Size(791, 297);
            tabPageArmazenamentoLog.TabIndex = 1;
            tabPageArmazenamentoLog.Text = "Armazenamento Log";
            tabPageArmazenamentoLog.UseVisualStyleBackColor = true;
            // 
            // tabPageFecharAoSair
            // 
            tabPageFecharAoSair.Location = new Point(4, 29);
            tabPageFecharAoSair.Name = "tabPageFecharAoSair";
            tabPageFecharAoSair.Padding = new Padding(3);
            tabPageFecharAoSair.Size = new Size(791, 297);
            tabPageFecharAoSair.TabIndex = 2;
            tabPageFecharAoSair.Text = "Fechar ao sair ";
            tabPageFecharAoSair.UseVisualStyleBackColor = true;
            // 
            // tabPageParametros
            // 
            tabPageParametros.Location = new Point(4, 29);
            tabPageParametros.Name = "tabPageParametros";
            tabPageParametros.Padding = new Padding(3);
            tabPageParametros.Size = new Size(791, 297);
            tabPageParametros.TabIndex = 3;
            tabPageParametros.Text = "Parametro para Cobrança";
            tabPageParametros.UseVisualStyleBackColor = true;
            // 
            // tabPageBancoDeDados
            // 
            tabPageBancoDeDados.BackColor = Color.FromArgb(241, 241, 241);
            tabPageBancoDeDados.Controls.Add(textBoxStringDeConexao);
            tabPageBancoDeDados.Controls.Add(labelBancoDados);
            tabPageBancoDeDados.Controls.Add(buttonCancelarBancoDeDados);
            tabPageBancoDeDados.Controls.Add(buttonSalvarBD);
            tabPageBancoDeDados.Controls.Add(labelStringDeConexão);
            tabPageBancoDeDados.Controls.Add(labelProvider);
            tabPageBancoDeDados.Controls.Add(comboBoxProvider);
            tabPageBancoDeDados.Location = new Point(4, 29);
            tabPageBancoDeDados.Name = "tabPageBancoDeDados";
            tabPageBancoDeDados.Padding = new Padding(3);
            tabPageBancoDeDados.Size = new Size(791, 297);
            tabPageBancoDeDados.TabIndex = 4;
            tabPageBancoDeDados.Text = "Banco de Dados";
            // 
            // textBoxStringDeConexao
            // 
            textBoxStringDeConexao.Location = new Point(23, 141);
            textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            textBoxStringDeConexao.Size = new Size(741, 27);
            textBoxStringDeConexao.TabIndex = 8;
            // 
            // labelBancoDados
            // 
            labelBancoDados.AutoSize = true;
            labelBancoDados.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBancoDados.ForeColor = Color.FromArgb(0, 41, 52);
            labelBancoDados.Location = new Point(544, 12);
            labelBancoDados.Name = "labelBancoDados";
            labelBancoDados.Size = new Size(183, 31);
            labelBancoDados.TabIndex = 7;
            labelBancoDados.Text = "Banco de Dados";
            // 
            // buttonCancelarBancoDeDados
            // 
            buttonCancelarBancoDeDados.BackColor = Color.Crimson;
            buttonCancelarBancoDeDados.BackgroundImage = (Image)resources.GetObject("buttonCancelarBancoDeDados.BackgroundImage");
            buttonCancelarBancoDeDados.BackgroundImageLayout = ImageLayout.None;
            buttonCancelarBancoDeDados.ForeColor = SystemColors.ButtonFace;
            buttonCancelarBancoDeDados.ImageAlign = ContentAlignment.TopCenter;
            buttonCancelarBancoDeDados.Location = new Point(619, 237);
            buttonCancelarBancoDeDados.Name = "buttonCancelarBancoDeDados";
            buttonCancelarBancoDeDados.Size = new Size(80, 50);
            buttonCancelarBancoDeDados.TabIndex = 6;
            buttonCancelarBancoDeDados.Text = "Cancelar";
            buttonCancelarBancoDeDados.TextAlign = ContentAlignment.BottomCenter;
            buttonCancelarBancoDeDados.UseVisualStyleBackColor = false;
            // 
            // buttonSalvarBD
            // 
            buttonSalvarBD.BackColor = Color.ForestGreen;
            buttonSalvarBD.BackgroundImage = (Image)resources.GetObject("buttonSalvarBD.BackgroundImage");
            buttonSalvarBD.BackgroundImageLayout = ImageLayout.None;
            buttonSalvarBD.ForeColor = SystemColors.ButtonFace;
            buttonSalvarBD.Location = new Point(705, 237);
            buttonSalvarBD.Name = "buttonSalvarBD";
            buttonSalvarBD.Size = new Size(80, 50);
            buttonSalvarBD.TabIndex = 5;
            buttonSalvarBD.Text = "Salvar";
            buttonSalvarBD.TextAlign = ContentAlignment.BottomCenter;
            buttonSalvarBD.UseVisualStyleBackColor = false;
            buttonSalvarBD.Click += buttonSalvarBD_Click;
            // 
            // labelStringDeConexão
            // 
            labelStringDeConexão.AutoSize = true;
            labelStringDeConexão.Location = new Point(23, 118);
            labelStringDeConexão.Name = "labelStringDeConexão";
            labelStringDeConexão.Size = new Size(135, 20);
            labelStringDeConexão.TabIndex = 2;
            labelStringDeConexão.Text = "String de Conexão ";
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.Location = new Point(23, 41);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(67, 20);
            labelProvider.TabIndex = 1;
            labelProvider.Text = "Provider:";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "MySql.Data.MySqlClient", "System.Data.SqlClient" });
            comboBoxProvider.Location = new Point(23, 64);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(244, 28);
            comboBoxProvider.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 2;
            // 
            // FormConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 41, 52);
            ClientSize = new Size(800, 375);
            Controls.Add(textBox1);
            Controls.Add(tabControlConfiguracoes);
            Controls.Add(labelConfiguracoes);
            KeyPreview = true;
            Name = "FormConfiguracoes";
            Text = "FormConfiguracoes";
            tabControlConfiguracoes.ResumeLayout(false);
            tabPageIdiomaRegiao.ResumeLayout(false);
            tabPageIdiomaRegiao.PerformLayout();
            tabPageBancoDeDados.ResumeLayout(false);
            tabPageBancoDeDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelConfiguracoes;
        private TabControl tabControlConfiguracoes;
        private TabPage tabPageIdiomaRegiao;
        private CheckBox checkBoxIdiomaReiniciar;
        private Label labelIdiomaRegiao;
        private ComboBox comboBoxCultura;
        private TabPage tabPageArmazenamentoLog;
        private Button buttonSalvarIdioma;
        private Button buttonCancelar;
        private TextBox textBox1;
        private TabPage tabPageFecharAoSair;
        private TabPage tabPageParametros;
        private TabPage tabPageBancoDeDados;
        private Label labelProvider;
        private ComboBox comboBoxProvider;
        private Label labelStringDeConexão;
        private Label labelBancoDados;
        private Button buttonCancelarBancoDeDados;
        private Button buttonSalvarBD;
        private Label labelIdioma;
        private TextBox textBoxStringDeConexao;
    }
}