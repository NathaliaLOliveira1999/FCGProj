using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCGProj.Model
{
    [Table("CLIENTCONTACT")]
    public class ClientContact
    {
        [Key]
        [Column("IDCLIENTCONTACT")]
        public int IdClientContact { get; set; }
        [Column("IDCLIENTUSER")]
        public int IdClient { get; set; }
        [Column("CONTACTTYPE")]
        public string ContactType { get; set; }
        [Column("CONTACTVALUE")]
        public string ContactValue { get; set; }
        [Column("OBS")]
        public string Obs { get; set; }
        [Column("DTCREATE")]
        public DateTime DtCreate { get; set; }
        
    }
}
