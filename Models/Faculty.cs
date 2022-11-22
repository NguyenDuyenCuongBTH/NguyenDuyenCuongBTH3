using System.ComponentModel.DataAnnotations;

namespace NguyenDuyenCuongBTH3.Models;

    public class Faculty
    {
        [Key]
        public string? FacultyID { get; set; }
        public string? FacultyName { get; set; }

    }
