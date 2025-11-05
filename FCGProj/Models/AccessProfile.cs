using FCGProj.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCGProj.Models
{
    [Table("ACCESSPROFILE")]
    public class AccessProfile
    {
        [Key]
        [Column("IDACCESSPROFILE")]
        public int IdAccessProfile { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
    }
}
