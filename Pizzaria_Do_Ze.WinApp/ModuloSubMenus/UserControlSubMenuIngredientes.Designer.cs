namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuIngredientes
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
            buttonAdicionarIngredientes = new Button();
            buttonExcluirIngrediente = new Button();
            buttonEditarIngrediente = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarIngredientes
            // 
            buttonAdicionarIngredientes.FlatAppearance.BorderColor = Color.White;
            buttonAdicionarIngredientes.FlatAppearance.BorderSize = 2;
            buttonAdicionarIngredientes.FlatStyle = FlatStyle.Flat;
            buttonAdicionarIngredientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarIngredientes.ForeColor = Color.White;
            buttonAdicionarIngredientes.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarIngredientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarIngredientes.Location = new Point(5, 49);
            buttonAdicionarIngredientes.Name = "buttonAdicionarIngredientes";
            buttonAdicionarIngredientes.Size = new Size(299, 60);
            buttonAdicionarIngredientes.TabIndex = 9;
            buttonAdicionarIngredientes.Text = "Adicionar Ingredientes";
            buttonAdicionarIngredientes.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarIngredientes.UseVisualStyleBackColor = true;
            buttonAdicionarIngredientes.Click += buttonAdicionarIngredientes_Click;
            // 
            // buttonExcluirIngrediente
            // 
            buttonExcluirIngrediente.FlatAppearance.BorderColor = Color.White;
            buttonExcluirIngrediente.FlatAppearance.BorderSize = 2;
            buttonExcluirIngrediente.FlatStyle = FlatStyle.Flat;
            buttonExcluirIngrediente.ForeColor = Color.DarkKhaki;
            buttonExcluirIngrediente.Image = Properties.Resources.Delete;
            buttonExcluirIngrediente.Location = new Point(1134, 49);
            buttonExcluirIngrediente.Name = "buttonExcluirIngrediente";
            buttonExcluirIngrediente.Size = new Size(60, 60);
            buttonExcluirIngrediente.TabIndex = 10;
            buttonExcluirIngrediente.UseVisualStyleBackColor = true;
            // 
            // buttonEditarIngrediente
            // 
            buttonEditarIngrediente.FlatAppearance.BorderColor = Color.White;
            buttonEditarIngrediente.FlatAppearance.BorderSize = 2;
            buttonEditarIngrediente.FlatStyle = FlatStyle.Flat;
            buttonEditarIngrediente.ForeColor = Color.DarkKhaki;
            buttonEditarIngrediente.Image = Properties.Resources.Edit;
            buttonEditarIngrediente.Location = new Point(1200, 49);
            buttonEditarIngrediente.Name = "buttonEditarIngrediente";
            buttonEditarIngrediente.Size = new Size(60, 60);
            buttonEditarIngrediente.TabIndex = 11;
            buttonEditarIngrediente.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonEditarIngrediente);
            Controls.Add(buttonExcluirIngrediente);
            Controls.Add(buttonAdicionarIngredientes);
            Name = "UserControlSubMenuIngredientes";
            Size = new Size(1278, 158);
            Load += UserControlSubMenuIngredientes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarIngredientes;
        private Button buttonExcluirIngrediente;
        private Button buttonEditarIngrediente;
    }
}
