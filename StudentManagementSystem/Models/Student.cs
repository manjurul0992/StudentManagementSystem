using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace StudentManagementSystem.Models
{
    public enum Section
    {
        Science = 1, Arts, Commerence
    }
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        
        [Required(ErrorMessage = "Student Name is requiered!!"), StringLength(50), Display(Name = "Employee Name")]
        public string StudentName { get; set; }

        [Required, DataType(DataType.Date), Column(TypeName = "datetime"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true),Display(Name ="Date Of Birth")]
        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "Class Name is requiered!!"), StringLength(50), Display(Name = "Class Name")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Section Name is requiered!!"), EnumDataType(typeof(Section))]
        public Section Section { get; set; }



    }
}