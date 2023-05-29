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
    public partial class UserControlSubMenuValor : UserControl
    {
        public UserControlSubMenuValor()
        {
            InitializeComponent();
        }

        #region EVENTOS

        private void buttonAdicionarValor_Click(object sender, EventArgs e)
        {
            FormValores valores = new FormValores()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            _ = valores.ShowDialog();
        }
        #endregion
    }
}
