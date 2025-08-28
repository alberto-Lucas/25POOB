using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePOO
{
    //Irá herdar da classe pessoa
    //recebendo seus atributos
    //Utilizando o sinal de : para realizar
    //a herança da classe desejada
    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
