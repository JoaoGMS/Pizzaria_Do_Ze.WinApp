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
    public partial class UserControlSubMenuCliente : UserControl
    {
        public UserControlSubMenuCliente()
        {
            InitializeComponent();
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente() 
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = cliente.ShowDialog();
        }
    }
}
