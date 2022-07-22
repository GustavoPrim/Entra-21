using Entra21.BancoDados01.Ado.Net.Exercicio.Models;
using Entra21.BancoDados01.Ado.Net.Exercicio.Services;

namespace Entra21.BancoDados01.Ado.Net.Exercicio.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        private readonly int _idEditar;
        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();
            PreencherComboBox();
            _idEditar = -1;
        }

        public CidadeCadastroEdicaoForm(Cidade cidade) : this()
        {
            _idEditar = cidade.Id;
            textBoxNome.Text = cidade.Nome;

            for(var i = 0; i < comboBoxEstado.Items.Count; i++)
            {
                var estadoPercorrido = comboBoxEstado.Items[i] as UnidadeFederativa;
                if (estadoPercorrido.Id == cidade.UnidadeFederativa.Id)
                    comboBoxEstado.SelectedItem = estadoPercorrido;
            }
        }

        public void PreencherComboBox()
        {
            var cidadeService = new CidadeService();
            var cidades = cidadeService.ObterTodos();

            for (var i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];
                comboBoxEstado.Items.Add(cidade);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length < 3 || textBoxNome.Text.Length > 40)
            {
                MessageBox.Show("Digite um nome com no mínimo 3 caracteres e no máximo 40.", @"
                                            ATENÇÃO");
                return;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //LimparCampos();
        }
    }
}
