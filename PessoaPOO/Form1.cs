using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaPOO
{
    public partial class Form1 : Form
    {
        //Criar a instancia de acesso
        //a classe UsuarioExecucao
        UsuarioExecucao usuarioExecucao = 
            new UsuarioExecucao();
        public Form1()
        {
            InitializeComponent();
        }

        //Método para atualizar a List Box
        //com os dados cadastrados
        void AtualizarListBox()
        {
            //Limpar a fonte de dados do List Box
            lstUsuarios.DataSource = null;

            //Chamar o método pesquisar da classe
            //para retornar uma lista de usuarios
            //passando o parametro vazio
            //para retornar todos os usuarios

            //Por hora não vamos implementar a pesquisa
            //Somente exibir todos
            lstUsuarios.DataSource =
                usuarioExecucao.Pesquisar("");

            //Definir qual campo de Usuario será
            //exibido na List Box
            lstUsuarios.DisplayMember = "NomeEmail";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Pulamos a parte de validação
            //pois não é o objetivo no momento
            //o Foco é a manipulação do objeto e da lista

            //Criar uma instancia para usuario
            Usuario usuario = new Usuario();

            //Atribuir as informações ao objeto
            usuario.CPF = txtCpf.Text;
            usuario.Nome = txtNome.Text;
            usuario.DtNascimento = dtpDtNascimento.Value;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            //Agora podemos adicionar o nosso objeto
            //a lista de objetos usando o método adicionar
            //da classe de execução
            usuarioExecucao.Adicionar(usuario);

            //Precisamos atualizar a list Box
            AtualizarListBox();

            //Limpar os campos
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDtNascimento.Value = DateTime.Now;
        }

        //Função para extrair o usuario
        //selecionado da List Box
        Usuario ExtrairUsuario()
        {
            //Recuperar o registro selecionado
            //e transformalo no objeto Usuario
            //usado o as para converter o item em objeto
            return lstUsuarios.SelectedItem as Usuario;
        }

        private void lstUsuarios_DoubleClick(object sender, EventArgs e)
        {
            //Exibir os dados do objeto selecionado
            Usuario usuarioSelecionado = new Usuario();
            usuarioSelecionado = ExtrairUsuario();

            //Exibir os dados em tela
            txtVisCpf.Text = usuarioSelecionado.CPF;
            txtVisNome.Text = usuarioSelecionado.Nome;
            txtVisEmail.Text = usuarioSelecionado.Email;
            txtVisSenha.Text = usuarioSelecionado.Senha;
            txtVisDtNascimento.Text = 
                usuarioSelecionado.DtNascimento.ToShortDateString();
            txtVisIdade.Text = usuarioSelecionado.Idade.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Chamar o método remover da classe de execução
            usuarioExecucao.Remover(ExtrairUsuario());
            AtualizarListBox();
        }
    }
}
