namespace Pizzaria_Do_Ze.WinApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            pictureBox1 = new PictureBox();
            buttonInicio = new Button();
            buttonFuncionario = new Button();
            buttonCliente = new Button();
            buttonIngrediente = new Button();
            buttonSabores = new Button();
            buttonProdutos = new Button();
            buttonValores = new Button();
            buttonPedidos = new Button();
            buttonConfiguracoes = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            panelSubMenu = new Panel();
            panelDados = new Panel();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem1 = new ToolStripMenuItem();
            exluirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem1 = new ToolStripMenuItem();
            excluirToolStripMenuItem2 = new ToolStripMenuItem();
            editarToolStripMenuItem2 = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem2 = new ToolStripMenuItem();
            excluirToolStripMenuItem3 = new ToolStripMenuItem();
            editarToolStripMenuItem3 = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem3 = new ToolStripMenuItem();
            excluirToolStripMenuItem4 = new ToolStripMenuItem();
            editarToolStripMenuItem4 = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem4 = new ToolStripMenuItem();
            excluirToolStripMenuItem5 = new ToolStripMenuItem();
            editarToolStripMenuItem5 = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem5 = new ToolStripMenuItem();
            excluirToolStripMenuItem6 = new ToolStripMenuItem();
            editarToolStripMenuItem6 = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystemTray = new ContextMenuStrip(components);
            abrirAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            contextMenuStripPrincipal.SuspendLayout();
            contextMenuStripSystemTray.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoPizzariaDoZe;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 176);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonInicio
            // 
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.ForeColor = Color.White;
            buttonInicio.Image = Properties.Resources.icons8_casa_24;
            buttonInicio.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInicio.Location = new Point(0, 222);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(270, 35);
            buttonInicio.TabIndex = 1;
            buttonInicio.Text = "             Início";
            buttonInicio.TextAlign = ContentAlignment.MiddleLeft;
            buttonInicio.UseVisualStyleBackColor = true;
            // 
            // buttonFuncionario
            // 
            buttonFuncionario.FlatAppearance.BorderSize = 0;
            buttonFuncionario.FlatStyle = FlatStyle.Flat;
            buttonFuncionario.ForeColor = Color.White;
            buttonFuncionario.Image = Properties.Resources.icons8_homem_de_negócios_24;
            buttonFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFuncionario.Location = new Point(0, 263);
            buttonFuncionario.Name = "buttonFuncionario";
            buttonFuncionario.Size = new Size(270, 35);
            buttonFuncionario.TabIndex = 2;
            buttonFuncionario.Text = "             Funcionário";
            buttonFuncionario.TextAlign = ContentAlignment.MiddleLeft;
            buttonFuncionario.UseVisualStyleBackColor = true;
            buttonFuncionario.Click += buttonFuncionario_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.FlatAppearance.BorderSize = 0;
            buttonCliente.FlatStyle = FlatStyle.Flat;
            buttonCliente.ForeColor = Color.White;
            buttonCliente.Image = Properties.Resources.icons8_cliente_24;
            buttonCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCliente.Location = new Point(0, 304);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(270, 35);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "             Cliente";
            buttonCliente.TextAlign = ContentAlignment.MiddleLeft;
            buttonCliente.UseVisualStyleBackColor = true;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // buttonIngrediente
            // 
            buttonIngrediente.FlatAppearance.BorderSize = 0;
            buttonIngrediente.FlatStyle = FlatStyle.Flat;
            buttonIngrediente.ForeColor = Color.White;
            buttonIngrediente.Image = Properties.Resources.icons8_tomate_24__1_;
            buttonIngrediente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonIngrediente.Location = new Point(0, 345);
            buttonIngrediente.Name = "buttonIngrediente";
            buttonIngrediente.Size = new Size(270, 35);
            buttonIngrediente.TabIndex = 4;
            buttonIngrediente.Text = "             Ingredientes";
            buttonIngrediente.TextAlign = ContentAlignment.MiddleLeft;
            buttonIngrediente.UseVisualStyleBackColor = true;
            buttonIngrediente.Click += buttonIngrediente_Click;
            // 
            // buttonSabores
            // 
            buttonSabores.FlatAppearance.BorderSize = 0;
            buttonSabores.FlatStyle = FlatStyle.Flat;
            buttonSabores.ForeColor = Color.White;
            buttonSabores.Image = Properties.Resources.icons8_pizza_24;
            buttonSabores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSabores.Location = new Point(0, 386);
            buttonSabores.Name = "buttonSabores";
            buttonSabores.Size = new Size(270, 35);
            buttonSabores.TabIndex = 5;
            buttonSabores.Text = "             Sabores";
            buttonSabores.TextAlign = ContentAlignment.MiddleLeft;
            buttonSabores.UseVisualStyleBackColor = true;
            buttonSabores.Click += buttonSabores_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.FlatAppearance.BorderSize = 0;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.ForeColor = Color.White;
            buttonProdutos.Image = Properties.Resources.icons8_ingredientes_24;
            buttonProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProdutos.Location = new Point(0, 427);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(270, 35);
            buttonProdutos.TabIndex = 6;
            buttonProdutos.Text = "             Produtos";
            buttonProdutos.TextAlign = ContentAlignment.MiddleLeft;
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonValores
            // 
            buttonValores.FlatAppearance.BorderSize = 0;
            buttonValores.FlatStyle = FlatStyle.Flat;
            buttonValores.ForeColor = Color.White;
            buttonValores.Image = Properties.Resources.icons8_dinheiro_24;
            buttonValores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonValores.Location = new Point(0, 468);
            buttonValores.Name = "buttonValores";
            buttonValores.Size = new Size(270, 35);
            buttonValores.TabIndex = 7;
            buttonValores.Text = "             Valores";
            buttonValores.TextAlign = ContentAlignment.MiddleLeft;
            buttonValores.UseVisualStyleBackColor = true;
            buttonValores.Click += buttonValores_Click;
            // 
            // buttonPedidos
            // 
            buttonPedidos.FlatAppearance.BorderSize = 0;
            buttonPedidos.FlatStyle = FlatStyle.Flat;
            buttonPedidos.ForeColor = Color.White;
            buttonPedidos.Image = Properties.Resources.icons8_scooter_24;
            buttonPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPedidos.Location = new Point(0, 509);
            buttonPedidos.Name = "buttonPedidos";
            buttonPedidos.Size = new Size(270, 35);
            buttonPedidos.TabIndex = 8;
            buttonPedidos.Text = "             Pedidos";
            buttonPedidos.TextAlign = ContentAlignment.MiddleLeft;
            buttonPedidos.UseVisualStyleBackColor = true;
            buttonPedidos.Click += buttonPedidos_Click;
            // 
            // buttonConfiguracoes
            // 
            buttonConfiguracoes.FlatAppearance.BorderSize = 0;
            buttonConfiguracoes.FlatStyle = FlatStyle.Flat;
            buttonConfiguracoes.ForeColor = Color.White;
            buttonConfiguracoes.Image = Properties.Resources.roda_dentada__1__1;
            buttonConfiguracoes.Location = new Point(230, 901);
            buttonConfiguracoes.Name = "buttonConfiguracoes";
            buttonConfiguracoes.Size = new Size(40, 40);
            buttonConfiguracoes.TabIndex = 12;
            buttonConfiguracoes.UseVisualStyleBackColor = true;
            buttonConfiguracoes.Click += buttonConfiguracoes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Frame_2;
            pictureBox2.Location = new Point(238, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 35);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Frame_2;
            pictureBox3.Location = new Point(238, 263);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 35);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Frame_2;
            pictureBox4.Location = new Point(238, 304);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 35);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Frame_2;
            pictureBox5.Location = new Point(238, 345);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 35);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Frame_2;
            pictureBox6.Location = new Point(238, 386);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 35);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Frame_2;
            pictureBox7.Location = new Point(238, 427);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 35);
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Frame_2;
            pictureBox8.Location = new Point(238, 468);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 35);
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Frame_2;
            pictureBox9.Location = new Point(238, 509);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 35);
            pictureBox9.TabIndex = 20;
            pictureBox9.TabStop = false;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(113, 134, 139);
            panelSubMenu.Location = new Point(276, 0);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(1278, 158);
            panelSubMenu.TabIndex = 21;
            // 
            // panelDados
            // 
            panelDados.BackColor = Color.FromArgb(241, 241, 241);
            panelDados.Location = new Point(276, 179);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(1268, 771);
            panelDados.TabIndex = 22;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.ImageScalingSize = new Size(20, 20);
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { funcionárioToolStripMenuItem, clienteToolStripMenuItem, ingredientesToolStripMenuItem, saboresToolStripMenuItem, produtosToolStripMenuItem, valoresToolStripMenuItem, pedidosToolStripMenuItem, configuraçõesToolStripMenuItem, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(178, 238);
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, excluirToolStripMenuItem, editarToolStripMenuItem });
            funcionárioToolStripMenuItem.Image = Properties.Resources.icons8_homem_de_negócios_24;
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(177, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            adicionarToolStripMenuItem.Size = new Size(220, 26);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            excluirToolStripMenuItem.Size = new Size(220, 26);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem.Size = new Size(220, 26);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem1, exluirToolStripMenuItem, editarToolStripMenuItem1 });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(177, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // adicionarToolStripMenuItem1
            // 
            adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            adicionarToolStripMenuItem1.ShortcutKeys = Keys.Shift | Keys.F1;
            adicionarToolStripMenuItem1.Size = new Size(220, 26);
            adicionarToolStripMenuItem1.Text = "Adicionar";
            adicionarToolStripMenuItem1.Click += adicionarToolStripMenuItem1_Click;
            // 
            // exluirToolStripMenuItem
            // 
            exluirToolStripMenuItem.Name = "exluirToolStripMenuItem";
            exluirToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            exluirToolStripMenuItem.Size = new Size(220, 26);
            exluirToolStripMenuItem.Text = "Excluir";
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem1.Size = new Size(220, 26);
            editarToolStripMenuItem1.Text = "Editar";
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excluirToolStripMenuItem1, excluirToolStripMenuItem2, editarToolStripMenuItem2 });
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(177, 26);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            // 
            // excluirToolStripMenuItem1
            // 
            excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            excluirToolStripMenuItem1.ShortcutKeys = Keys.Shift | Keys.F1;
            excluirToolStripMenuItem1.Size = new Size(220, 26);
            excluirToolStripMenuItem1.Text = "Adicionar";
            excluirToolStripMenuItem1.Click += excluirToolStripMenuItem1_Click;
            // 
            // excluirToolStripMenuItem2
            // 
            excluirToolStripMenuItem2.Name = "excluirToolStripMenuItem2";
            excluirToolStripMenuItem2.ShortcutKeys = Keys.Shift | Keys.F2;
            excluirToolStripMenuItem2.Size = new Size(220, 26);
            excluirToolStripMenuItem2.Text = "Excluir";
            // 
            // editarToolStripMenuItem2
            // 
            editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            editarToolStripMenuItem2.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem2.Size = new Size(220, 26);
            editarToolStripMenuItem2.Text = "Editar";
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem2, excluirToolStripMenuItem3, editarToolStripMenuItem3 });
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.Size = new Size(177, 26);
            saboresToolStripMenuItem.Text = "Sabores";
            // 
            // adicionarToolStripMenuItem2
            // 
            adicionarToolStripMenuItem2.Name = "adicionarToolStripMenuItem2";
            adicionarToolStripMenuItem2.ShortcutKeys = Keys.Shift | Keys.F1;
            adicionarToolStripMenuItem2.Size = new Size(220, 26);
            adicionarToolStripMenuItem2.Text = "Adicionar";
            adicionarToolStripMenuItem2.Click += adicionarToolStripMenuItem2_Click;
            // 
            // excluirToolStripMenuItem3
            // 
            excluirToolStripMenuItem3.Name = "excluirToolStripMenuItem3";
            excluirToolStripMenuItem3.ShortcutKeys = Keys.Shift | Keys.F2;
            excluirToolStripMenuItem3.Size = new Size(220, 26);
            excluirToolStripMenuItem3.Text = "Excluir";
            // 
            // editarToolStripMenuItem3
            // 
            editarToolStripMenuItem3.Name = "editarToolStripMenuItem3";
            editarToolStripMenuItem3.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem3.Size = new Size(220, 26);
            editarToolStripMenuItem3.Text = "Editar";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem3, excluirToolStripMenuItem4, editarToolStripMenuItem4 });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(177, 26);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarToolStripMenuItem3
            // 
            adicionarToolStripMenuItem3.Name = "adicionarToolStripMenuItem3";
            adicionarToolStripMenuItem3.ShortcutKeys = Keys.Shift | Keys.F1;
            adicionarToolStripMenuItem3.Size = new Size(220, 26);
            adicionarToolStripMenuItem3.Text = "Adicionar";
            adicionarToolStripMenuItem3.Click += adicionarToolStripMenuItem3_Click;
            // 
            // excluirToolStripMenuItem4
            // 
            excluirToolStripMenuItem4.Name = "excluirToolStripMenuItem4";
            excluirToolStripMenuItem4.ShortcutKeys = Keys.Shift | Keys.F2;
            excluirToolStripMenuItem4.Size = new Size(220, 26);
            excluirToolStripMenuItem4.Text = "Excluir";
            // 
            // editarToolStripMenuItem4
            // 
            editarToolStripMenuItem4.Name = "editarToolStripMenuItem4";
            editarToolStripMenuItem4.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem4.Size = new Size(220, 26);
            editarToolStripMenuItem4.Text = "Editar";
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem4, excluirToolStripMenuItem5, editarToolStripMenuItem5 });
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.Size = new Size(177, 26);
            valoresToolStripMenuItem.Text = "Valores";
            // 
            // adicionarToolStripMenuItem4
            // 
            adicionarToolStripMenuItem4.Name = "adicionarToolStripMenuItem4";
            adicionarToolStripMenuItem4.ShortcutKeys = Keys.Shift | Keys.F1;
            adicionarToolStripMenuItem4.Size = new Size(220, 26);
            adicionarToolStripMenuItem4.Text = "Adicionar";
            adicionarToolStripMenuItem4.Click += adicionarToolStripMenuItem4_Click;
            // 
            // excluirToolStripMenuItem5
            // 
            excluirToolStripMenuItem5.Name = "excluirToolStripMenuItem5";
            excluirToolStripMenuItem5.ShortcutKeys = Keys.Shift | Keys.F2;
            excluirToolStripMenuItem5.Size = new Size(220, 26);
            excluirToolStripMenuItem5.Text = "Excluir";
            // 
            // editarToolStripMenuItem5
            // 
            editarToolStripMenuItem5.Name = "editarToolStripMenuItem5";
            editarToolStripMenuItem5.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem5.Size = new Size(220, 26);
            editarToolStripMenuItem5.Text = "Editar";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem5, excluirToolStripMenuItem6, editarToolStripMenuItem6 });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(177, 26);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // adicionarToolStripMenuItem5
            // 
            adicionarToolStripMenuItem5.Name = "adicionarToolStripMenuItem5";
            adicionarToolStripMenuItem5.ShortcutKeys = Keys.Shift | Keys.F1;
            adicionarToolStripMenuItem5.Size = new Size(220, 26);
            adicionarToolStripMenuItem5.Text = "Adicionar";
            adicionarToolStripMenuItem5.Click += adicionarToolStripMenuItem5_Click;
            // 
            // excluirToolStripMenuItem6
            // 
            excluirToolStripMenuItem6.Name = "excluirToolStripMenuItem6";
            excluirToolStripMenuItem6.ShortcutKeys = Keys.Shift | Keys.F2;
            excluirToolStripMenuItem6.Size = new Size(220, 26);
            excluirToolStripMenuItem6.Text = "Excluir";
            // 
            // editarToolStripMenuItem6
            // 
            editarToolStripMenuItem6.Name = "editarToolStripMenuItem6";
            editarToolStripMenuItem6.ShortcutKeys = Keys.Shift | Keys.F3;
            editarToolStripMenuItem6.Size = new Size(220, 26);
            editarToolStripMenuItem6.Text = "Editar";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(177, 26);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(177, 26);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipText = "Info";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystemTray;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé rodando em segundo plano\r\n";
            notifyIconSystemTray.MouseDoubleClick += notifyIconSystemTray_MouseDoubleClick;
            // 
            // contextMenuStripSystemTray
            // 
            contextMenuStripSystemTray.ImageScalingSize = new Size(20, 20);
            contextMenuStripSystemTray.Items.AddRange(new ToolStripItem[] { abrirAplicaçãoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystemTray.Name = "contextMenuStripSystemTray";
            contextMenuStripSystemTray.Size = new Size(182, 76);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            abrirAplicaçãoToolStripMenuItem.Size = new Size(181, 24);
            abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            abrirAplicaçãoToolStripMenuItem.Click += abrirAplicaçãoToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(181, 24);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(181, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 41, 52);
            ClientSize = new Size(1552, 953);
            ContextMenuStrip = contextMenuStripPrincipal;
            Controls.Add(panelDados);
            Controls.Add(panelSubMenu);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(buttonConfiguracoes);
            Controls.Add(buttonPedidos);
            Controls.Add(buttonValores);
            Controls.Add(buttonProdutos);
            Controls.Add(buttonSabores);
            Controls.Add(buttonIngrediente);
            Controls.Add(buttonCliente);
            Controls.Add(buttonFuncionario);
            Controls.Add(buttonInicio);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "TelaPrincipal";
            Text = "Pizzaria do Zé";
            Resize += TelaPrincipal_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStripSystemTray.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonInicio;
        private Button buttonFuncionario;
        private Button buttonCliente;
        private Button buttonIngrediente;
        private Button buttonSabores;
        private Button buttonProdutos;
        private Button buttonValores;
        private Button buttonPedidos;
        private Button buttonConfiguracoes;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Panel panelSubMenu;
        private Panel panel1;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel panelDados;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem1;
        private ToolStripMenuItem exluirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem excluirToolStripMenuItem1;
        private ToolStripMenuItem excluirToolStripMenuItem2;
        private ToolStripMenuItem editarToolStripMenuItem2;
        private ToolStripMenuItem adicionarToolStripMenuItem2;
        private ToolStripMenuItem excluirToolStripMenuItem3;
        private ToolStripMenuItem editarToolStripMenuItem3;
        private ToolStripMenuItem adicionarToolStripMenuItem3;
        private ToolStripMenuItem excluirToolStripMenuItem4;
        private ToolStripMenuItem editarToolStripMenuItem4;
        private ToolStripMenuItem adicionarToolStripMenuItem4;
        private ToolStripMenuItem excluirToolStripMenuItem5;
        private ToolStripMenuItem editarToolStripMenuItem5;
        private ToolStripMenuItem adicionarToolStripMenuItem5;
        private ToolStripMenuItem excluirToolStripMenuItem6;
        private ToolStripMenuItem editarToolStripMenuItem6;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStripSystemTray;
        private ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}