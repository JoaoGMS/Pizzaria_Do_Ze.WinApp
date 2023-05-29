using Pizzaria_do_Zé;
using Pizzaria_Do_Ze.WinApp.ModuloFuncao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class FormSabores : Form
    {
        public FormSabores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);


            textBoxSaboresNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxSaboresNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            comboBoxSaboresCategoria.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            comboBoxSaboresCategoria.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            comboBoxSaboresTipo.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            comboBoxSaboresTipo.Leave += new EventHandler(Funcoes.CampoEventoLeave!);




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
