using System;
using System.Windows.Forms;
using testeMVC.Controllers;

namespace testeMVC.Views
{
    public partial class frmVisUsuario : Form
    {
        //Importar camadas Models e Controllers
        //using Nome_Porjeto.Models;
        //using Nome_Porjeto.Controllers;

        //Cirar instancia com a controller
        UsuarioController usuarioController = new UsuarioController();

        public frmVisUsuario()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = usuarioController.GetAll();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadUsuario frm = new frmCadUsuario();
            if (frm.ShowDialog() == DialogResult.OK)
                btnPesquisar.PerformClick();
        }
    }
}
