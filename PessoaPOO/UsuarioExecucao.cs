using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaPOO
{
    //Classe para manipular o objeto Usuario
    public class UsuarioExecucao
    {
        //Criar um lista para armazenar um
        //conjunto de usuarios

        //Como está privada somente a classe UsuarioExecucao
        //terá acesso a listaUsuario
        private List<Usuario> listaUsuario =
            new List<Usuario>();

        //Método para adicionar um usuário a lista
        public void Adicionar(Usuario usuario)
        {
            listaUsuario.Add(usuario);
        }

        public void Remover(Usuario usuario)
        {
            listaUsuario.Remove(usuario);
        }

        //Criar método
        //que retorna todos os itens da lista
        //com a possibiliade de pesquisa por nome
        public List<Usuario> Pesquisar(string nome)
        {
            //Primeiro precisamos criar uma nova lista
            //para retornar os dados pesquisados
            //assim a lista original nunca será afetada
            List<Usuario> listaPesquisa = 
                new List<Usuario>();

            //Neste caso ireia realizar um filtro
            //pelo nome na nossa nova lista
            //a deixando apenas com os registros
            //encontrados
            //semelhante a um SELECT no banco de dados
            //@ = parametro ou variavel
            //SELECT * FROM Usuario WHERE nome = @nome

            //Utilizar um recurso chamando FindAll
            //ou seja encontre todos os dados
            //compativeis
            //Para realizar o filtro iremos usar um recurso
            //chamado LAMBDA (=>)
            //ele serve para força o apontamento de memoria

            //x vai receber o resultado  da consulta
            //Esse processo é realizado item a item da lista

            //Contains é semelhante ao LIKE
            //vai procurar o contem de texto
            //Ex: nome contem "Lu"
            listaPesquisa = 
                listaUsuario.FindAll(
                    x => x.Nome.Contains(nome));

            //Se eu não passar nenhum nome para consulta
            //irá retornar todos os itens da lista

            //E por fim retornamos a lista filtrada
            return listaPesquisa;
        }

    }
}
