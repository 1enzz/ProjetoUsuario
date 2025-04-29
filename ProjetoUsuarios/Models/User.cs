namespace ProjetoUsuarios.Models
{
    public class User
    {
        //caso queira especificar o nome de um campo vindo do json pode usar:
        //[JsonPropertyName("user_id")] - onde esta o "user_id" vai ser o nome que ira corresponder ao atributo no json
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
