using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDwithEF_Codefirstapproach.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("StudentName", TypeName = "Varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column("StudentGender", TypeName = "Varchar(10)")]
        public string Gender { get; set; }

        [Required]
        [Column("StudentAge")]
        public int? Age { get; set; }

        [Required]
        public int? Standard { get; set; }
    }
}
