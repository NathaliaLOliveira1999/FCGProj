using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCGProj.Model
{
    [Table("CLIENTADDRESS")]
    public class ClientAddress
    {
        [Key]
        [Column("CLIENTADDRESS")]
        public int IdClientAddress { get; set; }
        [Column("IDCLIENTUSER")]
        public int IdClient { get; set; }
        [Column("STREET")]
        public string Street { get; set; }
        [Column("NUM")]
        public string Number { get; set; }
        [Column("OBS")]
        public string Obs { get; set; }
        [Column("CITY")]
        public string City { get; set; }
        [Column("STATE")]
        public string State { get; set; }
        [Column("ZIPCODE")]
        public string ZipCode { get; set; }
        [Column("DTCREATE")]
        public DateTime DtCreate { get; set; }
        
    }
}
