using System;
using System.Windows.Forms;

namespace PROVA
{
    public partial class frmVisualizar : Form
    {
        public frmVisualizar(Brinquedo brinquedo)
        {
            InitializeComponent();

            // Exibe os dados do brinquedo nos controles do formulário
            txtCNPJ.Text = brinquedo.Cnpj;
            txtNome.Text = brinquedo.Nome;
            txtCodBarras.Text = brinquedo.CodigoDeBarras;
            txtDescricao.Text = brinquedo.Descricao;
            txtPreco.Text = brinquedo.Preco.ToString("F2");
            txtCategoria.Text = brinquedo.Categoria;
            txtIdadeMinima.Text = brinquedo.IdadeMinima.ToString();

        }
    }
}