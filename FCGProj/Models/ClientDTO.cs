namespace FCGProj.Models
{
    public class ClientDTO
    {
        public string Name { get; set; }
        public string ClientUser { get; set; }
        public string Password { get; set; }
        public DateTime DtCreate { get; set; }
        public int IdAccessProfile { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}