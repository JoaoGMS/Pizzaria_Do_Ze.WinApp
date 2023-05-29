namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuPedido
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
            buttonAdicionarPedido = new Button();
            buttonEditarPedido = new Button();
            buttonExcluirPedido = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarPedido
            // 
            buttonAdicionarPedido.FlatAppearance.BorderColor = Color.White;
            buttonAdicionarPedido.FlatAppearance.BorderSize = 2;
            buttonAdicionarPedido.FlatStyle = FlatStyle.Flat;
            buttonAdicionarPedido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarPedido.ForeColor = Color.White;
            buttonAdicionarPedido.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarPedido.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarPedido.Location = new Point(5, 49);
            buttonAdicionarPedido.Name = "buttonAdicionarPedido";
            buttonAdicionarPedido.Size = new Size(299, 60);
            buttonAdicionarPedido.TabIndex = 9;
            buttonAdicionarPedido.Text = "Adicionar Pedido";
            buttonAdicionarPedido.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarPedido.UseVisualStyleBackColor = true;
            buttonAdicionarPedido.Click += buttonAdicionarPedido_Click;
            // 
            // buttonEditarPedido
            // 
            buttonEditarPedido.FlatAppearance.BorderColor = Color.White;
            buttonEditarPedido.FlatAppearance.BorderSize = 2;
            buttonEditarPedido.FlatStyle = FlatStyle.Flat;
            buttonEditarPedido.Image = Properties.Resources.Edit;
            buttonEditarPedido.Location = new Point(1200, 49);
            buttonEditarPedido.Name = "buttonEditarPedido";
            buttonEditarPedido.Size = new Size(60, 60);
            buttonEditarPedido.TabIndex = 11;
            buttonEditarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirPedido
            // 
            buttonExcluirPedido.FlatAppearance.BorderColor = Color.White;
            buttonExcluirPedido.FlatAppearance.BorderSize = 2;
            buttonExcluirPedido.FlatStyle = FlatStyle.Flat;
            buttonExcluirPedido.Image = Properties.Resources.Delete;
            buttonExcluirPedido.Location = new Point(1134, 49);
            buttonExcluirPedido.Name = "buttonExcluirPedido";
            buttonExcluirPedido.Size = new Size(60, 60);
            buttonExcluirPedido.TabIndex = 10;
            buttonExcluirPedido.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonExcluirPedido);
            Controls.Add(buttonEditarPedido);
            Controls.Add(buttonAdicionarPedido);
            Name = "UserControlSubMenuPedido";
            Size = new Size(1278, 158);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarPedido;
        private Button buttonEditarPedido;
        private Button buttonExcluirPedido;
    }
}
