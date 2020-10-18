using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Required Field")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName ="varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string Position { get; set; }

        [Column(TypeName ="varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

    }
}
