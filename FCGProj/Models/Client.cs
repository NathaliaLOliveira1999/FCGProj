using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCGProj.Model
{
    [Table("CLIENT")]
    public class Client
    {
        [Key]
        [Column("IDCLIENT")]
        public int IdClient { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("DTCREATE")]
        public DateTime DtCreate { get; set; }
        [Column("IDACCESSPROFILE")]
        public int IdAccessProfile { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("TELEFONE")]
        public string Telefone { get; set; }
    }
}
