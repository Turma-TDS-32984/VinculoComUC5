using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinculoComUC5
{
    public partial class Form1 : Form
    {
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;
        protected Pessoa pessoa = null;
        public Form1()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            btnSalvarComo.Enabled = false;
            btnInserir.Enabled = false;
        }
        /// <summary>
        /// Ao clicar, o código irá visualizar os dados
        /// </summary>
        /// <param name="sender">Botão de btnObterDados</param>
        /// <param name="e">O evento de click</param>
        private void btnObterDados_Click(object sender, EventArgs e)
        {
            // Alterar para ativar o botão
            btnSalvar.Enabled = true;
            btnSalvarComo.Enabled = true;
            btnInserir.Enabled = true;
            // Limpar nossa lista
            lboDados.Items.Clear();
            //pipeline
            leitura.Filter = "|*.txt";
            leitura.Title = "Selecione o arquivo que contem os dados";
            //Verificar se deu tudo certo ao clicar em OK, após selecionar o dado
            //Se ao obter o caminho o caminho deu certo, continua, caso contrario encerra
            if (leitura.ShowDialog() != DialogResult.OK) return;
            //Obtendo o caminho do arquivo
            caminho = leitura.FileName;
            //Tenta executar o trecho do código
            try
            {
                //Ao digitar o comando, lembre-se de clicar na lampada com x
                //Depois em using System.IO;
                //A criação de variavel com var, precisa da atribuição na sequencia
                //O File, irá fazer a leitura dos dados dentro do arquivo que passei o caminho
                var textoLido = File.ReadAllText(caminho);
                //Extrair texto e coloca dentro do vetor linhas
                string[] linhas = textoLido.ToString().Split('\n');
                //for (int i = 0; i < linhas.lenght;i++) lboDados.Items.Add(linhas[i])
                //foreach (string linha in linhas) lboDados.Items.Add(linha);

                for (int i = 0; i<linhas.Length; i = i + 4)
                {
                    string nome = linhas[i]; //Vem do arquivo dadosdogoverno.txt
                    char sexo = linhas[i+1].ToString()[0];
                    string escolaridade = linhas[i+2];
                    string classe = linhas[i+3];
                    Pessoa novaPessoa = new Pessoa(nome, sexo, escolaridade, classe);
                    lboDados.Items.Add(novaPessoa);
                }
            }
            
            // Caso aconteça qualquer erro no try, vou pegar esse erro
            catch(Exception erro)
            {
                //Qualquer erro que aparecer, vou visualizar
                MessageBox.Show(erro.Message);
            }
        }
        /// <summary>
        /// Função que ao selecionar uma pessoa na lista, posso modificar ou excluir sua informação
        /// </summary>
        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vou obter os dados da pessoa antes de atualizar
            Pessoa antigaPessoa = (sender as ListBox).SelectedItem as Pessoa;
            // Vou validar se o dado selecione existe
            if (antigaPessoa == null) return;
            // Cria uma nova entidade de pessoa para obter a atualização dos dados
            Pessoa novaPessoa;
            // Enquanto o formulario estiver ativo, espero ele finalizar para obter sua resposta 
            // sobre a atualização dos dados
            using (Cadastro cadastro = new Cadastro(antigaPessoa))
            {
                cadastro.ShowDialog();
                novaPessoa = cadastro.pessoa;
            }
            // Retiro a seleção no ListBox da pessoa que vai ser atualizada
            lboDados.ClearSelected();
            if (novaPessoa == null)
                lboDados.Items.Remove(antigaPessoa);
            else
            {
                // Procuro a pessoa que será atualizada
                for (int i = 0; i < lboDados.Items.Count; i++)
                {
                    //Se encontrar, mude
                    if (lboDados.Items[i] == antigaPessoa)
                    {
                        lboDados.Items[i] = novaPessoa;
                        // Pare de procurar uma pessoa -> comando break;
                        break;
                    }
                }
            }
            //Atualiza o nosso listBox com as novas informaçõeF
            lboDados.Update();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Cria uma nova pessoa
            Pessoa novaPessoa;
            // Aguarda uma resposta de Cadastro
            using (Cadastro cadastro = new Cadastro())
            {
                cadastro.ShowDialog();
                novaPessoa= cadastro.pessoa;
            }
            //Caso nova pessoa seja vazia, não adiciona na lista
            if (novaPessoa == null)
                return;
            //Adiciona a nova pessoa no final da lista
            lboDados.Items.Add(novaPessoa);
            lboDados.Update();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Se não tiver base de dados, impede o salvamento
            if (caminho == null) return;
            // Faz a abertura o arquivo txt
            StreamWriter salvarArquivo = new StreamWriter(caminho);
            //Cria o texto para salvamento
            string texto = "";
            //Adiciona os dados dentro do arquivo
            foreach (Pessoa pessoa in lboDados.Items)
            {
                texto += pessoa.nome + "\n";
                texto += pessoa.sexo == 'F' ? "Feminino\n" : "Masculino\n";
                texto += pessoa.escolaridade + "\n";
                texto += pessoa.classe + "\n";
            }
            //Salva os dados dentro do arquivo
            salvarArquivo.WriteLine(texto);
            //Fecha o arquivo salvo
            salvarArquivo.Close();
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            //Se não tiver nenhum elemento na lista, impede de continuar
            if (lboDados.Items.Count == 0) return;
            // Filtra, sugere e entitulo o dialogo
            salvamento.Filter = "Arquivo TXT|*.txt";
            salvamento.FileName = "dadosdogoverno";
            salvamento.Title = "Salvar arquivo";
            // Verifica se a pessoa selecionou o local de salvamento e o nome do arquivo
            if (salvamento.ShowDialog() != DialogResult.OK &&
                salvamento.FileName == null) return;
            // Abre o arquivo salvo na pasta
            FileStream abrirArquivo = salvamento.OpenFile() as FileStream;
            // Obtem o arquivo salvo
            StreamWriter salvandoArquivo = new StreamWriter(abrirArquivo);
            //Trecho parecido com o salvar
            //Cria o texto para salvamento
            string texto = "";
            //Adiciona os dados dentro do arquivo
            foreach (Pessoa pessoa in lboDados.Items)
            {
                texto += pessoa.nome + "\n";
                texto += pessoa.sexo == 'F' ? "Feminino\n" : "Masculino\n";
                texto += pessoa.escolaridade + "\n";
                texto += pessoa.classe + "\n";
            }
            //Salva os dados dentro do arquivo
            salvandoArquivo.WriteLine(texto);
            //Fecha o arquivo salvo
            salvandoArquivo.Close();
            //Fecha o arquivo aberto
            abrirArquivo.Close();
        }
    }
}
