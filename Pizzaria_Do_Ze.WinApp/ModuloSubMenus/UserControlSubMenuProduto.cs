using PizzariaDoZe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.WinApp.ModuloSubMenus
{
    public partial class UserControlSubMenuProduto : UserControl
    {
        public UserControlSubMenuProduto()
        {
            InitializeComponent();
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormProduto produto = new FormProduto()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = produto.ShowDialog();
        }
    }
}
