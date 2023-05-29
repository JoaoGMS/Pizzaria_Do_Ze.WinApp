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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            textBoxProdutoNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxProdutoNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxValorProduto.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxValorProduto.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxProdutoML.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxProdutoML.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            comboBoxProdutoTipo.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            comboBoxProdutoTipo.Leave += new EventHandler(Funcoes.CampoEventoLeave!);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
