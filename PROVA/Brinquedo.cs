using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA
{
    //Crie uma classe publica chamada Brinquedo
    //Faça a herança com a classe Produto
    //Com os atrinutos:
    //-Categoria
//-Idade Mínima
//-Retorna concatenação do Código de Barras, Descrição e Categoria
//-Retorna concatenação do Código de Barras, Descrição, Categoria e Nome Fabricante
    public class Brinquedo : Produto
    {
        public string Categoria { get; set; }
        public int IdadeMinima { get; set; }
        public string CodigoDeBarrasDescricaoCategoria
        {
            get
            {
                return CodigoDeBarrasDescricao + " " + Categoria;
            }
        }
        public string CodigoDeBarrasDescricaoCategoriaNomeFabricante
        {
            get
            {
                return CodigoDeBarrasDescricaoCategoria + " " + Nome;
            }
        }
    }
}
