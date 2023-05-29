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
    public partial class UserControlSubMenuFuncionario : UserControl
    {
        public UserControlSubMenuFuncionario()
        {
            InitializeComponent();
        }

        private void buttonAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario funcionario = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = funcionario.ShowDialog();
        }
    }
}
