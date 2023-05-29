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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            //adiciona eventos em geral, exemplo: ganhar e perder o foco

            textBoxClienteNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxClienteNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            textBoxEmailCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxEmailCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxTelefoneCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxTelefoneCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            maskedTextBoxCPFCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            maskedTextBoxCPFCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            textBoxClienteEndereco.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxClienteEndereco.Leave += new EventHandler(Funcoes.CampoEventoLeave!);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        #region EVENTOS

        private void buttonLimparClienteCadastro_Click(object sender, EventArgs e)
        {
            textBoxClienteNome.Clear();
            textBoxClienteEndereco.Clear();
            textBoxEmailCliente.Clear();
            maskedTextBoxCPFCliente.Clear();
            maskedTextBoxTelefoneCliente.Clear();

        }

        private void buttonCancelarClienteCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*// Verifique se a tecla pressionada é a tecla ESC
        if (e.KeyCode == Keys.Escape)
        {
        // Fechar o formulário
        this.Close();
        }*/
        #endregion

    }
}
