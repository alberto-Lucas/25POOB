using System;
using System.Windows.Forms;

namespace TestePOO
{
    //Toda classe precisa ser public
    public class Pessoa
    {
        //Atributo
        //é composto por
        //Nivel de acesso: Pulic
        //Tipo de dados: string
        //Nome do atributo: Nome
        //Configuração
        //get: leitura
        //set: gravação
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }

        //Método para exibir o CPF concatenado com o Nome
        //EX: CPF - NOME
        //Obrigatoria para eu acessar o método
        //fora da classe, ele precisa ser PUBLIC
        public void MsgCPFNome()
        {
            MessageBox.Show(CPF + " - " + Nome);
        }
    }
}
