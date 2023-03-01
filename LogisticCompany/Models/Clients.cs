using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LogisticCompany.Models
{
    [Table("client")]
    public class Clients
    {
        [Key]
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("name")]
        public string Name { get; set; }
        [DataMember]
        [Column("address")]
        public string Address { get; set; }
        public virtual ICollection<Waybill> Waybill { get; set; } = new List<Waybill>();

    }
}
