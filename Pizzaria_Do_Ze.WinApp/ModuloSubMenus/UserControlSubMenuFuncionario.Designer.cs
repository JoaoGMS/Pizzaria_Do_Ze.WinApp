namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuFuncionario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionarFuncionario = new Button();
            buttonEditarFuncionario = new Button();
            buttonExcluirFuncionario = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarFuncionario
            // 
            buttonAdicionarFuncionario.FlatAppearance.BorderColor = Color.White;
            buttonAdicionarFuncionario.FlatAppearance.BorderSize = 2;
            buttonAdicionarFuncionario.FlatStyle = FlatStyle.Flat;
            buttonAdicionarFuncionario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarFuncionario.ForeColor = Color.White;
            buttonAdicionarFuncionario.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarFuncionario.Location = new Point(5, 49);
            buttonAdicionarFuncionario.Name = "buttonAdicionarFuncionario";
            buttonAdicionarFuncionario.Size = new Size(299, 60);
            buttonAdicionarFuncionario.TabIndex = 9;
            buttonAdicionarFuncionario.Text = "Adicionar Funcionário";
            buttonAdicionarFuncionario.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarFuncionario.UseVisualStyleBackColor = true;
            buttonAdicionarFuncionario.Click += buttonAdicionarFuncionario_Click;
            // 
            // buttonEditarFuncionario
            // 
            buttonEditarFuncionario.FlatAppearance.BorderColor = Color.White;
            buttonEditarFuncionario.FlatAppearance.BorderSize = 2;
            buttonEditarFuncionario.FlatStyle = FlatStyle.Flat;
            buttonEditarFuncionario.ForeColor = Color.Cornsilk;
            buttonEditarFuncionario.Image = Properties.Resources.Edit;
            buttonEditarFuncionario.Location = new Point(1200, 49);
            buttonEditarFuncionario.Name = "buttonEditarFuncionario";
            buttonEditarFuncionario.Size = new Size(60, 60);
            buttonEditarFuncionario.TabIndex = 11;
            buttonEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirFuncionario
            // 
            buttonExcluirFuncionario.FlatAppearance.BorderColor = Color.White;
            buttonExcluirFuncionario.FlatAppearance.BorderSize = 2;
            buttonExcluirFuncionario.FlatStyle = FlatStyle.Flat;
            buttonExcluirFuncionario.ForeColor = Color.Cornsilk;
            buttonExcluirFuncionario.Image = Properties.Resources.Delete;
            buttonExcluirFuncionario.Location = new Point(1134, 49);
            buttonExcluirFuncionario.Name = "buttonExcluirFuncionario";
            buttonExcluirFuncionario.Size = new Size(60, 60);
            buttonExcluirFuncionario.TabIndex = 10;
            buttonExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonExcluirFuncionario);
            Controls.Add(buttonEditarFuncionario);
            Controls.Add(buttonAdicionarFuncionario);
            Name = "UserControlSubMenuFuncionario";
            Size = new Size(1278, 158);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarFuncionario;
        private Button buttonEditarFuncionario;
        private Button buttonExcluirFuncionario;
    }
}
