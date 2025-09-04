using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaPOO
{
    //Usuario herda de Pessoa
    //Recebe tudo o que estiver publico
    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public string NomeEmail
        {
            get
            {
                return CPFNome + " - " + Email; 
            }
        }
    }
}
