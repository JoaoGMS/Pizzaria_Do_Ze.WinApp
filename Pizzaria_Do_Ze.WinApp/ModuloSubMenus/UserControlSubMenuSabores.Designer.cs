namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuSabores
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
            buttonAdicionarSabor = new Button();
            buttonEditarSabor = new Button();
            buttonExcluirSabor = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarSabor
            // 
            buttonAdicionarSabor.BackColor = Color.Transparent;
            buttonAdicionarSabor.FlatAppearance.BorderSize = 2;
            buttonAdicionarSabor.FlatStyle = FlatStyle.Flat;
            buttonAdicionarSabor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarSabor.ForeColor = Color.White;
            buttonAdicionarSabor.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarSabor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarSabor.Location = new Point(5, 49);
            buttonAdicionarSabor.Name = "buttonAdicionarSabor";
            buttonAdicionarSabor.Size = new Size(299, 60);
            buttonAdicionarSabor.TabIndex = 9;
            buttonAdicionarSabor.Text = "Adicionar Sabor";
            buttonAdicionarSabor.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarSabor.UseVisualStyleBackColor = false;
            buttonAdicionarSabor.Click += buttonAdicionarSabor_Click;
            // 
            // buttonEditarSabor
            // 
            buttonEditarSabor.FlatAppearance.BorderColor = Color.White;
            buttonEditarSabor.FlatAppearance.BorderSize = 2;
            buttonEditarSabor.FlatStyle = FlatStyle.Flat;
            buttonEditarSabor.Image = Properties.Resources.Edit;
            buttonEditarSabor.Location = new Point(1200, 49);
            buttonEditarSabor.Name = "buttonEditarSabor";
            buttonEditarSabor.Size = new Size(60, 60);
            buttonEditarSabor.TabIndex = 11;
            buttonEditarSabor.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirSabor
            // 
            buttonExcluirSabor.FlatAppearance.BorderColor = Color.White;
            buttonExcluirSabor.FlatAppearance.BorderSize = 2;
            buttonExcluirSabor.FlatStyle = FlatStyle.Flat;
            buttonExcluirSabor.Image = Properties.Resources.Delete;
            buttonExcluirSabor.Location = new Point(1134, 49);
            buttonExcluirSabor.Name = "buttonExcluirSabor";
            buttonExcluirSabor.Size = new Size(60, 60);
            buttonExcluirSabor.TabIndex = 10;
            buttonExcluirSabor.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuSabores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonExcluirSabor);
            Controls.Add(buttonEditarSabor);
            Controls.Add(buttonAdicionarSabor);
            ForeColor = Color.FromArgb(113, 134, 139);
            Name = "UserControlSubMenuSabores";
            Size = new Size(1278, 158);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarSabor;
        private Button buttonEditarSabor;
        private Button buttonExcluirSabor;
    }
}
