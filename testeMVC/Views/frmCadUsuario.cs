using System;
using System.Windows.Forms;
using testeMVC.Models;
using testeMVC.Controllers;

namespace testeMVC.Views
{
    public partial class frmCadUsuario : Form
    {
        //Importar camadas Models e Controllers
        //using Nome_Porjeto.Models;
        //using Nome_Porjeto.Controllers;

        //Cirar instancia com a controller
        UsuarioController usuarioController = new UsuarioController();
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            if (usuarioController.Inserir(usuario) > 0)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o usuário!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Deseja cancelar o cadastro do usuário?", 
                "Atenção",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                DialogResult = DialogResult.Cancel;
        }
    }
}
