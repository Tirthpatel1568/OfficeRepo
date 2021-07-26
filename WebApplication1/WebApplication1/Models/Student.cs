using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string StudentName { get; set; }
        [Range(10,20)]
        public int Age{ get; set; }
        public bool isNewlyEnrolled{ get; set; }
        public bool isActive { get; set; }
        public string Password{ get; set; }
        public string gender { get; set; }
        //public Standard standard { get; set; }
        public Gender StudentGender { get; set; }
    }
    public enum Gender
    {
        Male, Female
    }
}