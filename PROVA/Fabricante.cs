using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA
{
    //Primeiro passo, deixar a classe publica
    public class Fabricante
    {
        //Segundo passo, criar os atributos
        //processo para criar atributo
        //1 - escrever private
        //2 - escrever o tipo do atributo
        //3 - escrever o nome do atributo com a primeira letra minuscula
        //use o atalho do Visual Studio para criar o atributo
        //PROP + TAB + TAB
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        //Retorna concatenação do CNPJ com o Nome
        public string CnpjNome()
        {
            return Cnpj + " " + Nome;
        }
    }
}
