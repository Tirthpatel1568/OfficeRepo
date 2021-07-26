using CodeFirstApproach.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Display(Name = "Name",ResourceType =typeof(Resource))]

        public string Name { get; set; }
        public string  Gender { get; set; }

        public int StateID { get; set; }
        public State State { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public string Hobbies { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public string Adress { get; set; }
    }
}