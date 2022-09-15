using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //class - table
    public class Student
    {
        // Properties == columns
        public int ID { get; set; }
        [Required]
        [StringLength(20,ErrorMessage="Last name must be only 20 character")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$",ErrorMessage ="Must Start with upper letter and  contain no spaces")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(20, ErrorMessage = "first name must be only 20 character")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Must Start with upper letter and  contain no spaces")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy--MM--dd}",ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        //navegation Property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
