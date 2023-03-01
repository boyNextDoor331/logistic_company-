using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LogisticCompany.Models
{
    [Table("waybill")]
    public class Waybill
    {
        [Key]
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("client_id")]
        public int ClientsID { get; set; }
        [DataMember]
        [Column("car_id")]
        public int CarsID { get; set; }
        [DataMember]
        [Column("employee_id")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public Clients Clients { get; set; }
        public Cars Cars { get; set; }
    }
}
