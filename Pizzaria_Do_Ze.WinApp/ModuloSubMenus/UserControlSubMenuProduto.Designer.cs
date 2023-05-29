namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    partial class UserControlSubMenuProduto
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
            buttonAdicionarProduto = new Button();
            buttonExcluirProduto = new Button();
            buttonEditarProduto = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.FlatAppearance.BorderSize = 2;
            buttonAdicionarProduto.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarProduto.ForeColor = Color.White;
            buttonAdicionarProduto.Image = Properties.Resources.icons8_adicionar_50;
            buttonAdicionarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarProduto.Location = new Point(5, 49);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(299, 60);
            buttonAdicionarProduto.TabIndex = 9;
            buttonAdicionarProduto.Text = "Adicionar Produto";
            buttonAdicionarProduto.TextAlign = ContentAlignment.MiddleRight;
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonExcluirProduto
            // 
            buttonExcluirProduto.FlatAppearance.BorderColor = Color.White;
            buttonExcluirProduto.FlatAppearance.BorderSize = 2;
            buttonExcluirProduto.FlatStyle = FlatStyle.Flat;
            buttonExcluirProduto.Image = Properties.Resources.Delete;
            buttonExcluirProduto.Location = new Point(1134, 49);
            buttonExcluirProduto.Name = "buttonExcluirProduto";
            buttonExcluirProduto.Size = new Size(60, 60);
            buttonExcluirProduto.TabIndex = 10;
            buttonExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // buttonEditarProduto
            // 
            buttonEditarProduto.FlatAppearance.BorderColor = Color.White;
            buttonEditarProduto.FlatAppearance.BorderSize = 2;
            buttonEditarProduto.FlatStyle = FlatStyle.Flat;
            buttonEditarProduto.Image = Properties.Resources.Edit;
            buttonEditarProduto.Location = new Point(1200, 49);
            buttonEditarProduto.Name = "buttonEditarProduto";
            buttonEditarProduto.Size = new Size(60, 60);
            buttonEditarProduto.TabIndex = 11;
            buttonEditarProduto.UseVisualStyleBackColor = true;
            // 
            // UserControlSubMenuProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 134, 139);
            Controls.Add(buttonEditarProduto);
            Controls.Add(buttonExcluirProduto);
            Controls.Add(buttonAdicionarProduto);
            Name = "UserControlSubMenuProduto";
            Size = new Size(1278, 158);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
        private Button buttonExcluirProduto;
        private Button buttonEditarProduto;
    }
}
