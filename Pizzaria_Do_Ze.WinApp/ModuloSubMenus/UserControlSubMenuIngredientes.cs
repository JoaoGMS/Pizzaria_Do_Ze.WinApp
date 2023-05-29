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
    public partial class UserControlSubMenuIngredientes : UserControl
    {
        public UserControlSubMenuIngredientes()
        {
            InitializeComponent();
        }

        private void UserControlSubMenuIngredientes_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdicionarIngredientes_Click(object sender, EventArgs e)
        {
            FormIngrediente ingrediente = new FormIngrediente()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = ingrediente.ShowDialog();
        }
    }
}
