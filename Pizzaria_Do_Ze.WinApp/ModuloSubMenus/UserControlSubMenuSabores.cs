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
    public partial class UserControlSubMenuSabores : UserControl
    {
        public UserControlSubMenuSabores()
        {
            InitializeComponent();
        }

        private void buttonAdicionarSabor_Click(object sender, EventArgs e)
        {
            FormSabores sabores = new FormSabores()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = sabores.ShowDialog();
        }
    }
}
