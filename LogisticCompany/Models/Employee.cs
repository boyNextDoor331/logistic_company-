using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LogisticCompany.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("first_name")]
        public string Name { get; set; }
        [DataMember]
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Waybill> Waybill { get; set; }


    }
}
