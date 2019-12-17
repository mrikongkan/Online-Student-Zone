using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Student_Zone.Models
{    
    public class Students
    {
        [Key]
        public int Id { get; set; }      
        
        [Display(Name ="First Name")]        
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Your Age")]
        [Range(15,100)]
        public int Age { get; set; }

        [Display(Name = "Father's Name")]
        public string FathersName { get; set; }

        [Display(Name = "Mother's Name")]
        public string MothersName { get; set; }

        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        [Display(Name = "District Name")]
        public string DistrictName { get; set; }

        [Display(Name = "Upazila Name")]
        public string UpazilaName { get; set; }

        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }

        [Display(Name = "Email Id")]
        public string EmailId { get; set; }

        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}