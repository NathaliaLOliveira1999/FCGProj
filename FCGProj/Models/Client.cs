using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCGProj.Model
{
    [Table("CLIENT_USER")]
    public class Client
    {
        [Key]
        [Column("IDCLIENTUSER")]
        public int IdClient { get; set; }
        [Column("CLIENTNAME")]
        public string Name { get; set; }
        [Column("CLIENTUSER")]
        public string ClientUser { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
        [Column("DTCREATE")]
        public DateTime DtCreate { get; set; }
        [Column("IDACCESSPROFILE")]
        public int IdAccessProfile { get; set; }
        public List<ClientContact?> ClientContacts { get; set; }
        public List<ClientAddress?> ClientAddresses { get; set; }
    }
}
