using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CodeFirst_CRUD.Models;


public class Student
{
    [Key]
    public int SID { get; set; }
    [Required(ErrorMessage = "Enter Name")]
    [RegularExpression(@"^([A-Za-z\s]+)$")]


    public string SName { get; set; }
    [Required(ErrorMessage = "Enter Roll Number")]

    public string RollNum { get; set; }

    [Required(ErrorMessage = "Enter Date of Birth")]
    public DateTime DOB { get; set; }



    [Required(ErrorMessage = "Mobile Number")]
    public int Mobile{ get; set; }
    
    [Required(ErrorMessage = "Enter Branch")]
    public string Branch { get; set; }
    [Required(ErrorMessage = "Enter College Name")]
    public string CollegeName { get; set; }


    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }


    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Enter the Password")]
    public string SPassword { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Enter the Confirm Password")]
    [Compare("SPassword", ErrorMessage = "Password does not match")]
    public string StudentConfirmPassword { get; set; }


}
