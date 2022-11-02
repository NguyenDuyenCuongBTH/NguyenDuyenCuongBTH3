using System.ComponentModel.DataAnnotations;
namespace NguyenDuyenCuongBTH3.Models
{
    public class Employee
    {
        [Key]
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
    }
}