using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar a nossa classe Pessoa
            //Apenas instanciando
            //(ou seja alocando a classe pessoa me memoria)
            //Composto por
            //Tipode de Dados: Pessoa(Do mesmo tipo da classe)
            //Variavel: pessoa (geralmente mesmo nome da classe)
            //=: atribuir o ponteiro da memoria a variavel
            //new: ação de alocar na memoria
            //Construtor da classe: Pessoa() (o mesmo nome do tipo de dados)
            Pessoa pessoa = new Pessoa();

            //Após instanciado, conseguimos acessar
            //o conteudo da classe q é permetido(public)
            //seguindo o exemplo
            //vamos definir um valor para o atributo Nome
            //Para isso, é preciso usar a variavel com a instancia
            //utilizar o sinal de ponto . para acessar as inforamções
            //disponiveis, e utilizar o atributo ou método desejado
            pessoa.Nome = "Lucas";
            pessoa.CPF = "5165456";
            pessoa.DtNascimento = DateTime.Now.Date; //data atual

            //Criar ou classe pessoa
            Pessoa aluno = new Pessoa();
            aluno.Nome = "João";
            aluno.CPF = "546545";
            aluno.DtNascimento = DateTime.Now.Date;

            //Exibir os dados usando o método
            ExibirClasse(pessoa);
            ExibirClasse(aluno);

            pessoa.MsgCPFNome();
            aluno.MsgCPFNome();
        }

        //Criar um para exibir dados da classe Pessoa
        void ExibirClasse(Pessoa classe)
        {
            MessageBox.Show(
                "Nome: " + classe.Nome + Environment.NewLine +
                "CPF: " + classe.CPF + Environment.NewLine +
                "DtNascimento: " + classe.DtNascimento.ToShortDateString());
        }

        //Criar a instancia de maneira global
        Usuario usuario = new Usuario();
        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Criar a instancia da classe Usuario
            //de maneira global
            //Apos instanciada, atribuir dados
            usuario.Nome = txtNome.Text;
            usuario.CPF = txtCPF.Text;
            usuario.DtNascimento = dtpDtNascimento.Value;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            MessageBox.Show("Usuário salvo com sucesso.");
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            usuario.MsgCPFNome();
        }
    }
}
