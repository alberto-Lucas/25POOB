using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA
{
    public partial class Form1 : Form
    {
        //Crie a instancia da classe BrinquedoExecucao
        BrinquedoExecucao brinquedoExecucao = new BrinquedoExecucao();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Criar a instancia da classe Brinquedo
            Brinquedo brinquedo = new Brinquedo();
            //Atribuir os valores dos textBox aos atributos da classe Brinquedo
            brinquedo.Cnpj = txtCNPJ.Text;
            brinquedo.Nome = txtNome.Text;
            brinquedo.CodigoDeBarras = txtCodBarras.Text;
            brinquedo.Descricao = txtDescricao.Text;
            brinquedo.Preco = decimal.Parse(txtPreco.Text);
            brinquedo.Categoria = txtCategoria.Text;
            brinquedo.IdadeMinima = int.Parse(txtIdadeMinima.Text);
            //Adicionar o brinquedo na lista
            brinquedoExecucao.Adicionar(brinquedo);
            //Limpar os textBox
            txtCNPJ.Clear();
            txtNome.Clear();
            txtCodBarras.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtCategoria.Clear();
            txtIdadeMinima.Clear();
            //Atualizar a lista
            AtualizarLista();

        }

        //crie o método AtualizarLista
        private void AtualizarLista()
        {
            lstRegistros.DataSource = null;
            lstRegistros.DataSource = brinquedoExecucao.Listar();
            //            -No ListBox apresentar o registro da seguinte forma: Código de Barras
            // Descrição
            //Categoria
            //Nome Fabricante
            //Em brinquedo.CodigoDeBarrasDescricaoCategoriaNomeFabricante
            lstRegistros.DisplayMember = "CodigoDeBarrasDescricaoCategoriaNomeFabricante";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Remover o brinquedo selecionado na lista
            //usando ObterBrinquedoSelecionado()
            Brinquedo brinquedo = ObterBrinquedoSelecionado();
            if (brinquedo != null)
            {
                brinquedoExecucao.Remover(brinquedo);
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Selecione um brinquedo para remover.");
            }
        }

        //Criar método para extrair o item selecionado no list box
        //ira retornar um Brinquedo
        private Brinquedo ObterBrinquedoSelecionado()
        {
            if (lstRegistros.SelectedItem != null)
            {
                return (Brinquedo)lstRegistros.SelectedItem;
            }
            return null;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //Exibir os detalhes do brinquedo selecionado na tela frmVisualizar
            Brinquedo brinquedo = ObterBrinquedoSelecionado();
            if (brinquedo != null)
            {
                frmVisualizar frm = new frmVisualizar(brinquedo);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um brinquedo para visualizar.");
            }
        }
    }
}
