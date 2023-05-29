namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuCliente
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
            buttonAdicionarCliente = new Button();
            buttonExcluirCliente = new Button();
            buttonEditarCliente = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.FlatAppearance.BorderSize = 2;
            buttonAdicionarCliente.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarCliente.ForeColor = Color.White;
            buttonAdicionarCliente.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarCliente.Location = new Point(5, 49);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(299, 60);
            buttonAdicionarCliente.TabIndex = 9;
            buttonAdicionarCliente.Text = "Adicionar Cliente";
            buttonAdicionarCliente.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonExcluirCliente
            // 
            buttonExcluirCliente.FlatAppearance.BorderColor = Color.White;
            buttonExcluirCliente.FlatAppearance.BorderSize = 2;
            buttonExcluirCliente.FlatStyle = FlatStyle.Flat;
            buttonExcluirCliente.ForeColor = Color.White;
            buttonExcluirCliente.Image = Properties.Resources.Delete;
            buttonExcluirCliente.Location = new Point(1134, 49);
            buttonExcluirCliente.Name = "buttonExcluirCliente";
            buttonExcluirCliente.Size = new Size(60, 60);
            buttonExcluirCliente.TabIndex = 10;
            buttonExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.FlatAppearance.BorderColor = Color.White;
            buttonEditarCliente.FlatAppearance.BorderSize = 2;
            buttonEditarCliente.FlatStyle = FlatStyle.Flat;
            buttonEditarCliente.ForeColor = Color.White;
            buttonEditarCliente.Image = Properties.Resources.Edit;
            buttonEditarCliente.Location = new Point(1200, 49);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(60, 60);
            buttonEditarCliente.TabIndex = 11;
            buttonEditarCliente.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonEditarCliente);
            Controls.Add(buttonExcluirCliente);
            Controls.Add(buttonAdicionarCliente);
            Name = "UserControlSubMenuCliente";
            Size = new Size(1278, 158);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarCliente;
        private Button buttonExcluirCliente;
        private Button buttonEditarCliente;
    }
}
