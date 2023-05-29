namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuValor
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
            buttonAdicionarValor = new Button();
            buttonExcluirValor = new Button();
            buttonEditarValor = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarValor
            // 
            buttonAdicionarValor.FlatAppearance.BorderSize = 2;
            buttonAdicionarValor.FlatStyle = FlatStyle.Flat;
            buttonAdicionarValor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarValor.ForeColor = Color.White;
            buttonAdicionarValor.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarValor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarValor.Location = new Point(5, 49);
            buttonAdicionarValor.Name = "buttonAdicionarValor";
            buttonAdicionarValor.Size = new Size(299, 60);
            buttonAdicionarValor.TabIndex = 9;
            buttonAdicionarValor.Text = "Adicionar Valor";
            buttonAdicionarValor.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarValor.UseVisualStyleBackColor = true;
            buttonAdicionarValor.Click += buttonAdicionarValor_Click;
            // 
            // buttonExcluirValor
            // 
            buttonExcluirValor.FlatAppearance.BorderColor = Color.White;
            buttonExcluirValor.FlatAppearance.BorderSize = 2;
            buttonExcluirValor.FlatStyle = FlatStyle.Flat;
            buttonExcluirValor.ForeColor = Color.White;
            buttonExcluirValor.Image = Properties.Resources.Delete;
            buttonExcluirValor.Location = new Point(1134, 49);
            buttonExcluirValor.Name = "buttonExcluirValor";
            buttonExcluirValor.Size = new Size(60, 60);
            buttonExcluirValor.TabIndex = 10;
            buttonExcluirValor.UseVisualStyleBackColor = true;
            // 
            // buttonEditarValor
            // 
            buttonEditarValor.FlatAppearance.BorderColor = Color.White;
            buttonEditarValor.FlatAppearance.BorderSize = 2;
            buttonEditarValor.FlatStyle = FlatStyle.Flat;
            buttonEditarValor.ForeColor = Color.White;
            buttonEditarValor.Image = Properties.Resources.Edit;
            buttonEditarValor.Location = new Point(1200, 49);
            buttonEditarValor.Name = "buttonEditarValor";
            buttonEditarValor.Size = new Size(60, 60);
            buttonEditarValor.TabIndex = 11;
            buttonEditarValor.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuValor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonEditarValor);
            Controls.Add(buttonExcluirValor);
            Controls.Add(buttonAdicionarValor);
            ForeColor = Color.FromArgb(113, 134, 139);
            Name = "UserControlSubMenuValor";
            Size = new Size(1278, 158);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarValor;
        private Button buttonExcluirValor;
        private Button buttonEditarValor;
    }
}
