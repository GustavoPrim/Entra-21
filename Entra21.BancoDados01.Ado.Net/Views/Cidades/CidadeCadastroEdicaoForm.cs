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
            _idEditar = -1;
            PreencherComboBox();
        }

        public CidadeCadastroEdicaoForm(Cidade cidade) : this()
        {
            _idEditar = cidade.Id;
            textBoxNome.Text = cidade.Nome;
            textBoxPib.Text = cidade.Pib.ToString();
            textBoxQuantidadeHabitantes.Text = cidade.QuantidadeHabitantes.ToString();
            dateTimePickerHoraFundacao.Value = Convert.ToDateTime(cidade.DataHoraFundacao.ToString("HH:mm:ss"));

            for (var i = 0; i < comboBoxEstado.Items.Count; i++)
            {
                var estadoPercorrido = comboBoxEstado.Items[i] as UnidadeFederativa;

                if (estadoPercorrido.Id == cidade.UnidadeFederativa.Id)
                {
                    comboBoxEstado.SelectedItem = estadoPercorrido;
                    break;
                }
            }
        }

        public void PreencherComboBox()
        {
            var unidadeFederativaService = new UnidadeFederativaService();
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            for (var i = 0; i < unidadesFederativas.Count; i++)
            {
                var uf = unidadesFederativas[i];
                comboBoxEstado.Items.Add(uf);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var uf = comboBoxEstado.SelectedItem as UnidadeFederativa;

            if (ValidacaoDados() == false)
                return;

            var cidade = new Cidade();
            cidade.Nome = textBoxNome.Text.Trim();
            cidade.QuantidadeHabitantes = Convert.ToInt32(textBoxQuantidadeHabitantes.Text.Trim());
            cidade.UnidadeFederativa = uf;
            cidade.DataHoraFundacao = Convert.ToDateTime(dateTimePickerDataFundacao.Value.Date.ToString("dd/MM/yyyy") + " " +
                dateTimePickerHoraFundacao.Value.TimeOfDay);
            cidade.Pib = Convert.ToDecimal(textBoxPib.Text.Trim().Replace(".", ","));

            var cidadeService = new CidadeService();

            if (_idEditar == -1)
            {
                cidadeService.Cadastrar(cidade);
                MessageBox.Show("Cidade cadastrada com sucesso");
                Close();
            }
            else
            {
                cidade.Id = _idEditar;
                cidadeService.Editar(cidade);
                MessageBox.Show("Cidade alterada com sucesso"); ;
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ValidacaoDados()
        {
            if (textBoxNome.Text.Length < 3 || textBoxNome.Text.Length > 30)
            {
                MessageBox.Show("Digite um nome com no mínimo 3 caracteres e no máximo 40.");
                textBoxNome.Focus();
                return false;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Unidade Federal para a cidade");
                comboBoxEstado.DroppedDown = true;
                return false;
            }

            if (dateTimePickerDataFundacao.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Data de fundação não pode ser maior que a data atual");
                dateTimePickerDataFundacao.Focus();
                return false;
            }

            try
            {
                var quantidadeHabitantes = Convert.ToInt32(textBoxQuantidadeHabitantes.Text.Trim());
                if (quantidadeHabitantes < 0)
                {
                    MessageBox.Show("Quantidade de habitantes não pode ser negativa");
                    textBoxQuantidadeHabitantes.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("A quantidade de habitantes deve ser um número inteiro válido");
                textBoxQuantidadeHabitantes.Focus();
                return false;
            }

            try
            {
                var pib = Convert.ToDecimal(textBoxPib.Text.Trim().Replace(".", ","));
                if (pib < 10000)
                {
                    MessageBox.Show("O valor do PIB não pode ser inferior a R$10.000");
                    textBoxPib.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("O valor do PIB deve ser um número decimal válido");
                textBoxPib.Focus();
                return false;
            }

            return true;
        }
    }
}