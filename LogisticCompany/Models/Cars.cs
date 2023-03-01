using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LogisticCompany.Models
{
    [Table("car")]
    public class Cars
    {
        [Key]
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("model")]
        public string Model { get; set; }
        [DataMember]
        [Column("mileage")]
        public int Mileage { get; set; }
        public virtual ICollection<Waybill> Waybills { get; set; } = new List<Waybill>();
            
    }
}
