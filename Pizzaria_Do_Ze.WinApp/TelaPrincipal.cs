using Pizzaria_do_Zé;
using Pizzaria_Do_Ze.WinApp.ModuloSubMenus;
using PizzariaDoZe;

namespace Pizzaria_Do_Ze.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        #region MÉTODOS
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelSubMenu.Controls.Clear();
            panelSubMenu.Controls.Add(userControl);

        }

        #endregion 

        #region EVENTOS


        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            UserControlSubMenuFuncionario funcionario = new();
            addUserControl(funcionario);
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            UserControlSubMenuCliente cliente = new();
            addUserControl(cliente);
        }

        private void buttonIngrediente_Click(object sender, EventArgs e)
        {
            UserControlSubMenuIngredientes ingrediente = new();
            addUserControl(ingrediente);
        }

        private void buttonSabores_Click(object sender, EventArgs e)
        {
            UserControlSubMenuSabores sabor = new();
            addUserControl(sabor);
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            UserControlSubMenuProduto produto = new();
            addUserControl(produto);
        }

        private void buttonValores_Click(object sender, EventArgs e)
        {
            UserControlSubMenuValor valor = new();
            addUserControl(valor);
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            UserControlSubMenuPedido pedido = new();
            addUserControl(pedido);
        }

        private void buttonConfiguracoes_Click(object sender, EventArgs e)
        {
            FormConfiguracoes config = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = config.ShowDialog();

        }

        #endregion

        #region TOOLSTRIP


        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlSubMenuFuncionario uc = new UserControlSubMenuFuncionario();
            addUserControl(uc);

            FormFuncionario funcionario = new FormFuncionario()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = funcionario.ShowDialog();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControlSubMenuCliente uc = new UserControlSubMenuCliente();
            addUserControl(uc);

            FormCliente cliente = new FormCliente()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = cliente.ShowDialog();

        }
        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControlSubMenuIngredientes uc = new UserControlSubMenuIngredientes();
            addUserControl(uc);

            FormIngrediente ingrediente = new FormIngrediente()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = ingrediente.ShowDialog();
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserControlSubMenuSabores uc = new UserControlSubMenuSabores();
            addUserControl(uc);

            FormSabores sabores = new FormSabores()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = sabores.ShowDialog();
        }

        private void adicionarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UserControlSubMenuProduto uc = new UserControlSubMenuProduto();
            addUserControl(uc);

            FormProduto produto = new FormProduto()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = produto.ShowDialog();
        }

        private void adicionarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UserControlSubMenuValor uc = new UserControlSubMenuValor();
            addUserControl(uc);

            FormValores valores = new FormValores()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = valores.ShowDialog();
        }

        private void adicionarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UserControlSubMenuPedido uc = new UserControlSubMenuPedido();
            addUserControl(uc);

            /* FormPedido pedido = new FormPedido()
             {
                 StartPosition = FormStartPosition.CenterScreen,

             };
             _ = produtos.ShowDialog();*/
        }
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoes config = new()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _ = config.ShowDialog();
        } //Abrir configurações
        #endregion



        private void TelaPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void abrirAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}