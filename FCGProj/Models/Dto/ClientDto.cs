namespace FCGProj.Models.Dto
{
    public class ClientDto
    {
        public string Name { get; set; }
        public int IdAccessProfile { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public UserDto User { get; set; }
    }
}