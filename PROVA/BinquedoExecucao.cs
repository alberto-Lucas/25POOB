using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA
{
    //Crie a classe publica BrinquedoExecucao
    //Métodos:
    //-Adicionar: Recebe objeto como parâmetros
    //-Remover: Recebe objeto como parâmetros
    //-Listar: Retorna a lista de objetos
    public class BrinquedoExecucao
    {
        //Criar a lista de brinquedos
        private List<Brinquedo> brinquedos = new List<Brinquedo>();
        //Adicionar brinquedo na lista
        public void Adicionar(Brinquedo brinquedo)
        {
            brinquedos.Add(brinquedo);
        }
        //Remover brinquedo da lista
        public void Remover(Brinquedo brinquedo)
        {
            brinquedos.Remove(brinquedo);
        }
        //Listar os brinquedos da lista
        public List<Brinquedo> Listar()
        {
            return brinquedos;
        }
    }
}
