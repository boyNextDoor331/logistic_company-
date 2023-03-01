using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LogisticCompany.Models
{
    [Table("role")]
    public class Role
    {
        [Key]
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("name")]
        public string Name { get; set; }
        [DataMember]
        [Column("salary")]
        public int Salary { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
