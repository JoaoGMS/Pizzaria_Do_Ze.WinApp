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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);


            textBoxFuncionarioNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxFuncionarioNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxCPFFuncionario.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxCPFFuncionario.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            textBoxFuncionarioMatricula.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxFuncionarioMatricula.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxTelefoneFuncionario.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxTelefoneFuncionario.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            textBoxFuncionarioSenha.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxFuncionarioSenha.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            comboBoxFuncionarioFuncao.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            comboBoxFuncionarioFuncao.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
