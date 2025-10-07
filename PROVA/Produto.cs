using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA
{
    //Faça a herança com a classe Fabricante
    //public class Produto : Fabricante
    public class Produto : Fabricante
    {
        public string CodigoDeBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string CodigoDeBarrasDescricao
        {
            get
            {
                return CodigoDeBarras + " " + Descricao;
            }        
        }
    }
}
