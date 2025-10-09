namespace ProjetoCRUDMVC.Models
{
    //Classe dentro da camada Model
    //que representa a entidade Usuario
    //geralmente um espelho do banco de dados
    public class Usuario
    {
        //Adicionar os atributos
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
