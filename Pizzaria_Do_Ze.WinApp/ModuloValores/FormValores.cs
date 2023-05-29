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
    public partial class FormValores : Form
    {
        public FormValores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);


            comboBoxValoresTamanho.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            comboBoxValoresTamanho.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            comboBoxValoresCategoria.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            comboBoxValoresCategoria.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            textBoxValoresValor.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxValoresValor.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxValorBordaValores.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxValorBordaValores.Leave += new EventHandler(Funcoes.CampoEventoLeave!);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
