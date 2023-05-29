using Pizzaria_do_Zé;
using Pizzaria_Do_Ze.DAO;
using Pizzaria_Do_Ze.WinApp.ModuloFuncao;
using Pizzaria_Do_Ze.WinApp.ModuloIngredientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{


    public partial class FormIngrediente : Form
    {
        private readonly IngredienteDAO dao;
        //

        //
        public FormIngrediente()
        {


            

            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);


            textBoxIngredientesID.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxIngredientesID.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            textBoxIngredientesNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            textBoxIngredientesNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        #region EVENTOS

        private void buttonSalvarIngredienteCadastro_Click(object sender, EventArgs e)
        {
           /* // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);*/

            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = textBoxIngredientesNome.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLimparIngredienteCadastro_Click(object sender, EventArgs e)
        {
            textBoxIngredientesID.Clear();
            textBoxIngredientesNome.Clear();
        }

        private void buttonCancelarIngredienteCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IngredienteDAO ingredienteDAO;
        private void AtualizarTela()
        {
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);

            UserControlListarIngredientes ucLI = new();
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                ucLI.dataGridViewDados.Columns.Clear();
                ucLI.dataGridViewDados.AutoGenerateColumns = true;
                ucLI.dataGridViewDados.DataSource = linhas;
                ucLI.dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion



    }


}
