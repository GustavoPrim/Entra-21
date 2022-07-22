using Entra21.BancoDados01.Ado.Net.Exercicio.Models;
using Entra21.BancoDados01.Ado.Net.Exercicio.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;
        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            idEdicao = unidadeFederativa.Id;
            textBoxNomeUf.Text = unidadeFederativa.Nome;
            textBoxSiglaUf.Text = unidadeFederativa.Sigla;
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if(textBoxNomeUf.Text.Length < 3 || textBoxNomeUf.Text.Length > 30)
            {
                MessageBox.Show("Nome da Unidade Federativa deve ser maior que 3 e menor que 30 caracteres");
                return;
            }

            if(textBoxSiglaUf.Text.Length != 2)
            {
                MessageBox.Show("Sigla da Unidade Federativa deve conter 2 caracteres.");
                return;
            }

            var nome = textBoxNomeUf.Text.Trim();
            var sigla = textBoxSiglaUf.Text.Trim().ToUpper();
            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Nome = nome;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadeFederativaService();
            if (idEdicao == -1)
            {
                unidadeFederativaService.Cadastrar(unidadeFederativa);
                MessageBox.Show("Unidade Federativa cadastrada com sucesso");
                Close();
                return;
            }

            unidadeFederativa.Id = idEdicao;
            unidadeFederativaService.Editar(unidadeFederativa);
            MessageBox.Show("Unidade Federativa alterada com sucesso");
            Close();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
